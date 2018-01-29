using System.Threading.Tasks;
using MarbleTecMobile.Base;
using MarbleTecMobile.Implementation.Repository;
using MarbleTecMobile.Implementation.Service;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.ViewController;

namespace MarbleTecMobile.Implementation.ViewController
{
    public class ClockViewController : ProjectBaseViewController<ClockViewModel>, IClockViewController
    {
        IClockRepository _Reposetory;
        IClockService _Service;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
            _Service = new ClockService(_MasterRepo.NetworkInterface);
            _Reposetory = new ClockRepository(_MasterRepo, _Service);
        }

        public async Task Clock()
        {
            
        }
    }
}