using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Machine
{
    public class ScramblerBoardService
    {
        public ScramblerBoard ScramblerBoard { get; }

        public ScramblerBoardService(ScramblerBoard scramblerBoard)
        {
            ScramblerBoard = scramblerBoard;
        }

        public void LoadRotors(RotorProcessor processor1, RotorProcessor processor2, RotorProcessor processor3)
        {
            ScramblerBoard.Processor1 = processor1;
            ScramblerBoard.Processor2 = processor2;
            ScramblerBoard.Processor3 = processor3;
        }
    }
}
