using System.Web.Mvc;

namespace Controllers
{

	[HandleError]
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{	
			return View ();
		}
		
		[AcceptVerbs("POST")]
		public ActionResult Index (string zip)
		{			
			WeatherChecker.wsf.cdyne.com.Weather weather = new WeatherChecker.wsf.cdyne.com.Weather();
			var data = weather.GetCityWeatherByZIP(zip);
			
			ViewData["City"] = data.City;
			ViewData["State"] = data.State;
			ViewData["Temperature"] = data.Temperature;
			
			return View ("Result");
		}
	}
}