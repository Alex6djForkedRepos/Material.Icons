using System.Windows;
using System.Windows.Controls;

namespace Material.Icons.WPF {
    public class MaterialIconText : MaterialIcon {
        static MaterialIconText() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaterialIconText), new FrameworkPropertyMetadata(typeof(MaterialIconText)));
        }

        public static readonly DependencyProperty SpacingProperty = DependencyProperty.Register(
            nameof(Spacing), typeof(double), typeof(MaterialIconText), new PropertyMetadata(default(double)));

        public static readonly DependencyProperty OrientationProperty =
            StackPanel.OrientationProperty.AddOwner(typeof(MaterialIconText));

        public static readonly DependencyProperty TextProperty =
                TextBlock.TextProperty.AddOwner(typeof(MaterialIconText));

        public static readonly DependencyProperty TextFirstProperty = DependencyProperty.Register(
            nameof(TextFirst), typeof(bool), typeof(MaterialIconText), new PropertyMetadata(default(bool)));

        /// <summary>
        /// Gets or sets the spacing between the icon and the text
        /// </summary>
        public double Spacing {
            get => (double)GetValue(SpacingProperty);
            set => SetValue(SpacingProperty, value);
        }

        /// <summary>
        /// Gets or sets the orientation in which the icon and the text will be layed out.
        /// </summary>
        public Orientation Orientation {
            get => (Orientation)GetValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }

        /// <summary>
        /// Gets or sets the text to display
        /// </summary>
        public string? Text {
            get => (string?)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        /// <summary>
        /// Gets or sets whether the text should appear on the left side instead of the right
        /// </summary>
        public bool TextFirst {
            get => (bool)GetValue(TextFirstProperty);
            set => SetValue(TextFirstProperty, value);
        }
    }
}
