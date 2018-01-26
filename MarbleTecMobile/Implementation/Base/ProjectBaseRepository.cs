using MarbleTecMobile.Interface.Repository;
using PCLBase.DataContracts;

namespace MarbleTecMobile.Implementation.Repository
{
    public class ProjectBaseRepository : BaseRepository
    {
        protected IMasterRepository _MasterRepo;

        public ProjectBaseRepository(IMasterRepository masterRepository)
        {
            _MasterRepo = masterRepository;
        }
    }
}
