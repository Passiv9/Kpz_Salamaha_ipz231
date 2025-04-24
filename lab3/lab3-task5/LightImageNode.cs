using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace LightHTML
{
    public class LightImageNode : LightElementNode
    {
        public string Href { get; set; }

        public LightImageNode(string href)
            : base("img", "inline", true) 
        {
            Href = href;
        }

        public void LoadImage()
        {
            if (Uri.IsWellFormedUriString(Href, UriKind.Absolute))
            {
                Console.WriteLine($"Завантаження зображення з URL: {Href}");
                DownloadImageFromUrl();
            }
            else if (File.Exists(Href))
            {
                Console.WriteLine($"Завантаження зображення з локальної файлової системи: {Href}");
            }
            else
            {
                Console.WriteLine("Не знайдено зображення за зазначеним шляхом.");
            }
        }

        private void DownloadImageFromUrl()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(Href, Path.GetFileName(Href));
                Console.WriteLine("Зображення завантажено успішно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка завантаження зображення: {ex.Message}");
            }
        }

        public override string GetOuterHTML()
        {
            return $"<img src=\"{Href}\" />";
        }

        public override string GetInnerHTML()
        {
            return string.Empty; 
        }
    }
}
