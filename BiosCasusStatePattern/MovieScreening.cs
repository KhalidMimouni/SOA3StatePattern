﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class MovieScreening
	{
		private DateTime _dateAndTime { get; set; }
		private double _pricePerSeat { get; set; }
		private Movie _movie { get; set; }
		
		public MovieScreening(DateTime dateAndTime, double pricePerSeat, Movie movie) 
		{ 
			_dateAndTime = dateAndTime;
			_pricePerSeat= pricePerSeat;
			_movie = movie;
		}

		public double GetPricePerSeat()
		{
			return _pricePerSeat;
		}

		public override string ToString()
		{
			//TODO: implementeer deze jwz
			return "";
		}
	}
}
