using System.Collections.Generic;


namespace ASPPattern.Chap2.Service
{
    public class ProductService
    {
        private IProductRespository _productRespository;
        private ICacheStorage _cacheStorage;
        public ProductService(IProductRespository productRespository, ICacheStorage cacheStorage)
        {
            _productRespository = productRespository;
            _cacheStorage = cacheStorage;
        }

        public IList<Product> GetAllProductIn(int intCatId)
        {
            IList<Product> products;
            string storageKey = string.Format("product_in_category_id_{0}", intCatId);

            products = _cacheStorage.Retrieve<IList<Product>>(storageKey);

            if (products == null)
            {
                products = _productRespository.GetAllProduct(intCatId);
                _cacheStorage.Store(storageKey, products);
            }

            return products;
        }
    }
}



