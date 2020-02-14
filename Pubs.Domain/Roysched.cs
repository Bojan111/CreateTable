using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Roysched
	{
		public int TitleId { get; set; }
		public Title Title { get; set; }
		public int Lorange { get; set; }
		public int HiRange { get; set; }
		public int Royalty { get; set; }
	}
}
