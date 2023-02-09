using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class WaitingForSubmissionState : State
	{
		public WaitingForSubmissionState(Order order) : base(order)
		{
		}

		
	}
}
