using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //temprory=geçici, temArray(geçicidizi) oluştur. Çünkü newlendiğinde yeni ref no alır. Diğer elemanların uçmaması için onları tutturmak gerekir.
            items = new T[items.Length+1]; //eleman sayısını 1 artırır.
            //verdiğimiz elemnaları geri almak istersek(tempArrayın elemanlrını itemse geri atayacaağız.)

            for (int i = 0; i < tempArray.length; i++)
            {
                items[i] = tempArray[i]; //itemsın i.elemanı tepArrayin i. elamanı. Sırasıyla bütün elemanları yerine alıyoruz.
            }

            items[items.Length - 1] = item; //itemsın son elemanını eklemek için yazıldı. 
        }
    }
}
