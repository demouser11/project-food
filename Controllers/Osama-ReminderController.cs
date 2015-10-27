namespace ProjectFood.Controllers
{
    public class ReminderController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public void DeleteFood(string name, int numTimes = 1)
        {
            // Something that can delete a food
        }

    }
}