using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_Test_TDD
{
    public class ProductFactory
    {
        private readonly INotifyProductCreation _notifyProductCreation;

        public ProductFactory(INotifyProductCreation notifyProductCreation)
        {
            _notifyProductCreation = notifyProductCreation;
        }

        public Product CreateNewProduct(long price, IList<long> categoryIds, Action<IProductOptions> optionalParams)
        {
            return CreateProduct(price, 0L, categoryIds, optionalParams);
        }

        public Product CreateExportedProduct(long price, long ranking, IList<long> categoryIds, Action<IProductOptions> optionalParams)
        {
            return CreateProduct(price, ranking, categoryIds, optionalParams);
        }

        private Product CreateProduct(long price, long ranking, IList<long> categoryIds, Action<IProductOptions> optionalParams)
        {
            var options = new ProductOptions();
            optionalParams?.Invoke(options);

            var description = options.Description;
            if (string.IsNullOrWhiteSpace(description))
                description = "No description available";

            var name = options.Name;
            if (string.IsNullOrWhiteSpace(name))
                name = "No name";
            var product = new Product(name, description, price, ranking, categoryIds);
            
            return product;
        }
    }
    public interface INotifyProductCreation
    {
    }
    public interface IProductOptions
    {
    }
    public class ProductOptions : IProductOptions
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
