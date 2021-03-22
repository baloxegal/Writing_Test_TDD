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
            return CreateProduct(price, 0, categoryIds, optionalParams);
        }

        public Product CreateExportedProduct(long price, long ranking, IList<long> categoryIds, Action<IProductOptions> optionalParams)
        {
            return CreateProduct(price, ranking, categoryIds, optionalParams);
        }

        private Product CreateProduct(long price, long ranking, IList<long> categoryIds, Action<IProductOptions> optionalParams)
        {
            var options = new ProductOptions();
            if (optionalParams != null)
                optionalParams(options);
            var description = options.GetDescriptions();
            if (string.IsNullOrWhiteSpace(description))
                description = "No description available";
            var name = options.GetName();
            if (string.IsNullOrWhiteSpace(name))
                description = "No name";
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
        public string GetName()
        {
            string a = "asgfsdfs";
            return a;
        }
        public string GetDescriptions()
        {
            string a = "asgfsdfs";
            return a;
        }
    }
}
