using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristFirm
{
	/// <summary>
	/// Class, describing all vouchers. Inherits IValidatable
	/// </summary>
    class Voucher : IValidatable
	{
	    public Voucher(Routes route = null, Clients client = null, DateTime? date = null, UInt32 quantity = 0, double discount = 0.0)
        {
            this.Route = route;
            this.Client = client;
            this.DateOfDeparture = date;
            this.Quantity = quantity;
            this.Discount = discount;
        }

        /// <summary>
        /// Information about route
        /// </summary>
        private Routes Route { get; set; }

		/// <summary>
		/// Information about clients
		/// </summary>
        private Clients Client { get; set; }

		/// <summary>
		/// Date of the start
		/// </summary>
        private DateTime? DateOfDeparture { get; set; }

		/// <summary>
		/// Quantity, that customer has bought
		/// </summary>
        private UInt32 Quantity { get; set; }

		/// <summary>
		/// Possible discount ranged between [0, 1]
		/// </summary>
        private double Discount { get; set; }

		/// <summary>
		/// Validating things
		/// </summary>
        public bool IsValid => this.Route != null && this.Client != null && this.DateOfDeparture != null && this.Quantity != 0 && this.Discount != 0.0;

		/// <summary>
		/// Converting all information to string
		/// </summary>
		/// <returns>String, consisting of all fields</returns>
        public override string ToString()
        {
            return "Route: " + this.Route.ToString() + "; Client: " + this.Client.ToString() + "; Date of departure: " + this.DateOfDeparture.ToString() + "; Quantity: " + this.Quantity + "; Discount: " + this.Discount;
        }
    }
}