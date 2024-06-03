using Microsoft.AspNetCore.Mvc;

namespace WebAppLB1.Components
{
    public class CartViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
