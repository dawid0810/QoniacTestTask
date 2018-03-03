using System;
using System.Net;
using System.ServiceModel.Web;
using BusinessCommon;

namespace BusinessServices
{
    public class QoniacTestTaskService : IQoniacTestTaskService
    {
        private readonly IPriceParser _parser;

        public QoniacTestTaskService(IPriceParser parser)
        {
            _parser = parser;
        }

        public string ParsePrice(string price)
        {
            try
            {
                return _parser.ConvertPriceToWords(price);
            }
            catch (Exception e)
            {
                throw new WebFaultException<string>(e.Message, HttpStatusCode.InternalServerError);
            }
        }
    }
}