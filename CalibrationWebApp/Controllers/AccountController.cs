using System.Web.Mvc;
using System.Web.Security;
using CalibrationWebApp.Models.ViewModel;
using CalibrationWebApp.Models.EntityManager;

namespace CalibrationWebApp.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// method for returning a view
        /// </summary>
        /// <returns>returns razor signup page</returns>
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserSignUpView user)
        {
            if (ModelState.IsValid)
            {
                UserManager mgr = new UserManager();
                if (!mgr.IsLoginExist(user.LoginName))
                {
                    mgr.AddUserAccount(user);
                    FormsAuthentication.SetAuthCookie(user.FirstName, true);
                    return RedirectToAction("Welcome" + " " + user.FirstName, "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login name already taken. Please choose another.");
                }                                   
            }

            return View();
        }
    }
}