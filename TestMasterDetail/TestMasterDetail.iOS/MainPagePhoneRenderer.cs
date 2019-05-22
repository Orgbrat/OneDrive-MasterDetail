using TestMasterDetail.iOS;
using TestMasterDetail.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPagePhoneRenderer), UIKit.UIUserInterfaceIdiom.Phone)]
namespace TestMasterDetail.iOS
{
    class MainPagePhoneRenderer : PhoneMasterDetailRenderer
    {
        MainPage page;
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            page = e.NewElement as MainPage;
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}
