using System;
using System.Threading.Tasks;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Implementation.Repository
{
    public class LoginRepository : ProjectBaseRepository, ILoginRepository
    {
        ILoginService _Service;

        public LoginRepository(IMasterRepository masterRepository, ILoginService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task Login(LoginViewModel model, Action completeAction)
        {
            await _Service.Login(model);
            completeAction();
        }
    }
}