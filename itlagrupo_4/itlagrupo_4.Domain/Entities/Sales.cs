
using System;

namespace itlagrupo_4.Domain.Entities
{
    public class Sales
    {
        public int stor_id { get; set; }

        public int ord_num { get; set; }

        public DateTime ord_date { get; set; }

        public int qty { get; set; }

        public String payterms { get; set; }

        public String title_id { get; set; }

    }
}
