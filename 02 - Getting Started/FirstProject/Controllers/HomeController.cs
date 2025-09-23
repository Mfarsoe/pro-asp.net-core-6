using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers {

    public class HomeController {

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);
        }
    }
}
