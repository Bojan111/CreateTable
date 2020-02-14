using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Author
	{
        public Author()
        {
            TitleAuthors = new List<TitleAuthor>();
        }
        public int AuthorId { get; set; }
        public string Au_LName { get; set; }
        public string Au_FName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<TitleAuthor> TitleAuthors { get; set; }
    }
}
