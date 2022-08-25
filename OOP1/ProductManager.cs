using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //metodun nasıl çağırılacağını gösterir. Product türünde birşey göndereceksin ben onu product ismiyle tutuyor olacağım.
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        
    }
}
