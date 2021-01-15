using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WhoPoo.Model;
using WhoPoo.Service;

namespace WhoPoo.ViewModel
{
    public class WhoPooViewModel : BindableBase
    {
        private WhoPooService whoPooService;

        #region Properties
        private ObservableCollection<MatchListModel> _matchListItems;
        public ObservableCollection<MatchListModel> MatchListItems
        {
            get => _matchListItems;
            set => SetProperty(ref _matchListItems, value);
        }

        private ObservableCollection<MatchesModel> _matchesItems;
        public ObservableCollection<MatchesModel> MatchesItems
        {
            get => _matchesItems;
            set => SetProperty(ref _matchesItems, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private int _startIndex;
        public int StartIndex
        {
            get => _startIndex;
            set => SetProperty(ref _startIndex, value);
        }

        private int _endIndex;
        public int EndIndex
        {
            get => _endIndex;
            set => SetProperty(ref _endIndex, value);
        }

        private MatchListModel _selectedMatch;
        public MatchListModel SelectedMatch
        {
            get => _selectedMatch;
            set => SetProperty(ref _selectedMatch, value);
        }
        #endregion

        #region Commands
        public ICommand SearchMatchListCommand { get; set; }
        #endregion

        #region Constructor
        public WhoPooViewModel(WhoPooService whoPooService)
        {
            this.whoPooService = whoPooService;
            InitVariables();
            InitCommands();
        }
        #endregion

        #region Init
        private void InitVariables()
        {
            MatchListItems = new ObservableCollection<MatchListModel>();
            MatchesItems = new ObservableCollection<MatchesModel>();
        }

        private void InitCommands()
        {
            SearchMatchListCommand = new DelegateCommand(GetMatchList);
        }
        #endregion

        #region Command Method
        private bool IsValidName()
        {
            return (Name != null && Name.Trim().Length > 0) ? true : false;
        }

        private async void GetMatchList()
        {
            if (IsValidName())
            {
                try
                {
                    var response = await whoPooService.GetMatchList(name: Name, startIndex: StartIndex, endIndex: EndIndex);
                    var matches = response.Result.Matches;
                    if (matches != null && matches.Count > 0)
                    {
                        MatchListItems = new ObservableCollection<MatchListModel>(matches);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine("GET MATCH LIST ERROR : " + e.Message);
                }
            }
        }

        private async void GetLeague()
        {
            if (IsValidName())
            {
                try
                {
                    var response = await whoPooService.GetLeague(Name);

                }
                catch (Exception e)
                {
                    Debug.WriteLine("GET LEAGUE ERROR : " + e.Message);
                }
            }
        }
        #endregion

        private async void GetMatches(long gameId)
        {
            var response = await whoPooService.GetMatches(gameId);
        }
    }
}
