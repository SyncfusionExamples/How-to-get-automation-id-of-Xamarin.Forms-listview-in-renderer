using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfListViewSample
{
   
    public partial class MainPage : ContentPage
    {
        ContactsViewModel viewmodel;
        #region Constructor
        public MainPage()
        {
            InitializeComponent();

            listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ContactName",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as Contacts);
                    return item.ContactName[0].ToString();
                },
            });
            // this.listView.ItemGenerator= new ItemGeneratorExt(this.listView);
            viewmodel = new ContactsViewModel();
            listView.BindingContext = viewmodel;
        }


        #endregion
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message","ListView Automation ID:" +listView.AutomationId,"ok");
        }
     
    }
   
    public class ItemGeneratorExt : ItemGenerator
    {
        public SfListView ListView { get; set; }

        public ItemGeneratorExt(SfListView listview) : base(listview)
        {
            ListView = listview;
        }

        protected override ListViewItem OnCreateListViewItem(int itemIndex, ItemType type, object data = null)
        {

            if (type == ItemType.Record)
                return new ListViewItemExt(ListView);
            else
                return base.OnCreateListViewItem(itemIndex, type);
        }
    }
    public class ListViewItemExt : ListViewItem
    {
        private SfListView _listView;
        public ListViewItemExt(SfListView listView)
        {
            _listView = listView;
        }

    }
    public class ExtendedListView : SfListView
    {
        public ExtendedListView()
        {

        }
    }

}
