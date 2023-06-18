using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Domain.Core
{
    public abstract class BaseEntity
    {
        
        public BaseEntity() 
        {

        }

        public string? city { get; set; }
        public char? state { get; set; }
        public char? zip { get; set; }
    }
}
