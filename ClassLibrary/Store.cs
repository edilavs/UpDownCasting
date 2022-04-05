using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        public Product[] Products=new Product [0];
        public int NotebookLimit;
        public int PhoneLimit;
        public void AddProduct(Product product)
        {
            int count = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (product is Notebook)
                {
                    Notebook notebook = product as Notebook;
                    count++;
                    do
                    {
                        Array.Resize(ref Products, Products.Length + 1);
                        Products[Products.Length - 1] = product;
                    } while (NotebookLimit > count);
                }
                else if (product is Phone)
                {
                    Phone phone = product as Phone;
                    count++;
                    do
                    {
                        Array.Resize(ref Products, Products.Length + 1);
                        Products[Products.Length - 1] = product;
                    } while (PhoneLimit > count);
                }
                else
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = product;
                }
            }
        }
        public Product FindByNo(int no)
        {
            Product product = new Product();
            for (int i = 0; i< Products.Length; i++)
            {
                if (Products[i].No == no)
                    return Products[i];
            }
            return product;
        }
        public double  CalcNotebookAvg()
        {
            int count = 0;
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Notebook)
                {
                    Product newNotebook = Products[i] as Product;
                    count++;
                    sum += newNotebook.Price;
                }
                avg = sum / count;
            }
            return avg;
        }

        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Phone)
                {
                    Product newPhone = Products[i] as Product;
                    count++;
                    sum += newPhone.Price;
                }
                avg = sum / count;
            }
            return avg;
        }
    }
}
