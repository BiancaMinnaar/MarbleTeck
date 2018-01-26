using System;
using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Repository
{
    public interface IWidgetRepository
    {
        Task Widget(WidgetViewModel model, Action completeAction);
    }
}
