using System;
using System.Windows.Input;
using MarbleTecMobile.Base;

namespace MarbleTecMobile.Implementation.ViewModel
{
    public class SmallTableMenuItemViewModel : ProjectBaseViewModel
    {
        public int ListIndex { get; set; }
        public string ItemDescription { get; set; }
        public ICommand MenuClickedCommand { get; set; }
    }
}