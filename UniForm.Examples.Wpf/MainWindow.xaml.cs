using UniForm.Examples.Wpf.Models;

namespace UniForm.Examples.Wpf
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public object ExampleA { get; } = new ExampleCatForm();
    }
}
