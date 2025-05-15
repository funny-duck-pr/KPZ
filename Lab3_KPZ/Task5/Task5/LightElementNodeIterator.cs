using System;
using System.Collections.Generic;

namespace Task5
{
    public class LightElementNodeIterator : IIterator
    {
        private readonly List<LightNode> _children;
        private int _currentIndex = 0;

        public LightElementNodeIterator(List<LightNode> children)
        {
            _children = children;
        }

        public bool HasNext()
        {
            return _currentIndex < _children.Count;
        }

        public LightNode Next()
        {
            if (HasNext())
            {
                return _children[_currentIndex++];
            }
            else
            {
                throw new InvalidOperationException("No more elements.");
            }
        }
    }
}