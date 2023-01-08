using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaMovie2.Model;

namespace CinemaMovie2.ViewModel
{
    class PaymentVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public decimal PaymentAmount
        {
            get { return _pageModel.PaymentValue; }
            set { _pageModel.PaymentValue = value; OnPropertyChange(); }
        }
        public PaymentVM()
        {
            _pageModel = new PageModel();
            PaymentAmount = 40000;
        }
            

    }
}
