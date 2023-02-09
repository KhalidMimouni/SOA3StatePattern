using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class SubmittedState : State
	{
		public SubmittedState(Order order) : base(order)
		{
		}
	}
}
