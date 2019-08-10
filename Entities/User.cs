using Entities.Declarations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User : EntityBase
    {
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
    }
}
