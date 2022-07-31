using Design_Patterns_Project.Builder.ConcreteBuilder;
using Design_Patterns_Project.Builder.Director;
using Design_Patterns_Project.Singleton;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Patterns_Project.UIObserver_Remove_Maybe_.ConcreteObserver;
using NAudio.CoreAudioApi;
using NAudio.Gui;
using Design_Patterns_Project.SoundPlayerDecorator.ConcreteComponent;
using Design_Patterns_Project.SoundPlayerDecorator.ConcreteDecorator;
using Design_Patterns_Project.SoundPlayerDecorator.ComponentBase;
using Design_Patterns_Project.ChainOfResponsibility.ConcreteHandlers;

namespace Design_Patterns_Project
{
    public partial class Music_Sequencer : Form
    {
        public MusicSequencerForm form;
        
        public Music_Sequencer()
        {
            InitializeComponent();
        }

        private void Music_Sequencer_Load(object sender, EventArgs e)
        {

            var check1 = new IconDirectoryCheck();
            var check2 = new SoundDirectoryCheck();
            var check3 = new blackImageChecker();
            var check4 = new AutomationIconChecker();
            var check5 = new DrumsIconChecker();
            var check6 = new InstrumentIconChecker();
            var check7 = new PlayIconChecker();
            var check8 = new PauseIconChecker();
            var check9 = new StopIconChecker();
            var check10 = new PlusIconChecker();
            var check11 = new DeleteIconChecker();
            var check12 = new UndoIconChecker();
            var check13 = new MainIconChecker();
            var check14 = new MetronomeSoundChecker();

            check1.SetSuccessor(check2);
            check2.SetSuccessor(check3);
            check3.SetSuccessor(check4);
            check4.SetSuccessor(check5);
            check5.SetSuccessor(check6);
            check6.SetSuccessor(check7);
            check7.SetSuccessor(check8);
            check8.SetSuccessor(check9);
            check9.SetSuccessor(check10);
            check10.SetSuccessor(check11);
            check11.SetSuccessor(check12);
            check12.SetSuccessor(check13);
            check13.SetSuccessor(check14);

            bool result = check1.Check(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources"));

            if (!result)
            {
                MessageBox.Show("Some Resources Could Not Be Found, You Might Encounter Missing Sounds or Images", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            form = new MusicSequencerForm(this);

            ChannelList.GetChannelListObject()._ChannelList.Register(form);

            new ChannelCreator(new automationChannelBuilder()).CreateChannel();
            new ChannelCreator(new drumChannelBuilder()).CreateChannel();
            new ChannelCreator(new instrumentChannelBuilder()).CreateChannel();
            
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            Stop_Button.ForeColor = DefaultBackColor; // Set stop button to default

            MusicState.GetMusicState().musicMachine.PressPlayButton(sender as Button);

            if (MusicState.GetMusicState().musicMachine.State.GetType().Name == "PlayState")
            {
                audioIntervalTimer.Start();

                int currentTick = TrackTicks.GetTrackTicks()._TrackTicks.Current.GetTick();

                progressBar.Location = new Point(310 + currentTick * 110, progressBar.Location.Y);

                Player audioPlayer = new AudioPlayer();

                if (checkBox_Metronome.Checked) audioPlayer = new Metronome(audioPlayer);

                audioPlayer.Play(currentTick);
            }
            if (MusicState.GetMusicState().musicMachine.State.GetType().Name == "PauseState") audioIntervalTimer.Stop();
            
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            Play_Button.ForeColor = DefaultBackColor;
            Play_Button.BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Play.png"));
            Stop_Button.ForeColor = Color.Red;

            MusicState.GetMusicState().musicMachine.PressStopButton();

            TrackTicks.GetTrackTicks()._TrackTicks.MoveFirst();
            if (MusicState.GetMusicState().musicMachine.State.GetType().Name == "StopState")  audioIntervalTimer.Stop();

            progressBar.Location = new Point(310, progressBar.Location.Y);
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        public void button_AddChannel_Click(object sender, EventArgs e)
        {
            ChannelChoice channelChoice = new ChannelChoice();

            DialogResult dialogResult = channelChoice.ShowDialog();

            if(channelChoice.DialogResult==DialogResult.OK)
            {
                switch(channelChoice.Tag)
                {
                    case ChannelType.Automation:
                        new ChannelCreator(new automationChannelBuilder()).CreateChannel();
                        break;
                    case ChannelType.Drum:
                        new ChannelCreator(new drumChannelBuilder()).CreateChannel();
                        break;
                    case ChannelType.Instrument:
                        new ChannelCreator(new instrumentChannelBuilder()).CreateChannel();
                        break;
                }
            }
        }

        public Panel GetMainPanel()
        {
            return panel_TrackControls;
        }

        private void panel_TrackControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void audioIntervalTimer_Tick(object sender, EventArgs e)
        {
            TrackTicks.GetTrackTicks()._TrackTicks.MoveNext();

            int currentTick = TrackTicks.GetTrackTicks()._TrackTicks.Current.GetTick();

            progressBar.Location = new Point(310 + currentTick * 110, progressBar.Location.Y);

            Player audioPlayer = new AudioPlayer();

            if (checkBox_Metronome.Checked) audioPlayer = new Metronome(audioPlayer);

            audioPlayer.Play(currentTick);

        }

        private void label_Tempo_Click(object sender, EventArgs e)
        {

        }

        private void pot_Tempo_Load(object sender, EventArgs e)
        {

        }

        private void pot_Tempo_ValueChanged(object sender, EventArgs e)
        {
            audioIntervalTimer.Interval =(1000*60) / (int)pot_Tempo.Value;
            Tempo.Text = pot_Tempo.Value.ToString();
        }

        private void BPM_Click(object sender, EventArgs e)
        {

        }
    }


    public enum ChannelType
    {
        Automation, Drum, Instrument
    }
}
