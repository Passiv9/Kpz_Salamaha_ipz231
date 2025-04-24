using System;

namespace LightHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            var div = new LightElementNode("div", "block");
            div.AddClass("container");

            var h1 = new LightElementNode("h1", "block");
            h1.AddChild(new LightTextNode("Welcome to LightHTML"));

            var ul = new LightElementNode("ul", "block");
            var li1 = new LightElementNode("li", "block");
            li1.AddChild(new LightTextNode("Item 1"));
            var li2 = new LightElementNode("li", "block");
            li2.AddChild(new LightTextNode("Item 2"));

            ul.AddChild(li1);
            ul.AddChild(li2);

            div.AddChild(ul);

            
            div.AddEventListener("click", () => Console.WriteLine("Div was clicked!"));
            li1.AddEventListener("mouseover", () => Console.WriteLine("Mouse is over Item 1"));

           
            Console.WriteLine(div.GetOuterHTML());

           
            div.DispatchEvent("click");
            li1.DispatchEvent("mouseover");
        }
    }
}
