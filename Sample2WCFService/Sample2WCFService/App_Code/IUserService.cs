using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Sample2WCFService
{
    [ServiceContract]
    interface IUserService
    {
        [OperationContract]
        string WelcomeUser(string fname, string lname);

        [OperationContract]
        UserData GetUserdetails(int id);
    }

    [DataContract]
    public class UserData
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string UserType { get; set; }
    }
}
