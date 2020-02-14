using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Store
	{
        public Store()
        {
            Sales = new List<Sales>();
        }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public List<Sales> Sales { get; set; }
    }
}
