using System;
using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Repository
{
    public interface ISmallTableMenuItemRepository
    {
        Task SmallTableMenuItem(SmallTableMenuItemViewModel model, Action completeAction);
    }
}
