# How to get automation id of Xamarin.Forms listview in renderer?

This example demonstrates how to get automation id of Xamarin.Forms listview in renderer.

## Sample 

```xaml
<StackLayout>
    <Button Text="Check AutomationID" Clicked="Button_Clicked"/>
    <local:ExtendedListView x:Name="listView" BackgroundColor="AliceBlue" AllowGroupExpandCollapse="True" 
                            AutomationId="12345"
                        ItemSpacing="3" ItemSize="70" ItemsSource="{Binding contactsinfo}">
        <local:ExtendedListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Grid x:Name="grid" RowSpacing="1" >
                            <code>
                            . . .
                            . . .
                            <code>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </local:ExtendedListView.ItemTemplate>
    </local:ExtendedListView>
</StackLayout>

C#:
private void Button_Clicked(object sender, EventArgs e)
{
    DisplayAlert("Message","ListView Automation ID:" +listView.AutomationId,"ok");
}
```

See [How to get automation id of Xamarin.Forms listview in renderer](https://www.syncfusion.com/kb/9960/how-to-get-automation-id-of-xamarin-forms-listview-in-renderer) for more details.

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
