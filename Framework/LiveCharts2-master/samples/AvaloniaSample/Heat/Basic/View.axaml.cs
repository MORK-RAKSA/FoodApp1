using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaSample.Heat.Basic;

public partial class View : UserControl
{
    public View()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
