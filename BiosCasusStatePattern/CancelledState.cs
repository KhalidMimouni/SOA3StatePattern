using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class CancelledState : State
	{
		public CancelledState(Order order) : base(order)
		{
		}
	}
}
