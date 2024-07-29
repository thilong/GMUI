using Avalonia;
using Avalonia.Controls;
using Avalonia.Reactive;
using ReactiveUI;

namespace GMUI.UI;


public class MainWindowModel : ReactiveObject
{
    public string BindText { get; set; }

    private bool _isPlatformVisiable = true;
    public bool IsPlatformVisiable
    {
        get => _isPlatformVisiable;
        set => this.RaiseAndSetIfChanged(ref _isPlatformVisiable, value);
    }

    private bool _isCategoryVisiable = true;
    public bool IsCategoryVisiable
    {
        get => _isCategoryVisiable;
        set => this.RaiseAndSetIfChanged(ref _isCategoryVisiable, value);
    }

    private bool _isPropertyVisiable = false;
    public bool IsPropertyVisiable
    {
        get => _isPropertyVisiable;
        set => this.RaiseAndSetIfChanged(ref _isPropertyVisiable, value);
    }

}


public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
    }

    MainWindowModel Model
    {
        get
        {
            return this.DataContext as MainWindowModel;
        }
    }

    private void PlatformToggle_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Model.IsPlatformVisiable = !Model.IsPlatformVisiable;
    }

    private void CategoryToggle_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Model.IsCategoryVisiable = !Model.IsCategoryVisiable;
    }

    private void PropertyToggle_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Model.IsPropertyVisiable = !Model.IsPropertyVisiable;
    }

}


