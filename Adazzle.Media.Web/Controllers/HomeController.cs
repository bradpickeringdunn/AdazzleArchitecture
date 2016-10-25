using Adazzle.Services.Campaign.Api.Contracts;
using OutTheBox.Logging;
using System.Web.Mvc;

namespace Adazzle.Media.Web.Controllers
{
    public class HomeController : Controller
    {
        ICampaignService campaignService;
        ILogger logger;

        public HomeController(ILogger logger, ICampaignService campaignService)
        {
            this.logger = logger;
            this.campaignService = campaignService;
        }

        public ActionResult Index()
        {
            return new Common.Actions.LoadCampaignAction<ActionResult>(campaignService)
            {
                OnComplete = (m) => View(m) 
            }.Execute(new Common.Models.ExampleModel()
            {
                Age = 2,
                Name = ""
            });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}