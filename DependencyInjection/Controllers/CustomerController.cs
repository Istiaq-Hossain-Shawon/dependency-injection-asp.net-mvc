using Services;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _iCustomerService;

        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }
        
        public ActionResult GetCustomers()
        {
            return Json(_iCustomerService.GetCustomers(), JsonRequestBehavior.AllowGet);
        }
    }
}