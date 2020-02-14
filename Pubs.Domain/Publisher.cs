using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Publisher
	{
        public Publisher()
        {
            Titles = new List<Title>();
        }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public PubInfo PubInfo { get; set; }
        public List<Title> Titles { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
