using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Interface.Service;

namespace MarbleTecMobile.Implementation.Service
{
    public class SmallTableMenuItemService : BaseService, ISmallTableMenuItemService
    {
        public SmallTableMenuItemService(Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task SmallTableMenuItem(SmallTableMenuItemViewModel model)
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
