using System;
using System.Threading.Tasks;
using NDC.Interface.Service;
using NDC.Interface.Repository;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.Repository
{
    public class WidgetRepository : ProjectBaseRepository, IWidgetRepository
    {
        IWidgetService _Service;

        public WidgetRepository(IMasterRepository masterRepository, IWidgetService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task Widget(WidgetViewModel model, Action completeAction)
        {
            await _Service.Widget(model);
            completeAction();
        }
    }
}