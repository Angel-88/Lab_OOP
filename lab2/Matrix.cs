using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Matrix
    {
        private int[,] _data;

        public int Width { get; }

        public int Length { get; }

        public Matrix(int width, int length)
        {
            if (width <= 0 || length <= 0)
            {
                throw new ArgumentException("Input Width/Length is incorrect");
            }

            _data = new int[width, length];
            Width = _data.GetLength(0);
            Length = _data.GetLength(1);
        }

        public void FillMatrixByRandomValues()
        {
            var rand = new Random();
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Length; j++)
                {
                    _data[i, j] = rand.Next(0, 99);
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i > Width)
                {
                    throw new ArgumentException("Parameter i out of the bound");
                }
                if (j < 0 || j > Length)
                {
                    throw new ArgumentException("Parameter j out of the bound");
                }
                return _data[i, j];
            }
            set
            {
                if (i < 0 || i > Width)
                {
                    throw new ArgumentException("Parameter i out of the bound");
                }
                if (j < 0 || j > Length)
                {
                    throw new ArgumentException("Parameter j out of the bound");
                }
                _data[i, j] = value;
            }
        }

        public int FindMaxElement()
        {
            var maxElement = _data[0, 0];
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Length; j++)
                {
                    if (maxElement <= _data[i, j])
                    {
                        maxElement = _data[i, j];
                    }
                }
            }
            return maxElement;
        }

        public int FindMixElement()
        {
            var mixElement = _data[0, 0];
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Length; j++)
                {
                    if (mixElement >= _data[i, j])
                    {
                        mixElement = _data[i, j];
                    }
                }
            }

            return mixElement;
        }

        public override string ToString()
        {
            var result = "";
            for (var i = 0; i < Width; i++)
            {
                result += "[";
                for (var j = 0; j < Length; j++)
                {
                    result += " ";
                    result += _data[i, j];
                }

                result += " ]\n";
            }

            return result;
        }
    }
}
