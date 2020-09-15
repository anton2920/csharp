using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristFirm
{
	/// <summary>
	/// Types of climate
	/// </summary>
	public enum ClimateEnum
	{
		Tropical,
		Dry,
		Temperate,
		Continental,
		Polar,
		ClimateNone
	}

	/// <summary>
	/// Record about tourists' routes
	/// </summary>
	class Routes : IValidatable
	{
		public Routes(string country = "NULL", ClimateEnum climate = ClimateEnum.ClimateNone,
			string hotel = "NULL", double price = 0.0)
		{
			this.Country = country;
			this.ClimateType = climate;
			this.Hotel = hotel;
			this.Price = price;
		}

		private string Country { get; set; }

		private ClimateEnum ClimateType { get; set; }

		private string Hotel { get; set; }

		private double Price { get; set; }

		public bool IsValid => this.Country != "NULL" && this.ClimateType != ClimateEnum.ClimateNone && this.Hotel != "NULL" && this.Price != 0.0;

		public override string ToString()
		{
			return "Country: " + this.Country + "; Climate: " + this.ClimateType.ToString()
			       + "; Hotel: " + this.Hotel + "; Price: " + this.Price.ToString() + ";";
		}
	}
}