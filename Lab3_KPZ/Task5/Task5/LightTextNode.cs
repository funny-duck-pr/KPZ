﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LightTextNode : LightNode
    {
        public string Text { get; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string GetOuterHTML()
        {
            return Text;
        }

        public override string GetInnerHTML()
        {
            return Text;
        }
    }

}