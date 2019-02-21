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
    public class Enigma //: IMenuComponent
    {
        public DecodingService Decoder { get; set; }
        public SetupService SetupService { get; }

        public MenuService Menu { get; }

        public Enigma()
        {
            SetupService = new SetupService();
            Decoder = new DecodingService(SetupService.ScramblerBoard);

            Menu = new MenuService();
            Menu.AddComponent(Decoder);
            Menu.AddComponent(SetupService);
           
        }
      
        public void Initialize()
        {
            while (true)
            {
                Console.Clear();
                var reflector = $"{Decoder.Board.Reflector.Name}";
                var rotor1 = $"{Decoder.Board.Rotor1.Name}: {Decoder.Board.Rotor1.Position}";
                var rotor2 = $"{Decoder.Board.Rotor2.Name}: {Decoder.Board.Rotor2.Position}";
                var rotor3 = $"{Decoder.Board.Rotor3.Name}: {Decoder.Board.Rotor3.Position}";

                Console.WriteLine("===================================================");
                Console.WriteLine($"{reflector} | {rotor1} | {rotor2} | {rotor3} ");
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Menu.PrintMenu();
               
            }              
        }        
    }
}
