using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Service
{
    public interface ISmallTableMenuService
    {
        Task SmallTableMenu(SmallTableMenuViewModel model);
    }
}

