using System;
using System.Collections.Generic;

namespace Task6
{
    public static class TagFactory
    {
        private static readonly Dictionary<string, LightElementNode> tagPool = new Dictionary<string, LightElementNode>();

        public static LightElementNode GetTag(string tagName)
        {
            if (!tagPool.ContainsKey(tagName))
            {
                tagPool[tagName] = new LightElementNode(tagName, true);
            }

            return tagPool[tagName];
        }
    }
}