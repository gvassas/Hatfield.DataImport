﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hatfield.DataImport.ValueParsers
{
    public class NullableDateTimeValueParser : IValueParser
    {
        public virtual object Parse(object value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                try
                {
                    return (DateTime?)(Convert.ToDateTime(value));
                }
                catch (Exception)
                {
                    throw new FormatException("Can not parse value ("+value+") to datetime");
                }
            }

        }
    }
}
