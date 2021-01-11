using System.Windows;
using WhoPoo.Service;
using WhoPoo.ViewModel;

namespace WhoPoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WhoPooViewModel whoPooViewModel = new WhoPooViewModel(new WhoPooService());

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = whoPooViewModel;
        }
    }
}
