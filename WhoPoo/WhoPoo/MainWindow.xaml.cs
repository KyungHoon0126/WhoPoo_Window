using System.Windows;
using System.Windows.Controls;
using WhoPoo.Common;
using WhoPoo.Model;
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

        private void lvMatchList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var championValue = (lvMatchList.SelectedItem as MatchListModel).Champion;
            MessageBox.Show(ComUtil.ChampionValueToNameConvert(championValue).ToString());
        }
    }
}   
