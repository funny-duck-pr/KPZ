using System;
using System.IO;
using Task6;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string filePath = "Resources/text.txt";

        string[] lines = File.ReadAllLines(filePath);

        var root = new LightElementNode("div", true);

        foreach (var line in lines)
        {
            LightNode element = null;

            if (line.Length > 0 && line[0] == ' ')
            {
                element = new LightElementNode("blockquote", true);
                ((LightElementNode)element).AddChild(new LightTextNode(line.Trim()));
            }
            else if (line.Length < 20)
            {
                element = new LightElementNode("h2", false);
                ((LightElementNode)element).AddChild(new LightTextNode(line));
            }
            else if (Array.IndexOf(lines, line) == 0)
            {
                element = new LightElementNode("h1", false);
                ((LightElementNode)element).AddChild(new LightTextNode(line));
            }
            else
            {
                element = new LightElementNode("p", true);
                ((LightElementNode)element).AddChild(new LightTextNode(line));
            }

            ((LightElementNode)root).AddChild(element);
        }
        long beforeMemory = GC.GetTotalMemory(true);
        Console.WriteLine("Пам'ять до побудови дерева: " + beforeMemory);

        Console.WriteLine(root.GetOuterHTML());

        long afterMemory = GC.GetTotalMemory(true);
        Console.WriteLine("Пам'ять після побудови дерева: " + afterMemory);

        Console.WriteLine($"Різниця в пам'яті: {afterMemory - beforeMemory} байт");
    }
}