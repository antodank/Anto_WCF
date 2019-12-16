using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2WCFService
{
    class User : IUserService
    {
        public UserData GetUserdetails(int id)
        {
            List<UserData> objList = new List<UserData>();
            objList.Add(new UserData() { FirstName = "Ankit", LastName = "T" , UserID = 1 });
            objList.Add(new UserData() { FirstName = "Viraj", LastName = "T", UserID = 2 });
            objList.Add(new UserData() { FirstName = "amit", LastName = "T", UserID = 3 });

            UserData userres = objList.SingleOrDefault(a => a.UserID == id);

            return userres; 

        }

        public string WelcomeUser(string fname, string lname)
        {
            return string.Format("Welcome {0} {1}", fname, lname);
        }
    }
}
