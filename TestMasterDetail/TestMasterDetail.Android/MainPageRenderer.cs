
using Android.App;
using Android.Content;
using TestMasterDetail.Droid;
using TestMasterDetail.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]
namespace TestMasterDetail.Droid
{
    class MainPageRenderer : MasterDetailPageRenderer
    {
        public MainPageRenderer(Context context) : base(context)
        {

        }
        MainPage page;


        protected override void OnElementChanged(VisualElement oldElement, VisualElement newElement)
        {
            base.OnElementChanged(oldElement, newElement);
            page = newElement as MainPage;
            var activity = this.Context as Activity;
        }

        //protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        //{
        //    base.OnElementChanged(e);
        //    page = e.NewElement as MainPage;
        //    var activity = this.Context as Activity;
        //}

    }
}
