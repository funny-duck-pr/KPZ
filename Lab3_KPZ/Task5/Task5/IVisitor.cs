﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public interface IVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode textNode);
    }
}