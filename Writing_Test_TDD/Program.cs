using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_Test_TDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
        public static int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }
        public static float Avg(int a, int b, int c)
        {
            float avg = ((float)a + b + c) / 3;
            return avg;
        }
    }

    public class ProductBusiness
    {
        private readonly IProductDataAccess _productDataAccess;

        public ProductBusiness(IProductDataAccess productDataAccess)
        {
            _productDataAccess = productDataAccess;
        }

        public bool CreateProduct(Product newProduct)
        {
            bool result = _productDataAccess.CreateProduct(newProduct);
            return result;
        }
    }

}
