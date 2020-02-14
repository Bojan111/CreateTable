using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Employee
	{
        public int EmployeeId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        public DateTime HireDate { get; set; }
        public Job Job { get; set; }
        public int JobId { get; set; }

    }
}
