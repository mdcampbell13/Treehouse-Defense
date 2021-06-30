using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse_Defense
{
    class Treehouse_DefenseException : System.Exception
    {
        public Treehouse_DefenseException()
        {
        }

        public Treehouse_DefenseException(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : Treehouse_DefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
