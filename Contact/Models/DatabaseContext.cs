using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Models
{
	class DatabaseContext:DbContext
	{
		static DatabaseContext() 
		{
		}

		public DatabaseContext()
		: base()
		{
		
		}
		//People Entity Expression
		public DbSet<Person> People { get; set; }
	}
}
