using System;

namespace Task5
{
    public class LifecycleDebugElement : LightElementNode
    {
        public LifecycleDebugElement(string tagName, bool isBlockElement, bool selfClosing = false)
            : base(tagName, isBlockElement, selfClosing)
        {
        }

        protected override void OnCreated()
        {
            Console.WriteLine($"[{TagName}] Created");
        }

        protected override void OnInserted()
        {
            Console.WriteLine($"[{TagName}] Inserted into DOM");
        }

        protected override void OnStylesApplied()
        {
            Console.WriteLine($"[{TagName}] Styles applied");
        }

        protected override void OnClassListApplied()
        {
            Console.WriteLine($"[{TagName}] Class list applied: {string.Join(", ", CssClasses)}");
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine($"[{TagName}] Text rendered");
        }
    }
}