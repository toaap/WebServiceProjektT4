using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProjektWindowsFormApp.Utils
{
    public class ErrorException : Exception
    {
        public ErrorException() { }

        public string errorMessage { get; set; }

        public ErrorException(string message)
        {
            errorMessage = message;

        }


    }
}
