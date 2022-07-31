﻿using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Customer: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TC { get; set; }

        public string Phone { get; set; }

        public string Gender { get; set; }

        public DateTime? Birthdate { get; set; }

        public string Password { get; set; }
        public string ImagePath { get; set; }


        /*public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch Branch { get; set; }

        public virtual Watch Watch { get; set; }

        public virtual Account Account { get; set; }
        */
    }
}
