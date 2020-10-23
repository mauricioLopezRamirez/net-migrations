using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_migrations.Domain
{

    public class Book{
        public Guid Id {get; set;}
        public string Name {get; set;}

        // public Author Author {get; set;}
        // private Guid _idAuthor;
    }

}