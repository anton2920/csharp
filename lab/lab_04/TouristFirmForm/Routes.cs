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
	public class Routes : IValidatable
	{
		public Routes(string country = null, ClimateEnum climate = ClimateEnum.ClimateNone,
			UInt32 duration = 0, string hotel = null, double price = 0.0)
		{
			this.Country = country;
			this.ClimateType = climate;
			this.Duration = duration;
			this.Hotel = hotel;
			this.Price = price;
		}

		public string Country { get; set; }

		public ClimateEnum ClimateType { get; set; }

		public UInt32 Duration { get; set; }

		public string Hotel { get; set; }

		public double Price { get; set; }

		public bool IsValid => this.Country != null && this.ClimateType != ClimateEnum.ClimateNone && this.Duration != 0 && this.Hotel != null && this.Price != 0.0;

		public override string ToString()
		{
			return "Country: " + this.Country + "; Climate: " + this.ClimateType.ToString()
			       + "; Duration: " + this. Duration + "; Hotel: " + this.Hotel 
			       + "; Price: " + this.Price.ToString() + ";";
		}
	}
}