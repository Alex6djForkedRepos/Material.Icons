﻿using Avalonia;
using Avalonia.Controls.Primitives;

namespace Material.Icons.Avalonia {
    public class MaterialIcon : TemplatedControl {
        public static readonly StyledProperty<MaterialIconKind> KindProperty
            = AvaloniaProperty.Register<MaterialIcon, MaterialIconKind>(nameof(Kind));

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
        public MaterialIconKind Kind {
            get => GetValue(KindProperty);
            set => SetValue(KindProperty, value);
        }

        public static readonly StyledProperty<double> IconSizeProperty =
            AvaloniaProperty.Register<MaterialIconText, double>(nameof(IconSize), defaultValue: double.NaN);

        /// <summary>
        /// Gets or sets the uniform size of the icon.
        /// </summary>
        public double IconSize {
            get => GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty, value);
        }

        public static readonly StyledProperty<MaterialIconAnimation> AnimationProperty
            = AvaloniaProperty.Register<MaterialIcon, MaterialIconAnimation>(nameof(Animation));

        /// <summary>
        /// Gets or sets the icon animation to play.
        /// </summary>
        public MaterialIconAnimation Animation {
            get => GetValue(AnimationProperty);
            set => SetValue(AnimationProperty, value);
        }
    }
}
