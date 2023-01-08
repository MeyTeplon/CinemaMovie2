using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaMovie2.Model;

namespace CinemaMovie2.ViewModel
{
    class TvShowVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int TvId
        {
            get { return _pageModel.ProfileAcount; }
            set { _pageModel.ProfileAcount = value; OnPropertyChange(); }
        }
        public TvShowVM()
        {
            _pageModel = new PageModel();
            TvId = 01;
        }
        
    }
}
