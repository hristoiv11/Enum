using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    [Flags]
    //we need Flags here to say that this is a byte enum
    internal enum Rights
    {
        // 1 . we have to have a none option 
        None = 0,
        READABLE = 1,
        WRITABLE = 2,
        EXECUTABLE = 4,
        PRIVILEGED = 8,


    }
}

/*
 1) enum =all caps 
 2 ) {Flags}
 3) None at the begging when writing 
 4) when you give a value it will be 0(none), 1, 2, 4, 8, 16 and so on 
 */
