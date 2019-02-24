using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.UIComponents.Menu;
using EnigmaMachine.Rotors;
using EnigmaMachine.Machine.Boards;

namespace EnigmaMachine.Machine.Decoding
{
    public class Decoder
    {
        public ScramblerBoardService ScramblerBoardService { get; set; }
        public PlugBoardService PlugBoardService { get; set; }

        public Decoder(ScramblerBoard scramblerBoard)
        {
            ScramblerBoardService = new ScramblerBoardService(scramblerBoard);
            PlugBoardService = new PlugBoardService();
        }
    }
}
