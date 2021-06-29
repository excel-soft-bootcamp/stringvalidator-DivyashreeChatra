using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{
        public class StringValidator
        {
            IValidater _validate;
            public StringValidator(IValidater stringValue)
            {
                this._validate = stringValue;
            }
            public void ValidatingString(string dataValue)
            {
                _validate.Validate(dataValue);
            }
        }
 }
