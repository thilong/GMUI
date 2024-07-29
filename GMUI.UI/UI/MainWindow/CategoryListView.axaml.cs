using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GMUI.UI.ViewModel;

namespace GMUI.UI;

public partial class CategoryListView : UserControl
{
    public CategoryListView()
    {
        InitializeComponent();
        ListView.ItemsSource = new List<CategoryViewModel>()
        {
            new CategoryViewModel("全部游戏"){IsSelected=true},
            new CategoryViewModel("角色扮演"),
            new CategoryViewModel("动作游戏"),
        };
    }
}