using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class MovieTicket
	{
		private int _rowNr { get; set; }
		private int _seatNr { get; set; }
		private bool _isPremium { get; set; }
		private MovieScreening _movieScreening { get; set; }

		public MovieTicket(bool isPremiumReservation, int seatRow, int seatNr, MovieScreening movieScreening)
		{ 
			_rowNr = seatRow;
			_seatNr = seatNr;
			_isPremium = isPremiumReservation;
			_movieScreening = movieScreening;
		}

		public bool IsPremiumTicket()
		{
			return _isPremium;
		}

		public double GetPrice()
		{
			return -1.0;
		}

		public override string ToString()
		{
			//TODO: Implement deze jwz
			return "";
		}

	}
}
