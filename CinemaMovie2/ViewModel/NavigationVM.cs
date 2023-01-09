using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CinemaMovie2.Model;
using CinemaMovie2.Utilities;
using CinemaMovie2.View;

namespace CinemaMovie2.ViewModel
{
    class NavigationVM : Utilities.ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChange(); }
        }
        public ICommand HomeCommand { get; set; }
        public ICommand MoviesCommand { get; set; }
        public ICommand MyFavoriteCommand { get; set; }
        public ICommand PaymentCommand { get; set; }
        public ICommand TvShowsCommand { get; set; }
        public ICommand SettingCommand { get; set; }
        public ICommand HistoryCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Movies(object obj) => CurrentView = new MoviesVM();
        private void MyFavorite(object obj) => CurrentView = new MyFavoritesVM();
        private void Payment(object obj) => CurrentView = new PaymentVM();
        private void TvShows(object obj) => CurrentView = new TvShowVM();
        private void Setting(object obj) => CurrentView = new SettingVM();
        private void History(object obj) => CurrentView = new HistoryVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            MoviesCommand = new RelayCommand(Movies);
            MyFavoriteCommand = new RelayCommand(MyFavorite);
            PaymentCommand = new RelayCommand(Payment);
            TvShowsCommand = new RelayCommand(TvShows);
            SettingCommand = new RelayCommand(Setting);
            HistoryCommand = new RelayCommand(History);

            //start page
            CurrentView = new HomeVM();
        }
    }
}
