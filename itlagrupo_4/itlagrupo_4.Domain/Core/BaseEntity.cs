

using System;

public abstract class BaseEntity
{
        public BaseEntity()
        {
        this.CreateDate = DateTime.Now;
        this.Delete = false;
        }

    public string emp_id { get; set; }
    public string fname { get; set; }
    public string? minit { get; set; }
    public string lname { get; set; }
    public int job_id { get; set; }
    public int? job_lvl { get; set; }
    public string pub_id { get; set; }
    public DateTime hire_date { get; set; }
    public DateTime CreateDate { get; set; }
    public bool Delete { get; set; }
}


  


    

