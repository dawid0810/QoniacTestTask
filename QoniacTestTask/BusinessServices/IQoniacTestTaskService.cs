using System.ServiceModel;

namespace BusinessServices
{
    [ServiceContract]
    public interface IQoniacTestTaskService
    {
        [OperationContract]
        string ParsePrice(string price);
    }
}
