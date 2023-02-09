using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosCasusStatePattern
{
	public class Order
	{
		private int _orderNr { get; set; }
		private bool _isStudentOrder { get; set; }
		private List<MovieTicket> _movieTickets { get; set; }
		private State state { get; set; }

		public Order(int orderNr, bool isStudentOrder)
		{
			_orderNr = orderNr;
			_isStudentOrder = isStudentOrder;
			state = new WaitingForSubmissionState(this);
		}

		public int GetOrderNr()
		{
			return _orderNr;
		}

		public void AddSeatReservation(MovieTicket movieTicket)
		{
			_movieTickets.Add(movieTicket);
		}

		public double CalculatePrice()
		{
			return -1.0;
		}

		public void Export(TicketExportFormat exportFormat)
		{ 

		}
	}
}
