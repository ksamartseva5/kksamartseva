using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
   
    public partial class Form1 : Form
    {
        int number = 0;

        const int mapSize = 50;
        const int cellsSize = 12
            ;

        int[,] currentState = new int[mapSize, mapSize];
        int[,] nextState = new int[mapSize, mapSize];

        Button[,] cells = new Button[mapSize, mapSize];

        bool isPlaying = false;

        Timer mainTimer;

        int offset = 25;
        public Form1()
        {
            InitializeComponent();
            SetFormSize();
            BuildMenu();
            InIt();
           
        }
        void SetFormSize()
        {
            this.Width = (mapSize + 3) * cellsSize;
            this.Height = (mapSize + 4) * cellsSize + 35;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void InIt()
        {
            isPlaying = false;
            mainTimer = new Timer();
            mainTimer.Interval = 100;
            mainTimer.Tick += new EventHandler(UpdateStates);
            currentState = InItMap();
            nextState = InItMap();
            InItCells();
        }
        void ClearGame()
        {
            isPlaying = false;
            mainTimer = new Timer();
            mainTimer.Interval = 50;
            mainTimer.Tick += new EventHandler(UpdateStates);
            currentState = InItMap();
            nextState = InItMap();
            ResetCells();
        }
        void ResetCells()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    cells[i, j].BackColor = Color.White;
                }
            }
        }
        void BuildMenu()
        {
            var menu = new MenuStrip();

            var restart = new ToolStripMenuItem("Очистить");
            restart.Click += new EventHandler(Restart);

            var play = new ToolStripMenuItem("Старт");
            play.Click += new EventHandler(Play);

            var close = new ToolStripMenuItem("Выход");
            close.Click += new EventHandler(Close);

            menu.Items.Add(play);
            menu.Items.Add(restart);
            menu.Items.Add(close);

            this.Controls.Add(menu);
        }

        private void Close(object sender, EventArgs e)
        {
          
            this.Close();

        }

        private void Restart(object sender, EventArgs e)
        {
            mainTimer.Stop();
            ClearGame();
        }

        private void Play(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                isPlaying = true;
                mainTimer.Start();
            }
        }
     

        private void UpdateStates(object sender, EventArgs e)
        {
            CalculateNextState();
            DisplayMap();
           
        }

       

        void CalculateNextState()
        {
           
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var countNeighours = CountNeighbours(i, j);
                    if (currentState[i, j] == 0 && countNeighours == 3)
                    {
                        nextState[i, j] = 1;
                        number = number++;
                    }

                    else if (currentState[i, j] == 0 && countNeighours < 2 && countNeighours > 3)
                    {
                        nextState[i, j] = 0;
                    }
                    else if (currentState[i, j] == 0 && countNeighours >= 2 && countNeighours <= 3)
                    {
                        nextState[i, j] = 1;
                        number = number++;
                    } 
                    else
                    {
                        nextState[i, j] = 0;
                    }
                }
            }
            currentState = nextState;
            nextState = InItMap();
        }

        void DisplayMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (currentState[i, j] == 1)
                        cells[i, j].BackColor = Color.Black;
                    else cells[i, j].BackColor = Color.White;

                }
            }
        }
        int CountNeighbours(int i, int j)
        {
            var count = 0;
            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j + 1; l++)
                {
                    if (!IsInsideMap(k, l))
                        continue;
                    if (k == i && l == j)
                        continue;
                    if (currentState[k, l] == 1)
                        count++;
                }
            }
            return count;
        }
        bool IsInsideMap(int i, int j)
        {
            if (i < 0 || i >= mapSize || j < 0 || j >= mapSize)
            {
                return false;
            }
            return true;
        }

        int[,] InItMap()
        {
            int[,] arr = new int[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    arr[i, j] = 0;
                }
            }
            return arr;
        }

        void InItCells()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(cellsSize, cellsSize);
                    button.BackColor = Color.White;
                    button.Location = new Point(j * cellsSize, i * cellsSize + offset);
                    button.Click += new EventHandler(OnCellClick);
                    this.Controls.Add(button);
                    cells[i, j] = button;
                }
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            var pressedButton = sender as Button;
            if (!isPlaying)
            {
                var i = (pressedButton.Location.Y - offset) / cellsSize;
                var j = pressedButton.Location.X / cellsSize;

                if (currentState[i, j] == 0)
                {
                    currentState[i, j] = 1;
                    cells[i, j].BackColor = Color.Black;
                }
                else
                {
                    currentState[i, j] = 0;
                    cells[i, j].BackColor = Color.White;
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            ToolStripLabel infoLabel;

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Поколение:";

           
        }
    }
    }


