using WorldSkills.Pages.MVC.View;

namespace WorldSkills.Pages.MVC.Controller
{
    public class ControllerLogin
    {
        public string CheckLoginInOdb(string checkLogin)
        {
            ViewLogin viewLogin = new ViewLogin();
            return viewLogin.GetLogin(checkLogin);
        }
    }
}