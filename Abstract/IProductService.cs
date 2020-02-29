using MvcCoreCastleWindsor.Models;
using System.Collections.Generic;

namespace MvcCoreCastleWindsor.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }

}
