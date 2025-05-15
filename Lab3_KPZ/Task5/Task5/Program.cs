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
        var div = new LifecycleDebugElement("div", isBlockElement: true);
        div.AddClass("container");

        var h1 = new LifecycleDebugElement("h1", isBlockElement: false);
        h1.AddChild(new LightTextNode("Welcome to LightHTML"));

        var p = new LifecycleDebugElement("p", isBlockElement: true);
        p.AddChild(new LightTextNode("This is a simple example of using LightHTML."));

        div.AddChild(h1);
        div.AddChild(p);

        div.RenderElement();
        h1.RenderElement();
        p.RenderElement();

        var styleVisitor = new StyleVisitor("highlight");

        div.Accept(styleVisitor);
        h1.Accept(styleVisitor);
        p.Accept(styleVisitor);

        Console.WriteLine(div.GetOuterHTML());

        var addClassCommand = new AddClassCommand(div, "additional-class");
        var addTextCommand = new AddTextCommand(p, "This text was added via command!");

        var invoker = new CommandInvoker();
        invoker.Invoke(addClassCommand);
        invoker.Invoke(addTextCommand);

        var iterator = div.CreateIterator();
        while (iterator.HasNext())
        {
            var child = iterator.Next();
            Console.WriteLine(child.GetOuterHTML());
        }
    }
}