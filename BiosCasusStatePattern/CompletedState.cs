using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class CompletedState : State
	{
		public CompletedState(Order order) : base(order)
		{
		}
	}
}
