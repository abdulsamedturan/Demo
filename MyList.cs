using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class MyList<T>
    {
        T[] items;
        T[] tempItems;
        T[] deleteTempItems;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            tempItems = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }
            items[items.Length - 1] = item;
        }
        public void Delete()
        {
            if (items.Length > 0)
            {

                deleteTempItems = items;
                items = new T[items.Length - 1];
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = deleteTempItems[i];
                }
            }
            

        }
        public T[] Items
        {
            get { return items; }
        }



    }
}
