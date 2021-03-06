using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Interface.Service;

namespace MarbleTecMobile.Implementation.Service
{
    public class SmallTableMenuService : BaseService, ISmallTableMenuService
    {
        public SmallTableMenuService(Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task SmallTableMenu(SmallTableMenuViewModel model)
        {
            string requestURL = "/menu";
            var httpMethod = BaseNetworkAccessEnum.Get;
            var parameters = new Dictionary<string, object>()
            {
                {"type", model.MenuType},
            };
            await _NetworkInterface(requestURL, parameters, httpMethod);
        }
    }
}
