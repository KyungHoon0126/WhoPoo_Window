using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using WhoPoo.Model;
using WhoPoo.Service;
using WhoPoo.Service.Response;

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

        private List<PlayerModel> _playerItems;
        public List<PlayerModel> PlayerItems
        {
            get => _playerItems;
            set => SetProperty(ref _playerItems, value);
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
            PlayerItems = new List<PlayerModel>();
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
                    var matchItems = new MatchListModel();

                    foreach(var match in response.Result.Matches)
                    {
                        matchItems.PlatformId = match.PlatformId;
                        matchItems.GameId = match.GameId;
                        matchItems.Champion = match.Champion;
                        matchItems.Queue = match.Queue;
                        matchItems.Season = match.Season;
                        matchItems.TimeStamp = match.TimeStamp;
                        matchItems.Role = match.Role;
                        matchItems.Lane = match.Lane;
                        matchItems.Time = match.Time;

                        var matches = GetMatches(match.GameId);

                        MatchListItems.Add((MatchListModel)matchItems.Clone());
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine("GET MATCH LIST ERROR : " + e.Message);
                }
            }
        }

        private async void GetLeague(int gameId)
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

        private async Task<MatchesResponse> GetMatches(long gameId)
        {
            var response = await whoPooService.GetMatches(gameId);
            return response;
        }
    }
}
