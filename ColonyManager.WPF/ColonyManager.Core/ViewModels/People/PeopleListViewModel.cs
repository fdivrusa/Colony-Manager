using ColonyManager.Core.Models.Responses;
using ColonyManager.Core.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace ColonyManager.Core.ViewModels
{
    public class PeopleListViewModel : ViewModelBase
    {
        private readonly IPeopleService _peopleService;
        private readonly ILogger<PeopleListViewModel> _logger;
        public ObservableCollection<PeopleListDto> Peoples { get; private set; }

        public PeopleListViewModel(IPeopleService peopleService, ILogger<PeopleListViewModel> logger) : base(logger)
        {
            _peopleService = peopleService;
            _logger = logger;
            Peoples = new ObservableCollection<PeopleListDto>
            {
                new PeopleListDto
                {
                    FirstName = "TEST"
                }
            };
        }

        public async Task AsyncDataLoad()
        {
            await Task.Run(() => AddItemsToList());
        }

        public void AddItemsToList()
        {
            for (int i = 0; i < 10; i++)
            {
                Application.Current.Dispatcher.Invoke(() => Peoples.Add(new PeopleListDto { FirstName = "First" }));
            }
        }
    }
}
