using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using BankHandWatch.DataAccessLayer.Domains.SysDomains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Location : BaseEntityNoIdentity
    {
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }


        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; }

        public virtual Branch Branch { get; set; }


        public string Street { get; set; }


        public string PostalCode { get; set; }
    }
}
