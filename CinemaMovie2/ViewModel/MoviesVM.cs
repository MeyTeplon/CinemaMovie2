using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaMovie2.Model;

namespace CinemaMovie2.ViewModel
{
    class MoviesVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public string MovieAvailabelity
        {
            get { return _pageModel.MovieStatus; }
            set { _pageModel.MovieStatus = value; OnPropertyChange(); }
        }
        public MoviesVM()
        {
            _pageModel = new PageModel();
            MovieAvailabelity = "Out of Stock";
        }
    }
}
