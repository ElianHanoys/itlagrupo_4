
using itlagrupo_4.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace itlagrupo_4.Domain.Entities
{
    public class Author : BaseEntity
    {
        [Key]
        public string au_id { get; set; }
        public string au_lname { get; set;}
        public string au_fname { get; set;}
        public char phone { get; set;}
        public string? address { get; set;}
        public int contract { get; set;}   

    }
}
