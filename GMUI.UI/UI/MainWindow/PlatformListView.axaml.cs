using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GMUI.UI.ViewModel;


namespace GMUI.UI;

public partial class PlatformListView : UserControl
{
    public PlatformListView()
    {
        InitializeComponent();

        ListView.ItemsSource = new List<PlatformViewModel>()
        {
            new PlatformViewModel(null),
            new PlatformViewModel(null)
        };
    }

    
}