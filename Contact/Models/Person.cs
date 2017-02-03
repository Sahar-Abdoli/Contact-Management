using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	class Person
	{
		public Person()
		: base()
		{ }

		//Person Fields in Database Is these Peroperty
		//***********************************************************************************
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Family { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

	}
}
