using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{
    public class StringEmpty : IValidater    {        public bool Validate(string data)        {            if (string.IsNullOrEmpty(data))            {                return false;            }            else            {                return true;            }        }

    }
}
