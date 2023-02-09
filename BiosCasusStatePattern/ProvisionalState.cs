using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class ProvisionalState : State
	{
		public ProvisionalState(Order order) : base(order)
		{
		}
	}
}
