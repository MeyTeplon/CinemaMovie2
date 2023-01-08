using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaMovie2.Model;

namespace CinemaMovie2.ViewModel
{
    class MyFavoritesVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public TimeOnly FavoriteM
        {
            get { return _pageModel.FavouritMovie; }
            set { _pageModel.FavouritMovie = value; OnPropertyChange(); }
        }
        public MyFavoritesVM()
        {
            _pageModel = new PageModel();
            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
            FavoriteM = time;
        }
    }
}
