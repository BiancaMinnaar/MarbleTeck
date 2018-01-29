using System;
using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Repository
{
    public interface ISmallTableMenuRepository
    {
        Task SmallTableMenu(SmallTableMenuViewModel model, Action completeAction);
    }
}
