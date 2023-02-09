using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class PaidState : State
	{
		public PaidState(Order order) : base(order)
		{
		}
	}
}
