using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Title
	{

        public Title()
        {
            TitleAuthors = new List<TitleAuthor>();
            Sales = new List<Sales>();
        }
        public int TitleId { get; set; }
        public string BookTitle { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Notes { get; set; }
        public DateTime PublishDate { get; set; }
        public List<TitleAuthor> TitleAuthors { get; set; }
        public List<Sales> Sales { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
    }
}
