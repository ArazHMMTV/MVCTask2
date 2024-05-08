using FrontToBackTask2.DAL;
using FrontToBackTask2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }
        public IActionResult Index()
        {
            //OrganicProduct organicProduct = new OrganicProduct
            //{

            //    Image = "~/product-1.png",
            //    Desc = "Perfect Foods",
            //    Price = "25$",
            //    Basket = "http://localhost:15701/",
            //    Eye = "http://localhost:15701/About"

            //};
            //OrganicProduct organicProduct1 = new OrganicProduct
            //{
            //    Image = "~/images/product-2.png",
            //    Desc = "Organic Foods",
            //    Price = "20$",
            //    Basket = "http://localhost:15701/",
            //    Eye = "http://localhost:15701/About"

            //};
            //OrganicProduct organicProduct2 = new OrganicProduct
            //{

            //    Image = "~/images/vegetable.png",
            //    Desc = "Organic Fruit",
            //    Price = "35$",
            //    Basket = "http://localhost:15701/",
            //    Eye = "http://localhost:15701/About"

            //};
            //OrganicProduct organicProduct3 = new OrganicProduct
            //{

            //    Image = "~/img/feature.png",
            //    Desc = " beautiful vegetables",
            //    Price = "18$",
            //    Basket = "http://localhost:15701/",
            //    Eye = "http://localhost:15701/About"

            //};
            //OrganicProduct organicProduct4 = new OrganicProduct
            //{

            //    Image = "~/images/bg-product-2.png",
            //    Desc = "Amazing Foods",
            //    Price = "40$",
            //    Basket = "http://localhost:15701/",
            //    Eye = "http://localhost:15701/About"

            //};

            //List<OrganicProduct> products = new List<OrganicProduct> { organicProduct, organicProduct1, organicProduct2, organicProduct3, organicProduct4 };
            //_appDbContext._organicProducts.AddRange(products);
            //_appDbContext.SaveChanges();

            List<OrganicProduct> products = _appDbContext.OrganicProducts.ToList();
            return View(products);
        }
    }
}
