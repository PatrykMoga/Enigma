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
                new MenuItem(1,"Welcome",PrintWelcomeMsg)
            };
            this.SetupService = new SetupService();
            this.Decoder = new DecodingService(SetupService.EnigmaService);
        }

        public void Initialize()
        {
            foreach (var item in MenuItems)
            {
                Console.WriteLine($"{item.Key} {item.Name}");
            }
            Console.WriteLine(Decoder.Decode("BASIA KUDZIA"));
        }

        private void PrintWelcomeMsg()
        {
            Console.WriteLine("Welcome to enigma macine bla bla bal fuck you");
        }
    }
}
