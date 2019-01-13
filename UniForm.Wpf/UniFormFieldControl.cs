using System.Windows;
using System.Windows.Controls;

namespace UniForm.Wpf
{
    public class UniFormFieldControl : ContentControl
    {
        static UniFormFieldControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UniFormFieldControl), new FrameworkPropertyMetadata(typeof(UniFormFieldControl)));
        }
        
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }
        
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(UniFormFieldControl), new PropertyMetadata(null));

        public static readonly DependencyProperty DescriptionProperty = DependencyProperty.Register(nameof(Description), typeof(string), typeof(UniFormFieldControl), new PropertyMetadata(null));

    }
}
