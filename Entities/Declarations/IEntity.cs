using System;

namespace Entities.Declarations
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime? CreatedAt { get; set; }
    }
}
