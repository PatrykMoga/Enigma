using EnigmaMachine.Machine.Decoding;
using EnigmaMachine.Setup;
using EnigmaMachine.UIComponents.Menu;
using EnigmaMachine.UIComponents.TopBar;

namespace EnigmaMachine.Machine
{
    public class Enigma 
    {        
        public DecoderService DecoderService { get; }
        public SetupService SetupService { get; }

        public MenuService Menu { get; }
        public TopBarService TopBar { get; }

        public Enigma()
        {
            SetupService = new SetupService();
            DecoderService = new DecoderService(SetupService.ScramblerBoard);

            TopBar = new TopBarService();
            TopBar.AddComponent(DecoderService.Decoder.ScramblerBoardService);

            Menu = new MenuService();
            Menu.AddComponent(DecoderService);
            Menu.AddComponent(SetupService);
           
        }
      
        public void Initialize()
        {
            while (true)
            {              
                TopBar.ShowBars();
                Menu.PrintMenu();               
            }              
        }        
    }
}
