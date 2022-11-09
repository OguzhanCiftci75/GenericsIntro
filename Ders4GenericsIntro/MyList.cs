using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ders4GenericsIntro
{
    class MyList<T>
    {
        T[] items;        // Metod dışında yazılan bir değişken ama yine metod içinden erişilebilir 

        //Constructor yapıcı metod
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // aşşağıdaki referans numarasını başkasına tuttururuz
            items = new T[items.Length + 1]; // elemanları +1 şekilde arttırırız
           
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // artık ekleme işlemi yapılabilir 

        }
    }
}
