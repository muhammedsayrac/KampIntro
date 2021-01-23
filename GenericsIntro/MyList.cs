using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        string[] items;

        // constructer
        public MyList()
        {
            items = new T[0];
        }


        public void Add(T items)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = items;

        }
        

       
    }
}
