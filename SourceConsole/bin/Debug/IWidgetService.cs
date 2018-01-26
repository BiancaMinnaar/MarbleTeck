using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Service
{
    public interface IWidgetService
    {
        Task Widget(WidgetViewModel model);
    }
}

