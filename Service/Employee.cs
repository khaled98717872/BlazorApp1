using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Employee
    {
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int Age { get; set; }

		

		[Required]
		public int MobileNumber { get; set; }
		public Department Department { get; set; }
	}
}
