using System;
namespace itlagrupo_4.Infrastructure.Models
{
	public class TitlesModel
	{

        public int titlesID { get; set; }
        public string titles { get; set; }
        public char type { get; set; }
        public int pubID { get; set; }
        public decimal price { get; set; }
        public decimal advance { get; set; }
        public int royalty { get; set; }
        public int ytd_sales { get; set; }
        public string notes { get; set; }
        public DateTime pubdate { get; set; }
    }
}

