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

        public Enigma(DecodingProcessor processor, MenuService menuService, ReflectorSetup reflectorSetups,
            PlugBoardSetup plugsSetups, RotorsSetup rotorsSetup, UIService uiService, ScramblerBoardUI scramblerBoardUI)
        {
            Procesor = processor;
            MenuService = menuService;
            UIService = uiService;

            UIService.AddComponent(scramblerBoardUI);
           

            MenuService.AddComponent(reflectorSetups);
            MenuService.AddComponent(plugsSetups);
            MenuService.AddComponent(rotorsSetup);
            
            
        }
       
        public void Initialize()
        {
            UIService.PrintComponents();
            MenuService.PrintMenu();
        }
    }
}
