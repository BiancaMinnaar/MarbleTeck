using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Interface.Service;

namespace MarbleTecMobile.Implementation.Service
{
    public class ClockService : BaseService, IClockService
    {
        public ClockService(Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task Clock(ClockViewModel model)
        {
            string requestURL = "/path/{Parameter}";
            var httpMethod = BaseNetworkAccessEnum.Get;
            var parameters = new Dictionary<string, object>()
            {
                //{"Parameter", model.Property},
            };
            await _NetworkInterface(requestURL, parameters, httpMethod);
        }
    }
}
