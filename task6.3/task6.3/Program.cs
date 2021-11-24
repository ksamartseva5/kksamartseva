using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._3
{
    class Program
    {
        static void Main(string[] args)
        { 
                Console.WriteLine("Введите позицию белого слона");
                var whiteBishopPosition = Console.ReadLine();

                Console.WriteLine("Введите позицию черного короля");
                var blackKingPosition = Console.ReadLine();

                if (!IsFiguresPositionsCorrect(whiteBishopPosition, blackKingPosition))
                {
                    Console.WriteLine("Позиции фигур не соответствуют условиям задачи");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Введите ход белого слона");
                var move = Console.ReadLine();

                if (IsBishopCanMakeSafeMove(whiteBishopPosition, blackKingPosition, move))
                    Console.WriteLine($"Слон {whiteBishopPosition} может безопасно пойти на клетку {move}");
                else
                    Console.WriteLine($"Слон {whiteBishopPosition} не может пойти на клетку {move}");

                Console.ReadKey();
            }

            static bool IsFiguresPositionsCorrect(string BishopPosition, string KingPosition)
            {
                return !IsEqualPositions(BishopPosition, KingPosition) &&
                IsKingPositionCorrect(KingPosition) &&
                !IsBishopStrikesKing(BishopPosition, KingPosition) &&
                !IsKingStrikesBishop(BishopPosition, KingPosition);
            }

            static bool IsBishopCanMakeSafeMove(string BishopPosition, string KingPosition, string move)
            {
                return IsBishopCanMove(BishopPosition, move) &&
                !IsKingStrikesBishop(move, KingPosition);
            }

            static bool IsEqualPositions(string position1, string position2)
            {
                return position1 == position2;
            }

            static bool IsKingStrikesBishop(string BishopPosition, string KingPosition)
            {
                int qx, qy, px, py;

                GetCoordinates(BishopPosition, out qy, out qx);
                GetCoordinates(KingPosition, out py, out px);

            return Math.Abs(px - qx) == 1 || Math.Abs(py - qy) == 1;
            }

            static bool IsBishopStrikesKing(string BishopPosition, string KingPosition)
            {
                return IsBishopCanMove(BishopPosition, KingPosition);
            }

            static bool IsKingPositionCorrect(string KingPosition)
            {
                int px, py;
                GetCoordinates(KingPosition, out py, out px);

                return py > 0 && py < 7;
            }

            static bool IsBishopCanMove(string BishopPosition, string move)
            {
                int qx, qy, mx, my;
                GetCoordinates(BishopPosition, out qy, out qx);
                GetCoordinates(move, out my, out mx);

                return  Math.Abs(qy - my) == Math.Abs(qx - mx);
            }

            static void GetCoordinates(string position, out int row, out int column)
            {
                row = (int)position[1] - 0x31;
                column = (int)position[0] - 0x61;
            }
        }
    }
