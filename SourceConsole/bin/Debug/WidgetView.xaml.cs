using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using NDC.Implementation.ViewController;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.View
{
    public partial class WidgetView : ProjectBaseContentPage<WidgetViewController, WidgetViewModel>
    {
        public WidgetView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async Task On_Widget_Event(object sender, EventArgs e)
        {
            await _ViewController.Widget();
        }
    }
}


