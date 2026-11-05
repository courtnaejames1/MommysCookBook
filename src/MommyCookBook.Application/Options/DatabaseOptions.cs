using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Application.Options;

public class DatabaseOptions
{
    public const string SectionName = "Database";
        
    public required string ConnectionString { get; init; }
}

