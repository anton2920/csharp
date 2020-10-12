using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TouristFirm
{
	public class Clients : IValidatable
	{
        public Clients (string firstName = null, string lastName = null, string address = null, string phone = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = phone;
        }

		/// <summary>
		/// Client's first name
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Client's last name
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Client's home address
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Phone number
		/// </summary>
		public string Phone { get; set; }

		public bool IsValid => this.FirstName != "NULL" && this.LastName != "NULL" && this.Address != "NULL" && this.Phone != "NULL";

        public override string ToString()
        {
            return "First name: " + this.FirstName + "; Last name: " + this.LastName + "; Address: " + this.Address + "; Phone: " + this.Phone;
        }
    }
}
