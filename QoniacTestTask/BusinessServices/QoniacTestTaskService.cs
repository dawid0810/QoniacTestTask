using System;
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
                return e.Message;
            }
        }
    }
}