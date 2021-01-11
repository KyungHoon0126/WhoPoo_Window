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
        private static readonly WhoPooService whoPooService = new WhoPooService();
        private static readonly WhoPooViewModel whoPooViewModel = new WhoPooViewModel();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = whoPooViewModel;
            await whoPooService.GetMatchList("후쿠시마원자");
            await whoPooService.GetMatches(4897529222);
        }
    }
}
