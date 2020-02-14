using System;
using System.Collections.Generic;
using System.Text;

namespace Pubs.Domain
{
	public class Discount
	{
        public string DiscountType { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int LowQty { get; set; }
        public int HighQty { get; set; }
        public double DiscountAmount { get; set; }
    }
}
