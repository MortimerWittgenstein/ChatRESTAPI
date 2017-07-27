using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChatRESTAPI.Database
{
    [Table("User")]
    public class User
    {
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("FirstName", TypeName = "nvarchar(max)")]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "nvarchar(max)")]
        public string LastName { get; set; }

        [Column("Birthdate", TypeName = "date")]
        public DateTime Birthdate { get; set; }

        [Column("Email", TypeName = "nvarchar(max)")]
        public string Email { get; set; }

        [Column("Company", TypeName = "nvarchar(max)")]
        public string Company { get; set; }
    }
}
