using Design_Patterns_Project.MusicPlayState.Context;
using Design_Patterns_Project.MusicPlayState.StateBase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.MusicPlayState.ConcreteStates
{
    public class PauseState : MusicPlayerState
    {
        public PauseState(Button playButton)
        {
            playButton.BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Play.png"));
            playButton.ForeColor = Color.Red;
        }

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
