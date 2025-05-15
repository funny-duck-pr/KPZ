using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class AddTextCommand : ICommand
    {
        private readonly LightElementNode _element;
        private readonly string _text;

        public AddTextCommand(LightElementNode element, string text)
        {
            _element = element;
            _text = text;
        }

        public void Execute()
        {
            _element.AddChild(new LightTextNode(_text));
        }
    }

}