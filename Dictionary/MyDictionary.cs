using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,K>
    {
        T[] numbers;
        K[] names;
        public MyDictionary()
        {
            numbers =new T[0];
            names = new K[0];
        }
        public void Add(T number,K name)
        {
            T[] tempArray = numbers;
            numbers = new T[numbers.Length + 1];

            K[] tempArray2 = names;
            names = new K[names.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                numbers[i] = tempArray[i];
            }
            numbers[numbers.Length - 1] = number;



            for (int i = 0; i < tempArray2.Length; i++)
            {
                names[i] = tempArray2[i];
            }
            names[names.Length - 1] = name;
        }
        public int count
        {
            get { return numbers.Length; }

        }
    }
    
}
