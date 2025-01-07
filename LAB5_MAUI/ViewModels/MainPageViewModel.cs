using LAB5_MAUIDATA.Interfaces;
using LAB5_MAUIDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;


namespace LAB5_MAUI.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDataRepository _dataRepository;

        public MainPageViewModel(IDataRepository dataRepository)
        {
            Title = "Loading ...";
            _dataRepository = dataRepository;

            LoadCommand = new RelayCommand(LoadData);
            //SelectHouseCommand = new RelayCommand(ShowDetails);

            LoadData();
        }

        //public async void ShowDetails()
        //{
        //    var navigationParameter = new ShellNavigationQueryParameters
        //    {
        //        { "House", SelectHouseCommand }
        //    };

        //    await Shell.Current.GoToAsync("//AddressPage", navigationParameter);
        //}

        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private House[] _houses;
        public House[] Houses
        {
            get => _houses;
            set
            {
                _houses = value;
                OnPropertyChanged();
            }
        }
        private House _selectedHouse;

        public House SelectedHouse
        {
            get => _selectedHouse;
            set
            {
                _selectedHouse = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadCommand { get; }

        public ICommand SelectsHouseCommand { get; }

        public async void LoadData()
        {
            Title = "Loading ...";

            var data = await _dataRepository.GetHouseAsync();
            Houses = data;
            Title = "Number of houses: " + data.Length;
        }
    }
}
