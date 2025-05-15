using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

class Program
{
    static void Main()
    {
        var div = new LightElementNode("div", isBlockElement: true);
        div.AddClass("container");

        var h1 = new LightElementNode("h1", isBlockElement: false);
        h1.AddChild(new LightTextNode("Welcome to LightHTML"));

        var p = new LightElementNode("p", isBlockElement: true);
        p.AddChild(new LightTextNode("This is a simple example of using LightHTML."));

        div.AddChild(h1);
        div.AddChild(p);

        Console.WriteLine(div.GetOuterHTML());
    }
}