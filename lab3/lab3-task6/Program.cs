using System;
using System.IO;
using System.Collections.Generic;
using LightHTML;

namespace LightHTMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "pg1513.txt";
            string[] bookText = File.ReadAllLines(filePath);

            List<LightNode> htmlNodes = new List<LightNode>();
            bool isFirstLine = true;

            foreach (string line in bookText)
            {
                LightNode node;
                if (isFirstLine)
                {
                    node = CreateElement("h1", line);
                    isFirstLine = false;
                }
                else if (line.StartsWith(" "))
                {
                    node = CreateElement("blockquote", line);
                }
                else if (line.Length < 20)
                {
                    node = CreateElement("h2", line);
                }
                else
                {
                    node = CreateElement("p", line);
                }

                htmlNodes.Add(node);
            }

            Console.WriteLine($"\nУнікальних елементів HTML: {FlyweightHTMLNode.GetNodeCount()}");

            long totalMemoryBeforeOptimization = System.GC.GetTotalMemory(false);
            Console.WriteLine($"\nЗагальна пам'ять до оптимізації (використовувана всіма елементами): {totalMemoryBeforeOptimization} байт");

            long flyweightMemoryUsage = FlyweightHTMLNode.GetFlyweightMemoryUsage();
            Console.WriteLine($"\nОцінка пам'яті, використаної легковаговими елементами: {flyweightMemoryUsage} байт");

            long totalMemoryAfterOptimization = System.GC.GetTotalMemory(false);
            Console.WriteLine($"\nЗагальна пам'ять після оптимізації: {totalMemoryAfterOptimization} байт");
        }

        static LightNode CreateElement(string tagName, string content)
        {
            var element = FlyweightHTMLNode.GetNode(tagName);
            var textNode = new LightTextNode(content);
            element.AddChild(textNode);
            return element;
        }
    }
}
