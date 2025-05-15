using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public bool IsBlockElement { get; }
        public bool SelfClosing { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName, bool isBlockElement, bool selfClosing = false)
        {
            TagName = tagName;
            IsBlockElement = isBlockElement;
            SelfClosing = selfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            OnCreated(); 
        }

        public void AddClass(string cssClass)
        {
            CssClasses.Add(cssClass);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public void RenderElement()
        {
            OnCreated();
            OnStylesApplied();
            OnClassListApplied();
            OnTextRendered();
            OnInserted();
        }

        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }

        public override string GetOuterHTML()
        {
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : string.Empty;
            string openTag = $"<{TagName}{classes}>";
            string closeTag = SelfClosing ? "/>" : $"</{TagName}>";

            string innerHTML = GetInnerHTML();
            return SelfClosing ? $"<{TagName}{classes} />" : $"{openTag}{innerHTML}{closeTag}";
        }

        public override string GetInnerHTML()
        {
            if (Children.Count == 0)
                return string.Empty;

            return string.Join("", Children.Select(child => child.GetOuterHTML()));
        }

        public IIterator CreateIterator()
        {
            return new LightElementNodeIterator(Children);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this); 
            foreach (var child in Children)
            {
                child.Accept(visitor); 
            }
        }
    }
}