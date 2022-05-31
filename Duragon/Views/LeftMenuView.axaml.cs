using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Duragon.Views;

public partial class LeftMenuView : UserControl
{
    public LeftMenuView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}