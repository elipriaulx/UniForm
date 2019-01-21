using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using UniForm.Engine.Forms;
using UniForm.Engine.Generation;

namespace UniForm.Wpf
{
    public class UniFormControl : Control
    {
        private static readonly FormGenerator _g = new FormGenerator();

        static UniFormControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UniFormControl), new FrameworkPropertyMetadata(typeof(UniFormControl)));
        }


        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(nameof(Content), typeof(object), typeof(UniFormControl), new UIPropertyMetadata(null, OnContentPropertyChanged));

        private static void OnContentPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Side effects.
            try
            {
                var control = (UniFormControl)d;
                var form = _g.CreateForm(e.NewValue);

                control.FormName = form?.Name;
                control.FormDescription = form?.Description;
                control.FormFields = form?.Fields;
            }
            catch (Exception ex)
            {
                // TODO
            }
        }

        public object Content
        {
            get => GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }







        public string FormName
        {
            get => (string)GetValue(FormNameProperty);
            protected set => SetValue(FormNamePropertyKey, value);
        }

        private static readonly DependencyPropertyKey FormNamePropertyKey = DependencyProperty.RegisterReadOnly(nameof(FormName), typeof(string), typeof(UniFormControl), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty FormNameProperty = FormNamePropertyKey.DependencyProperty;

        public string FormDescription
        {
            get => (string)GetValue(FormDescriptionProperty);
            protected set => SetValue(FormDescriptionPropertyKey, value);
        }

        private static readonly DependencyPropertyKey FormDescriptionPropertyKey = DependencyProperty.RegisterReadOnly(nameof(FormDescription), typeof(string), typeof(UniFormControl), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty FormDescriptionProperty = FormDescriptionPropertyKey.DependencyProperty;

        public IEnumerable<UniFormField> FormFields
        {
            get => (IEnumerable<UniFormField>)GetValue(FormFieldsProperty);
            protected set => SetValue(FormFieldsPropertyKey, value);
        }

        private static readonly DependencyPropertyKey FormFieldsPropertyKey = DependencyProperty.RegisterReadOnly(nameof(FormFields), typeof(IEnumerable<UniFormField>), typeof(UniFormControl), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty FormFieldsProperty = FormFieldsPropertyKey.DependencyProperty;

    }
}
