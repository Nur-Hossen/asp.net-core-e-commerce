using Entities.Declarations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class EntityBase : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}
