using System;
using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Repository
{
    public interface IHomeRepository
    {
        Task Home(HomeViewModel model, Action completeAction);
    }
}
