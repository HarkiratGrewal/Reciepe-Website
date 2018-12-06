using Asssignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
//using Asssignment1.Models;

namespace Asssignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("Home");
        }   //  Index method
        public IActionResult LoginPage()
        {
            return View();
        }   //  LoginPage method

        public IActionResult Home()
        {
            return View();
        }   //  Home method

        public IActionResult DataPage()
        {
            return View(ReciepeList.Reciepes);
        }   //  DataPage method

        public IActionResult DisplayPage()
        {
            //Some initialized objects

            #region SaagPaneer

            #region Ingredients
            string saagPaneerIngredietsArray1 =
                "1 teaspoon turmeric\n" +
                "1/2 teaspoon cayenne\n" +
                "Kosher salt\n" +
                "3 tablespoons plus 1 1/2 tablespoons vegetable oil\n" +
                "12 ounces paneer, (Indian cheese, either store-bought or made from my recipe, recipe follows), cut into 1-inch cubes, see Cook's Note*\n" +
                "1 (16-ounce package) frozen chopped spinach\n" +
                "1 medium white onion, finely chopped\n" +
                "1 (1-inch thumb) ginger, peeled and minced (about 1 tablespoon)\n" +
                "4 cloves garlic, minced\n" +
                "1 large green serrano chile, finely chopped (seeds removed if you don't like it spicy!)\n" +
                "1/2 teaspoon store-bought or homemade garam masala, recipe follows\n" +
                "2 teaspoons ground coriander\n" +
                "1 teaspoon ground cumin\n" +
                "1/2 cup plain yogurt, stirred until smooth\n" +
                "3 large cinnamon sticks (if you have the kind you get at Indian stores, it's about 3 tablespoons of cinnamon bark bits)\n" +
                "3 tablespoons whole cloves\n" +
                "1/4 cup green cardamom pods, shelled, husks discarded (about 2 tablespoons of seeds)\n" +
                "4 large black cardamom pods, shelled, husks discarded (about 1 tablespoon of seeds), optional";
            #endregion

            #region Procedure
            string saagPaneerProcedureArray1 =
                "In a large bowl, whisk together the turmeric, cayenne, 1 teaspoon salt and 3 tablespoons oil. Gently, drop in the cubes of paneer and gently toss, taking care not to break the cubes if you're using the homemade kind. Let the cubes marinate while you get the rest of your ingredients together and prepped.\n" +
                "Thaw the spinach in the microwave in a microwave-safe dish, 5 minutes on high, then puree in a food processor until smooth. Alternatively, you can chop it up very finely with your knife\n" +
                "Place a large nonstick skillet over medium heat, and add the paneer as the pan warms. In a couple of minutes give the pan a toss; each piece of paneer should be browned on one side. Fry another minute or so, and then remove the paneer from the pan onto a plate.\n" +
                "Add the remaining 1 1/2 tablespoons oil to the pan. Add the onions, ginger, garlic and chile. Now here's the important part: saute the mixture until it's evenly toffee-coloured, which should take about 15 minutes. Don't skip this step - this is the foundation of the dish! If you feel like the mixture is drying out and burning, add a couple of tablespoons of water.\n" +
                "Add the garam masala, coriander and cumin. If you haven't already, sprinkle a little water to keep the spices from burning. Cook, stirring often, until the raw scent of the spices cook out, and it all smells a bit more melodious, 3 to 5 minutes.\n" +
                "Add the spinach and stir well, incorporating the spiced onion mixture into the spinach. Add a little salt and 1/2 cup of water, stir, and cook about 5 minutes with the lid off.\n" +
                "Turn the heat off. Add the yogurt, a little at a time to keep it from curdling. Once the yogurt is well mixed into the spinach, add the paneer. Turn the heat back on, cover and cook until everything is warmed through, about 5 minutes. Serve.\n" +
                "Combine the cinnamon sticks, cloves, green cardamom seeds, black cardamom seeds, if using into a spice grinder or coffee grinder and grind until fine. Store the spice mix in an airtight container away from direct sunlight.\n";
            #endregion

            //ViewData["saagPaneer"] = new ReciepeModel()
            //{
            //    reciepeName = "Saag Paneer",
            //    reciepeIngredients = saagPaneerIngredietsArray1,
            //    reciepeProcedure = saagPaneerProcedureArray1
            //};
            #endregion

            #region Dosa

            #region Ingredients
            string dosaIngredients =
                "3 cups rice\n" +
                "1 cup urad daal (split, skinless black gram)\n" +
                "3/4 teaspoon fenugreek seeds\n" +
                "Salt (to taste)\n" +
                "Vegetable / canola / sunflower cooking oil";
            #endregion

            #region Procedure
            string dosaProcedure =
                "Gather the ingredients.\n" +
                "Wash the rice and urad daal well. Add the fenugreek seeds to the mix and fill enough water in the rice-daal bowl to cover them about 2-inch deep. Soak overnight.\n" +
                "The next morning, drain all the water from the rice and urad daal. Now put some in a food processor and grind - adding very little water if necessary - to a smooth yet slightly grainy paste.\n" +
                "When all the rice-daal mix is ground like this, put it into a large mixing bowl and add enough water to make a batter. The consistency of the batter should be such that it thickly coats a spoon dipped in it.\n" +
                "Now add salt to taste and keep the Dosa batter aside in a warm, dark spot, covered, for 6 to 8 hours. After this fermentation, stir the batter well. It is now ready to make Dosas.\n" +
                "Put some cooking oil in a small bowl and keep ready. You will also need a bowl of ice cold water, a large, flat nonstick pan, 2 sheets of paper towel, a ladle, a spatula and a basting brush.\n" +
                "Fold one sheet of paper towel into a wad and dip lightly into the bowl of cooking oil. Squeeze out any excess and then rub the paper towel all over the surface of the pan to grease. The correct amount of oil is such that it is barely visible in the pan. Now turn on the heat/ flame at medium high.\n" +
                "Fill the ladle up to the 3/4 level with Dosa batter. Gently pour this batter onto the center of the pan - just as you would for a pancake - till the ladle is empty.\n" +
                "Now begin to spread the batter in sweeping circular motions to form a pancake of roughly 8-inch diameter. Do not be alarmed if the Dosa develops tiny holes as you spread the batter. This is normal.\n" +
                "As soon as you have finished spreading the batter out on the pan, dip the basting brush in cooking oil and drizzle the oil all over the surface of the dosa and also around its edges. Now hold the pan by its handle, lift up and swirl it so as to make the drizzled oil spread all over the Dosa.​\n" +
                "When the upper surface begins to look cooked (it will no longer look soft or runny), flip the Dosa. By this time, ideally, the surface that was underneath should be light golden in color. Cook for 1 minute after flipping.\n" +
                "The Dosa is almost done. Fold it in half and allow to cook for 30 seconds more.\n" +
                "Before you start making the next Dosa, fold another sheet of paper towel into a wad and dip it in ice cold water. Squeeze the wad to remove excess water and then rub it all over the surface of the pan to cool it slightly. This ensures your next Dosa will spread evenly and not break because the pan is too hot. Now proceed as you did for the last Dosa.\n" +
                "We like to make and serve Dosas immediately while we cook as this means they are crisp and fresh when eaten. This, however, is not absolutely necessary. You can also make, stack and serve the Dosas later. Just ensure you keep them warm until serving time by placing them - just like with pancakes - in a closed dish.\n" +
                "Serve the ready Dosa with side dishes like South Indian coconut chutney, South Indian gunpowder chutney, and sambar.";
            #endregion

            //ViewData["Dosa"] = new ReciepeModel()
            //{
            //    reciepeName = "Dosa",
            //    reciepeIngredients = dosaIngredients,
            //    reciepeProcedure = dosaProcedure
            //};
            #endregion

            ReciepeModel reciepe1 = new ReciepeModel
            {
                reciepeName = "Saag Paneer",
                reciepeIngredients = saagPaneerIngredietsArray1,
                reciepeProcedure = saagPaneerProcedureArray1
            };

            ReciepeModel reciepe2 = new ReciepeModel
            {
                reciepeName = "Dosa",
                reciepeIngredients = dosaIngredients,
                reciepeProcedure = dosaProcedure
            };

            //ReciepeList.AddReciepe(reciepe1);
            //ReciepeList.AddReciepe(reciepe2);

            return View(ReciepeList.Reciepes);
        }   //  DisplayPage method

        public IActionResult InsertPage()
        {
            return View();
        }   //  InsertPage method

        [HttpGet]
        public ViewResult _ReciepeResult()
        {
            return View("InsertPage");
        }

        [HttpPost]
        public ViewResult _ReciepeResult(ReciepeModel reciepe)
        {
            //No validation for now.
            if (ModelState.IsValid)
            {
                ReciepeList.AddReciepe(reciepe);
                return View("InsertPage", reciepe);
            }
            else
            {
                return View("InsertPage");
            }
        }

        public IActionResult UserPage()
        {
            //Custom name. Name would be read from the login page itself.
            string userName = "Harkirat";
            ViewBag.userName = userName;
            return View();
        }   //  userPage method

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }   //  Error method

    }   //  HomeController
}   //  namespace
