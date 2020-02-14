using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class PubInfo
	{
		public int PublisherId { get; set; }
		public string Logo { get; set; }
		public string PublisherInfo { get; set; }
		public Publisher Publisher { get; set; }
	}
}
