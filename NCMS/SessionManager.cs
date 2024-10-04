using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCMS
{
    public class SessionManager
    {
        private static SessionManager _instance;

        public static string Username { get; set; }

        public static string fullname { get; set; }
        public static DateTime LoginTime { get; set; }
        public List<string> UserActions { get; private set; }

        private SessionManager()
        {
            UserActions = new List<string>();
        }

        public static SessionManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SessionManager();
                return _instance;
            }
        }

        public void AddAction(string action)
        {
            UserActions.Add($"{DateTime.Now}: {action}");
        }
        public static void Login(string username)
        {
            fullname = fullname;
            Username = username;
            LoginTime = DateTime.Now;
        }
    }

}
