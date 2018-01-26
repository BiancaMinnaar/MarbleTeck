using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using NDC.Implementation.ViewModel;
using NDC.Interface.Service;

namespace NDC.Implementation.Service
{
    public class WidgetService : BaseService, IWidgetService
    {
        public WidgetService(Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task Widget(WidgetViewModel model)
        {
            string requestURL = "/path/{Parameter}";
            var httpMethod = BaseNetworkAccessEnum.Put;
            var parameters = new Dictionary<string, object>()
            {
                //{"Parameter", model.Property},
            };
            await _NetworkInterface(requestURL, parameters, httpMethod);
        }
    }
}
