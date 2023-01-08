using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaMovie2.Model;

namespace CinemaMovie2.ViewModel
{
    class SettingVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public bool settings
        {
            get { return _pageModel.LocationStatus; }
            set { _pageModel.LocationStatus = value; OnPropertyChange(); }
        }
        public SettingVM()
        {
            _pageModel = new PageModel();
            settings = true;
        }
    }
}
