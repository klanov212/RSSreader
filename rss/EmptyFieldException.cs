using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    [Serializable]
    public class EmptyFieldException : Exception
    {
        public string Field { get; }
        public EmptyFieldException() { }

        public EmptyFieldException(string message) : base(message) { }

        public EmptyFieldException(string message, Exception inner)
        : base(message, inner) { }

        public EmptyFieldException(string message, string field)
        : this(message)
        {
            Field = field;
        }
    }
}
