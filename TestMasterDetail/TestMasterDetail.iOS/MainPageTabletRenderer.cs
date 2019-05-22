using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TestMasterDetail.iOS;
using TestMasterDetail.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageTabletRenderer), UIKit.UIUserInterfaceIdiom.Pad)]
namespace TestMasterDetail.iOS
{
    class MainPageTabletRenderer : TabletMasterDetailRenderer
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