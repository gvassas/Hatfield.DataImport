﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hatfield.DataImport
{
    public interface IValueAssigner
    {
        void AssignValue(object model, string path, object value, Type type);
    }
}
