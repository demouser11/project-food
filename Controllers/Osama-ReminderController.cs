namespace ProjectFood.Controllers
{
    public class ReminderController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public void AddFood(string name, int numTimes = 1)
        {
            // Something that can add a food
        }

    }
}