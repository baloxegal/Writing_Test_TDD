using System.Collections.Generic;

namespace Writing_Test_TDD
{
    public class ProductBusinessFactory
    {
        private readonly ITypeProduct _productType;

        public ProductBusinessFactory(ITypeProduct productType)
        {
            _productType = productType;
        }

        public bool CreateProduct(Product newProduct)
        {            
            return _productType.CreateProduct(newProduct);
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

    public interface ITypeProduct
    {
        bool CreateProduct(Product product);
    }


}