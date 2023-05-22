using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace BoxingProto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : Xamarin.Forms.TabbedPage
    {

        public FirstPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(value: ToolbarPlacement.Bottom);

            quickstartpage.IconImageSource = ImageSource.FromResource("BoxingProto.Images.boxingGloveTabTest.png");
            workoutpage.IconImageSource = ImageSource.FromResource("BoxingProto.Images.ic_action_list.png");

        }
    }
}