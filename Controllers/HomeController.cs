using Microsoft.AspNetCore.Mvc;
namespace PortfolioII    
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
         
            return View("Index");
        }

        [HttpGet]       //type of request
        [Route("project")]     //associated route string (exclude the leading /)
        public ViewResult Projects()
        {

            return View("Projects");
        }


        [HttpGet]       //type of request
        [Route("contact")]     //associated route string (exclude the leading /)
        public ViewResult Contact()
        {

            return View("Contact");
        }
    }
}