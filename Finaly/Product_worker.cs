using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finaly
{
    class Product_worker
    {
        GAS_context context = new GAS_context();

        public void add_new_product(string name, int price)
        {

            Products product = new Products();

            product.name = name;
            product.price = price;
            context.Products.Add(product);
            context.SaveChanges();

        }

        public void edit_product(string name, int price,int id)
        {

            Products product = context.Products.SingleOrDefault(c=>c.productID == id);

            product.name = name;
            product.price = price;
            context.Products.Add(product);
            context.SaveChanges();

        }

        public void delete_product(int id)
        {

            Products product = context.Products.SingleOrDefault(c => c.productID == id);

            context.Products.Remove(product);
            context.SaveChanges();

        }
    }
}
