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
            new CategoryViewModel("ȫ����Ϸ"){IsSelected=true},
            new CategoryViewModel("��ɫ����"),
            new CategoryViewModel("����")
        };
    }
}