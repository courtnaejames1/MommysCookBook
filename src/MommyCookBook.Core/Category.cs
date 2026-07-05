using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Core
{
    public sealed record Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
    }
}
