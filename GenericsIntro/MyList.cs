using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;  // classı newlediğimde oluşturmalıyım!!! 0 elemanlı bile olsaaa!!!
        //constructor  ctor yaz tab taba bas...
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {       //geçicidizi
            T[] tempArray = items;  // yeni referansım uçmasın diye bunu oluşturduk!!!
            items = new T[items.Length+1];  // dizi mevcut sayı kadar uzasın artsın anlamında!!!
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  // emanet verdiğim değerleri üstüme ver komutu agaaa!!!
            }

            items[items.Length - 1] = item;// itemin sonuncu elemanı -1 le yazılır laaan!!!



        }
    }
}
