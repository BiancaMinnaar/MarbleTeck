using System.Threading.Tasks;
using NDC.Base;
using NDC.Implementation.Repository;
using NDC.Implementation.Service;
using NDC.Implementation.ViewModel;
using NDC.Interface.Repository;
using NDC.Interface.Service;
using NDC.Interface.ViewController;

namespace NDC.Implementation.ViewController
{
    public class WidgetViewController : ProjectBaseViewController<WidgetViewModel>, IWidgetViewController
    {
        IWidgetRepository _Reposetory;
        IWidgetService _Service;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
            _Service = new WidgetService(_MasterRepo.NetworkInterface);
            _Reposetory = new WidgetRepository(_MasterRepo, _Service);
        }

        public async Task Widget()
        {
            
        }
    }
}