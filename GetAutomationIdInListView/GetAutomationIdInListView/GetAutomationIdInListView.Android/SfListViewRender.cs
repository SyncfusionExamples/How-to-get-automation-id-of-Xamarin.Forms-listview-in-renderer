using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SfListViewSample;
using SfListViewSample.Droid;
using Syncfusion.ListView.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedListView), typeof(SfListViewControlRenderer))]

namespace SfListViewSample.Droid
{
   public class SfListViewControlRenderer : ViewRenderer<ExtendedListView, Android.Views.View>
    {
        public SfListViewControlRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<ExtendedListView> e)
        {
            base.OnElementChanged(e);
            var id = this.Element.AutomationId;
            System.Diagnostics.Debug.WriteLine("UWP Renderer Automation ID" + id);
        }
    }
}