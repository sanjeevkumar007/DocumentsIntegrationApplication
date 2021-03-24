using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string DocumentId { get; set; }
        public DateTimeOffset AddedOn { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
    }
}
