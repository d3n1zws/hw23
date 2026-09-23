using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21.exceptions;

public class NotFoundException: Exception
{
    public NotFoundException(string Message): base(Message)
    {
        
    }
}
