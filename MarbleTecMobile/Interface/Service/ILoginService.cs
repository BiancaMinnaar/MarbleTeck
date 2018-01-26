using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Service
{
    public interface ILoginService
    {
        Task Login(LoginViewModel model);
    }
}

