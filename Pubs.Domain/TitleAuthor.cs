using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class TitleAuthor
	{
		public Author Author { get; set; }
		public int AuthorId { get; set; }
		public Title Title { get; set; }
		public int TitleId { get; set; }
	}
}
