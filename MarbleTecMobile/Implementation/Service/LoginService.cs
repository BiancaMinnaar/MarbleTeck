using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Interface.Service;

namespace MarbleTecMobile.Implementation.Service
{
    public class LoginService : BaseService, ILoginService
    {
        public LoginService(Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task Login(LoginViewModel model)
        {
            string requestURL = "/login";
            var httpMethod = BaseNetworkAccessEnum.Get;
            var parameters = new Dictionary<string, object>()
            {
                {"username", model.UserName},
                {"password", model.Password}
            };
            await _NetworkInterface(requestURL, parameters, httpMethod);
        }
    }
}
