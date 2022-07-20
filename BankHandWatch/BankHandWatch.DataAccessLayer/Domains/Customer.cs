using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Customer: Person
    {
        public string Password { get; set; }

        public virtual Watch Watch { get; set; }

        public virtual Account Account { get; set; }

    }
}
