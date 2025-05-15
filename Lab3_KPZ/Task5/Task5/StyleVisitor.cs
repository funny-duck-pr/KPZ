using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class StyleVisitor : IVisitor
    {
        private readonly string _style;

        public StyleVisitor(string style)
        {
            _style = style;
        }

        public void Visit(LightElementNode element)
        {
            element.AddClass($"style-{_style}");
        }

        public void Visit(LightTextNode textNode)
        {
            
        }
    }
}