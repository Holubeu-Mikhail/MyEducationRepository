using System.Windows;

namespace SimplePaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum Sizes
        {
            Small = 10,
            Medium = 20,
            Large = 30
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
