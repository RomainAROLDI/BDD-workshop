using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.CustomExceptions
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string message) : base(message) { }
    }
}
