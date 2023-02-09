using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public abstract class State
	{
		public Order Order { get; set; }
		public State(Order order)
		{ 
			Order = order;
		}
	}
}
