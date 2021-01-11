using System.Windows;
using WhoPoo.Service;

namespace WhoPoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WhoPooService whoPooService = new WhoPooService();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await whoPooService.GetMatchList("후쿠시마원자");
            await whoPooService.GetMatches(4897529222);
        }
    }
}
