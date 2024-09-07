using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Material.Icons.WinUI3;

public partial class MaterialIcon : Control {
    public static readonly DependencyProperty KindProperty
        = DependencyProperty.Register(nameof(Kind), typeof(MaterialIconKind), typeof(MaterialIcon),
            new PropertyMetadata(default(MaterialIconKind), KindPropertyChangedCallback));

    public static readonly DependencyProperty DataProperty
        = DependencyProperty.Register(nameof(Data), typeof(Geometry), typeof(MaterialIcon), new PropertyMetadata(null));

    public MaterialIcon() {
        DefaultStyleKey = typeof(MaterialIcon);
    }

    /// <summary>
    /// Gets or sets the icon to display.
    /// </summary>
    public MaterialIconKind Kind {
        get => (MaterialIconKind)GetValue(KindProperty);
        set => SetValue(KindProperty, value);
    }

    /// <summary>
    /// Gets the icon path data for the current <see cref="Kind"/>.
    /// </summary>
    public Geometry? Data {
        get => (Geometry?)GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }

    protected override void OnApplyTemplate() {
        base.OnApplyTemplate();
        UpdateData();
    }

    private static void KindPropertyChangedCallback(DependencyObject dependencyObject,
        DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        => ((MaterialIcon)dependencyObject).UpdateData();

    private static Geometry ParseFromString(string source) {
        return (Geometry)XamlReader.Load(
            $"""
             <Geometry xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation">{source}</Geometry>
             """);
    }

    private void UpdateData() {
        Data = ParseFromString(MaterialIconDataProvider.GetData(Kind));
    }
}
