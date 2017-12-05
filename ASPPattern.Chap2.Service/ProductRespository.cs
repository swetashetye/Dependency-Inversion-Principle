using System.Collections.Generic;

namespace ASPPattern.Chap2.Service
{
    public class ProductRespository : IProductRespository
    {
        public IList<Product> GetAllProduct(int intCatId)
        {
            IList<Product> product = new List<Product>();

            //Database operation

            return product;

        }
    }
}
