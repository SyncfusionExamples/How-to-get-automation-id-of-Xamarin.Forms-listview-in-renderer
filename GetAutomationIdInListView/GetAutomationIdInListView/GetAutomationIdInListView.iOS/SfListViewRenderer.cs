using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SfListViewSample;
using SfListViewSample.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedListView), typeof(SfListViewRenderer))]

namespace SfListViewSample.iOS
{
   public class SfListViewRenderer: VisualElementRenderer<ExtendedListView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ExtendedListView> e)
        {
            base.OnElementChanged(e);
            var id = this.Element.AutomationId;
            System.Diagnostics.Debug.WriteLine("iOS Renderer Automation ID" + id);

        }
    }
}