using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TouristFirm
{
	class Clients : IValidatable
	{


		private string FirstName { get; set; }

		private string LastName { get; set; }

		private string Address { get; set; }

		/// <summary>
		/// Phone number
		/// </summary>
		private string Phone { get; set; }

		public bool IsValid => FirstName != "NULL" && LastName != "NULL" && Address != "NULL" && Phone != "NULL";
	}
}
