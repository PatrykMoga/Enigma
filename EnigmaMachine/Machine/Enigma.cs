using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;
using EnigmaMachine.Setup;
using EnigmaMachine.MenuComponents;

namespace EnigmaMachine.Machine
{
    public class Enigma : IMenuComponent
    {
        public DecodingService Decoder { get; set; }
        public SetupService SetupService { get; }

        public MenuItem[] MenuItems { get; }

        public Enigma()
        {
            MenuItems = new[]
            {
                new MenuItem(1,"Decode message",PrintWelcomeMsg),
                new MenuItem(2,"Setup machine",PrintWelcomeMsg),             
            };
            SetupService = new SetupService();
            Decoder = new DecodingService(SetupService.ScramblerBoard);
        }

        public void Initialize()
        {
            foreach (var item in MenuItems)
            {
                Console.WriteLine($"{item.Key} {item.Name}");
           }           
        }

        private void PrintWelcomeMsg()
        {
            // 1 zasada złamana
            Console.WriteLine("Welcome to enigma macine bla bla bal fuck you");
        }
    }
}
