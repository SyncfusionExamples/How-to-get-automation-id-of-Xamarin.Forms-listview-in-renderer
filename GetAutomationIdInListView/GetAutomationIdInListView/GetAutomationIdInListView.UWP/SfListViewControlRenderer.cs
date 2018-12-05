using SfListViewSample;
using SfListViewSample.UWP;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Xamarin.Forms.Platform.UWP;
[assembly: ExportRenderer(typeof(ExtendedListView), typeof(SfListViewControlRenderer))]

namespace SfListViewSample.UWP
{
   public class SfListViewControlRenderer : VisualElementRenderer<SfListView, CustomControl>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SfListView> e)
        {
            base.OnElementChanged(e);

            object id = this.Element.AutomationId;
            System.Diagnostics.Debug.WriteLine("UWP Renderer Automation ID" + id);
        }
    }
    
    public class CustomControl : Windows.UI.Xaml.Controls.Control
    {
    }
}
