using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.Exceptions
{
     public  class AuthorException : Exception
    {
        public AuthorException(string message) : base(message)
        { 

        }
    }
}
