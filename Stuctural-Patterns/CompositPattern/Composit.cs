using System;
using System.Collections.Generic;
using System.Text;

namespace CompositPattern
{
    public class Composit : Component
    {
        private readonly List<Component> _components = new List<Component>();

        public void Add (Component component)
        {
            _components.Add(component);
        }

        public void Render()
        {
            foreach (var component in _components)
            {
                component.Render();
            }
        }

    }
}
