using Design_Patterns_Project.MusicPlayState.Context;
using Design_Patterns_Project.MusicPlayState.StateBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.MusicPlayState.ConcreteStates
{
    public class StopState : MusicPlayerState
    {
        public StopState() { }


        public override void PlayButtonPressed(MusicMachine musicMachine,Button playButton)
        {
            musicMachine.State = new PlayState(playButton);
        }

        public override void StopButtonPressed(MusicMachine musicMachine)
        {
            musicMachine.State = new StopState();
        }
    }
}
