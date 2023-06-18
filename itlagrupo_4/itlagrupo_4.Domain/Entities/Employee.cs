using System;
namespace itlagrupo_4.Domain.Entities
{
    public class class1
    {
        public class Employee: BaseEntity
        {
            public string emp_id { get; set; }
            public string fname { get; set; }
            public string? minit { get; set; }
            public string lname { get; set; }
            public int job_id { get; set; }
            public int? job_lvl { get; set; }
            public string pub_id { get; set; }
            public DateTime hire_date { get; set; }

        }
    }
}