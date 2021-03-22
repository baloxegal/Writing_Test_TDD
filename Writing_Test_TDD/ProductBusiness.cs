using System.Collections.Generic;

namespace Writing_Test_TDD
{
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
    public class Product
    {
        public string name;
        public string description;
        public long price;
        public long ranking;
        public IList<long> categoryIds;

        public Product()
        {                
        }

        public Product(string name, string description, long price, long ranking, IList<long> categoryIds)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.ranking = ranking;
            this.categoryIds = categoryIds;
        }
    }

    public interface IProductDataAccess
    {
        bool CreateProduct(Product product);
    }
}