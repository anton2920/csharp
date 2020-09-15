using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristFirm
{

	class Voucher
	{
		public Voucher(Routes route = , Clients client, DateTime date = {1, 1, 2000}, UInt32 )
		{

		}

		/// <summary>
		/// Information about route
		/// </summary>
		private Routes Route { get; set; }

		private Clients Client { get; set; }

		private DateTime DateOfDeparture { get; set; }

		private UInt32 Quantity { get; set; }

		private double Discount { get; set; } 
	}
}