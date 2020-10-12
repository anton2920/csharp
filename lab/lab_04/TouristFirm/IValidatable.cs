using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristFirm
{
	/// <summary>
	/// Common interface to check, whether all fields are valid
	/// </summary>
    interface IValidatable
	{
		bool IsValid { get;  }
	}
}
