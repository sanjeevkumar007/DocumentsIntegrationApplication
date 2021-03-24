using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Domain.Entities
{
    public class Document:BaseEntity
    {
        public string DocumentName { get; set; }
        public string PersonName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string DocumentImageUrl { get; set; }

    }
}
