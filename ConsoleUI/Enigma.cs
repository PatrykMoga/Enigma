using ConsoleUI.Menu;
using ConsoleUI.Setups;
using ConsoleUI.UIComponents;
using EnigmaLibrary;
using System;

namespace ConsoleUI
{
    public class Enigma
    {
        public DecodingProcessor Procesor { get; }
        public UIService UIService { get; }
        public MenuService MenuService { get; }

        public Enigma(DecodingProcessor processor, MenuService menuService,
            UIService uiService)
        {
            Procesor = processor;
            MenuService = menuService;
            UIService = uiService;
        }
       
        public void Initialize()
        {
            while (true)
            {
                UIService.PrintComponents();
                MenuService.PrintMenu();
            }           
        }
    }
}
