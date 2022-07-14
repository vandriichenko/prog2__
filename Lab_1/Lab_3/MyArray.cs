using System;

namespace Lab_3
{
    public class MyArray
    {
        public char[,] _array;

        public char[] this[int type]
        {
            get
            {
                char[] lala = new char[_array.GetLength(1)];
                int numRows = _array.GetLength(0);
                int numColumns = _array.GetLength(1);
                int i = 0;
                if (type == 0)
                {
                    for (int row = 0; row < numRows; ++row)
                    {

                        for (int col = 0; col < numColumns; ++col)
                        {
                            if (col == row)
                            {
                                lala[i++] = _array[row, col];
                            }

                        }
                    }
                }
                if (type == 1)
                    for (int row = numRows - 1; row >= 0; --row)
                    {

                        for (int col = numColumns - 1; col >= 0; --col)
                        {
                            if (col == row)
                            {
                                lala[i++] = _array[row, col];
                            }

                        }
                    }
                return lala;
            }
        }

        private int _countVowels;
        public int CountVowels
        {
            get
            {
                var count = 0;
                char[] vowels = { 'a', 'i', 'e', 'і', 'у' };
                foreach (var c in _array)
                {
                    if (Array.FindIndex(vowels, x => x == c) > -1)
                    {
                        count++;
                    }
                }

                return count;
            }
            set
            {
                _countVowels = value;
            }
        }

        public MyArray(char[,] arr)
        {
            _array = arr;
        }


    }
}