using System.Collections.Generic;
using MarbleTecMobile.Base;

namespace MarbleTecMobile.Implementation.ViewModel
{
    public class HomeViewModel : ProjectBaseViewModel
    {
        public List<SmallTableMenuItemViewModel> MenuItems { get; set; }
    }
}