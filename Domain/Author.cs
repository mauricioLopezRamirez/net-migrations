using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_migrations.Domain
{

    public class Author{
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
    }

}