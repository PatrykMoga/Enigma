using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.UIComponents.TopBar
{
    public class TopBarService
    {
        public List<TopBarItem> TopBarComponents { get; set; }

        public TopBarService()
        {
            TopBarComponents = new List<TopBarItem>();
        }

        public void ShowBars()
        {
            foreach (var bar in TopBarComponents)
            {
                bar.Action();
            }
        }

        public void AddComponent(ITopBarComponent component)
        {
            foreach (var bar in component.TopBarComponents)
            {
                TopBarComponents.Add(bar);
            }
        }
    }
}
