using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LoggingService
    {    
            public string LogAction(string action)
            {
                var logText = "Action: " + action;
                Console.WriteLine(logText);

                return logText;
            }   
    }
}