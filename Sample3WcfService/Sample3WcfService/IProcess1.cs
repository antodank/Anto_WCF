using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel;    

namespace Sample3WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IProcessCallback))]
    public interface IProcess1
    {

        [OperationContract]
        void TaskProcess();

       

        // TODO: Add your service operations here
    }

    [ServiceContract]
    public interface IProcessCallback
    {

        [OperationContract]
        void TaskProcessStatus(int percentCode);



        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
