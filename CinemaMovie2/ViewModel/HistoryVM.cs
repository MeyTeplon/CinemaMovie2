using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaMovie2.Model;

namespace CinemaMovie2.ViewModel
{
    class HistoryVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public DateOnly DisplayHitoryGate
        {
            get { return _pageModel.HistoryGate; }
            set { _pageModel.HistoryGate = value; OnPropertyChange(); }
        }
        public HistoryVM()
        {
            _pageModel = new PageModel();
            DisplayHitoryGate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
