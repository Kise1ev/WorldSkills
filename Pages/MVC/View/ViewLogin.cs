using WorldSkills.Pages.MVC.HelpController;

namespace WorldSkills.Pages.MVC.View
{
    public class ViewLogin
    {
        public string GetLogin(string checkLogin) 
            => DatabaseRegistration.GetSetLoginOdb(checkLogin);
    }
}