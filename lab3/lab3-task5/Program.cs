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

            var imageUrl = new LightImageNode("https://pustunchik.ua/uploads/school/cache/5e23cb2f903d5740ed1ba0f5497d68b8.jpg");
            imageUrl.LoadImage();
            div.AddChild(imageUrl);

            var imageFile = new LightImageNode("C:\\path\\to\\local\\image.jpg");
            imageFile.LoadImage();
            div.AddChild(imageFile);

            Console.WriteLine(div.GetOuterHTML());
        }
    }
}
