using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using UniForm.Wpf.Controls.Models;

namespace UniForm.Wpf.Controls
{
    public class EnumBox : Control
    {
        public object SelectedItem
        {
            get => GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public IEnumerable<EnumItem> AvailableItems
        {
            get => (IEnumerable<EnumItem>)GetValue(AvailableItemsProperty);
            set => SetValue(AvailableItemsProperty, value);
        }

        public EnumItem NominatedItem
        {
            get => (EnumItem)GetValue(NominatedItemProperty);
            set => SetValue(NominatedItemProperty, value);
        }

        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(nameof(SelectedItem), typeof(object), typeof(EnumBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SelectedItemChanged));

        public static readonly DependencyProperty AvailableItemsProperty = DependencyProperty.Register(nameof(AvailableItems), typeof(IEnumerable<EnumItem>), typeof(EnumBox), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty NominatedItemProperty = DependencyProperty.Register(nameof(NominatedItem), typeof(EnumItem), typeof(EnumBox), new FrameworkPropertyMetadata(null, NominatedItemPropertyChanged));


        private Type _enumType = null;

        static EnumBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EnumBox), new FrameworkPropertyMetadata(typeof(EnumBox)));
        }

        private static void NominatedItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as EnumBox;
            var value = control.NominatedItem?.Value;

            if (value != control.SelectedItem)
                control.SelectedItem = value;
        }

        private static void SelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as EnumBox;

            control?.SetSelectedItem(e.NewValue as Enum);
        }

        private void SetSelectedItem(Enum value)
        {
            if (value == null)
            {
                if (AvailableItems != null && NominatedItem != null)
                {
                    AvailableItems = null;
                    NominatedItem = null;
                }

                return;
            }

            var t = value.GetType();

            if (t != _enumType)
            {
                var candidateValues = Enum.GetValues(t).Cast<Enum>();
                
                AvailableItems = candidateValues.Select(v => new EnumItem(v)).ToList();
                _enumType = t;
            }

            if (Equals(NominatedItem?.Value, value))
            {
                return;
            }
            
            NominatedItem = AvailableItems.FirstOrDefault(x => Equals(x.Value, value));
        }
    }
}
