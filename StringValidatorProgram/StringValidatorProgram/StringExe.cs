﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{
    public class StringExe : IValidater    {        public bool Validate(string data)        {            if (data.StartsWith("ex"))            {                return true;            }            else                return false;        }    }
}
