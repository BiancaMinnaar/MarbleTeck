using System;
using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Repository
{
    public interface ILoginRepository
    {
        Task Login(LoginViewModel model, Action completeAction);
    }
}
