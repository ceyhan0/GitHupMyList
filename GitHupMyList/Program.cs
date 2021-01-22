using System;

namespace GitHupMyList
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class MyList<T>
        {

            T[] _array;
            T[] _tempAray;

            public MyList()
            {
                _array = new T[0];
            }

            public void Add(T item)
            {
                _tempAray = _array;
                _array = new T[_array.Length+1];
                for (int i = 0; i < _tempAray.Length; i++)
                {
                    _array[i] = _tempAray[i];
                }

                _array[_array.Length - 1] = item;


            }

        }
    }
}
