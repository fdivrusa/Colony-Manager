using ColonyManager.Core.Models.Responses;
using ColonyManager.Core.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ColonyManager.Core.ViewModels
{
    public class PeopleListViewModel : ViewModelBase
    {
        private readonly IPeopleService _peopleService;
        private readonly ILogger<PeopleListViewModel> _logger;

        public PeopleListViewModel(IPeopleService peopleService, ILogger<PeopleListViewModel> logger) : base(logger)
        {
            _peopleService = peopleService;
            _logger = logger;
        }

        private ICommand _loadPeoplesListCommand;

        public ICommand LoadPeoplesListCommand
        {
            get
            {
                if (_loadPeoplesListCommand == null)
                {
                    _loadPeoplesListCommand = new RelayCommand<Window>(async param => await LoadPeoples(), canExecute => CanLoadPeoples());
                }
                return _loadPeoplesListCommand;
            }
        }

        private ObservableCollection<PeopleDto> _peoples;

        public ObservableCollection<PeopleDto> Peoples
        {
            get { return _peoples; }
            set
            {
                if (_peoples != value)
                {
                    _peoples = value;
                    NotifyPropertyChanged(nameof(Peoples));
                }
            }
        }

        private async Task LoadPeoples()
        {
            _logger.LogDebug("Loading all peoples in list");
            var response = await _peopleService.GetPeoplesList();

            if (response.Success)
            {
                Peoples = new ObservableCollection<PeopleDto>(response.Peoples);
            }
        }

        private bool CanLoadPeoples()
        {
            return Global.CurrentUser.IsVerified;
        }
    }
}
