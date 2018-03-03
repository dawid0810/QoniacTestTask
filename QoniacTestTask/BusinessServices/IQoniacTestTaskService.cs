using System.ServiceModel;

namespace BusinessServices
{
    [ServiceContract]
    public interface IQoniacTestTaskService
    {
        [OperationContract]
        [FaultContract(typeof(string))]
        string ParsePrice(string price);
    }
}
