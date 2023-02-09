using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class Movie
	{
		private string _title { get; set; }
		List<MovieScreening> _movieScreenings { get; set; }
		
		public Movie(string title) 
		{ 
			_title= title;
		}

		public void AddScreening(MovieScreening screening) 
		{ 
			_movieScreenings.Add(screening);
		}

		public override string ToString()
		{
			//TODO: implementeer dit jwz
			return "";
		}
	}
}
