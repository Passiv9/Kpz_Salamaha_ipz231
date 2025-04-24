using System;
using System.Collections.Generic;

namespace LightHTML
{
    public class FlyweightHTMLNode
    {
        private static readonly Dictionary<string, LightElementNode> _nodes = new Dictionary<string, LightElementNode>();

        public static LightElementNode GetNode(string tagName, string displayType = "inline", bool isSelfClosing = false)
        {
            if (!_nodes.ContainsKey(tagName))
            {
                _nodes[tagName] = new LightElementNode(tagName, displayType, isSelfClosing);
            }
            return _nodes[tagName];
        }

        public static int GetNodeCount()
        {
            return _nodes.Count;
        }

        public static long GetFlyweightMemoryUsage()
        {
            long totalMemory = 0;
            foreach (var node in _nodes.Values)
            {
                totalMemory += node.EstimateMemoryUsage();
            }
            return totalMemory;
        }
    }

    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public bool IsSelfClosing { get; }
        private List<LightNode> _children = new List<LightNode>();

        public LightElementNode(string tagName, string displayType, bool isSelfClosing)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public override long EstimateMemoryUsage()
        {
            long size = sizeof(int) * _children.Count;
            foreach (var child in _children)
            {
                size += child.EstimateMemoryUsage();
            }
            return size;
        }
    }

    public class LightTextNode : LightNode
    {
        public string Content { get; }

        public LightTextNode(string content)
        {
            Content = content;
        }

        public override long EstimateMemoryUsage()
        {
            return Content.Length * sizeof(char);
        }
    }

    public abstract class LightNode
    {
        public abstract long EstimateMemoryUsage();
    }
}
