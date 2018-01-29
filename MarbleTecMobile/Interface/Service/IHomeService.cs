using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Service
{
    public interface IHomeService
    {
        Task Home(HomeViewModel model);
    }
}

