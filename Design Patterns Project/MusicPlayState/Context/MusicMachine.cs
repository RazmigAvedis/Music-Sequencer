using Design_Patterns_Project.MusicPlayState.ConcreteStates;
using Design_Patterns_Project.MusicPlayState.StateBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.MusicPlayState.Context
{
    public class MusicMachine
    {
        private MusicPlayerState _state;
        

        public MusicMachine()
        {
            _state = new StopState();
        }

        public MusicMachine(MusicPlayerState state)
        {
            _state = state;
        }

        public void PressPlayButton(Button playButton)
        {
            _state.PlayButtonPressed(this,playButton);
        }

        public void PressStopButton()
        {
            _state.StopButtonPressed(this);
        }

        public MusicPlayerState State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
