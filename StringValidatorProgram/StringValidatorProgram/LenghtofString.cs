using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{ 
   class LenghtofString : IValidater    {        public bool Validate(string data)        {            if (data.Length > 8)            {                return false;            }            return true;

        }    }
}
