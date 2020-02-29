using Microsoft.AspNetCore.Mvc;
using MvcCoreCastleWindsor.Abstract;
using MvcCoreCastleWindsor.CastleWindsor;
using MvcCoreCastleWindsor.Models;

namespace MvcCoreCastleWindsor.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            //Samples 1
            var data1 = _productService.GetAll();

            //Samples 2
            var container = ContainerInstall.Install();
            var productService2 = container.Resolve<IProductService>();
            var data2 = productService2.GetAll();
            var data3 = productService2.GetAll();
            var data4 = productService2.GetAll();
            var data5 = productService2.GetAll();
            var data6 = productService2.GetAll();

            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.ProductList1 = data1;
            productViewModel.ProductList2 = data2;

            return View(productViewModel);
        }

    }
}
