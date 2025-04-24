using System;
using System.Collections.Generic;
using System.Text;

namespace LightHTML
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; } 
        public bool IsSelfClosing { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, string displayType = "inline", bool isSelfClosing = false)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public override string GetOuterHTML()
        {
            StringBuilder outerHTML = new StringBuilder();
            outerHTML.Append("<").Append(TagName);

            if (CssClasses.Count > 0)
            {
                outerHTML.Append(" class=\"").Append(string.Join(" ", CssClasses)).Append("\"");
            }

            if (IsSelfClosing)
            {
                outerHTML.Append(" />");
            }
            else
            {
                outerHTML.Append(">");

                outerHTML.Append(GetInnerHTML());

                outerHTML.Append("</").Append(TagName).Append(">");
            }

            return outerHTML.ToString();
        }

        public override string GetInnerHTML()
        {
            StringBuilder innerHTML = new StringBuilder();
            foreach (var child in Children)
            {
                innerHTML.Append(child.GetOuterHTML());
            }
            return innerHTML.ToString();
        }

        public void AddClass(string cssClass)
        {
            CssClasses.Add(cssClass);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }
    }
}
