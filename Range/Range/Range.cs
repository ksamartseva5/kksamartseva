using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeStruct
{
    public struct Range
    {
        public int LeftBorder{get;set;}
        int rightBorder;
        public int RightBorder
        {
            get => rightBorder;
            set
            {
                if (value < LeftBorder)
                    throw new ArgumentException("Правая граница должна быть больше левой!");
                rightBorder = value;
            }
        }
        public int Count
        {
            get => Math.Abs(RightBorder - LeftBorder);
        }
        public Range(int leftBorder, int rightBorder) : this()
        {
            LeftBorder = leftBorder;
            RightBorder = rightBorder;
        }
        public override string ToString() => $"[{LeftBorder}; {RightBorder})\"";
        public override bool Equals(object obj)
        {
            if (obj is Range)
                return (LeftBorder == ((Range)obj).LeftBorder) && (RightBorder == ((Range)obj).RightBorder);
            throw new ArgumentException("Объект для сравнения не является углом");
        }
        public bool IsContains(int numb, Range range)
        {
            bool flag = false;
            for(int i = LeftBorder; i < RightBorder; i++)
            {
                if (numb == i)
                    flag = true;
            }
            return flag;
        }
        public override int GetHashCode() => Count.GetHashCode();
        public static bool operator ==(Range x, Range y) => ((x.LeftBorder == y.LeftBorder) && (x.RightBorder == y.RightBorder));
        public static bool operator !=(Range x, Range y) => ((x.LeftBorder != y.LeftBorder) && (x.RightBorder != y.RightBorder));
        public static bool operator &(Range x, Range y) => (x.LeftBorder < y.RightBorder) && (x.RightBorder > y.LeftBorder);
        public static Range operator |(Range x, Range y)
        {
            int leftborder;
            int rightborder;
            if (x.LeftBorder <= y.LeftBorder)
                leftborder = x.LeftBorder;
            else
                leftborder = y.LeftBorder;
            if (x.RightBorder >= y.RightBorder)
                rightborder = x.RightBorder;
            else
                rightborder = y.RightBorder;
            return new Range(leftborder, rightborder);
        }
    }
}
