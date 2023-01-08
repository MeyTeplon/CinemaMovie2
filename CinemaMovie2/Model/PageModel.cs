using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaMovie2.Model
{
    public class PageModel
    {
        public int ProfileAcount { get; set; } //menu profil akun
        public string MovieStatus { get; set; } //menu movie
        public DateOnly HistoryGate { get; set; } // menu history
        public decimal PaymentValue { get; set; } //untuk menu pembayaran
        public TimeOnly FavouritMovie { get; set; } //untuk menu favorit
        public bool LocationStatus { get; set; } //untuk menu seting

    }
}
