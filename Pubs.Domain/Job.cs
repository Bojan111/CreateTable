using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Job
	{
		public int JobId { get; set; }
		public string JobDescription { get; set; }
		public int MinLvl { get; set; }
		public Employee Emloyee { get; set; }
	}
}
