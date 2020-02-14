using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Sales
	{
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int SalesId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }
    }
}
