namespace SADFM.Infrastructure.Persistence.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountType")]
    public partial class AccountType
    {
        private AccountType() { }

        public AccountType(string name)
        {
            this.Name = name;
        }

        public Guid AccountTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
