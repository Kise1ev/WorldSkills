using System.Linq;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.MVC.HelpController
{
    public static class DatabaseRegistration
    {
        public static string GetSetLoginOdb(string getSetLogin)
        {
            User user = AppConnect.ModelOdb.User.FirstOrDefault(x => x.Login == ClientInfo.LoginClient);
            while (true)
            {
                return user != null && user.Login == getSetLogin
                    ? "Пользователь есть!"
                    : "Такого пользователя нет!";
            }
        }
    }
}