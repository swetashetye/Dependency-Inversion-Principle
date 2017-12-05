using System.Collections.Generic;

namespace ASPPattern.Chap2.Service
{
    public interface IProductRespository
    {
        IList<Product> GetAllProduct(int intCatId);
    }
}
