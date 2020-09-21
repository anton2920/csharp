using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristFirm
{

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

        private Clients Client { get; set; }

        private DateTime? DateOfDeparture { get; set; }

        private UInt32 Quantity { get; set; }

        private double Discount { get; set; }

        public bool IsValid => this.Route != null && this.Client != null && this.DateOfDeparture != null && this.Quantity != 0 && this.Discount != 0.0;

        public override string ToString()
        {
            return "Route: " + this.Route.ToString() + "; Client: " + this.Client.ToString() + "; Date of departure: " + this.DateOfDeparture.ToString() + "; Quantity: " + this.Quantity + "; Discount: " + this.Discount;
        }
    }
}