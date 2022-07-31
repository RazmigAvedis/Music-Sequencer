using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Singleton;
using Design_Patterns_Project;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Gui;

namespace Design_Patterns_Project.SoundPlayChainOfResponsibility.ConcreteHandlers
{
    public class ProcessPlayAudio : HandlerBase.SoundPlayer
    {
        public AsioOut waveOutEvent = new AsioOut("ASIO4ALL v2");
        public List<AudioFileReader> fileReaders = new List<AudioFileReader>();
        public WaveMixerStream32 waveMixer;

        public override void Process(int playPosition)
        {
            foreach (Channel channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values)
            {
                if (channel.mainControls.On.Checked)
                {
                    string x = channel.GetType().ToString();

                    switch (x)
                    {
                        case "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.instrumentChannel":
                            var tempComboBox = (ComboBox)channel.channelTrack[playPosition];

                            if (tempComboBox.SelectedText != "")
                            {
                                try
                                {
                                    AudioFileReader audioFileReaderForInstrument = new AudioFileReader(channel.sampleData[tempComboBox.SelectedText]);//get sample at playPosition
                                    audioFileReaderForInstrument.Volume = channel.mainControls.Volume.Volume;
                                    fileReaders.Add(audioFileReaderForInstrument);
                                }
                                catch { }
                            }
                            break;

                        case "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.drumsChannel":
                            var tempCheckBox = (CheckBox)channel.channelTrack[playPosition];
                            if (tempCheckBox.Checked)
                            {
                                try
                                {
                                    AudioFileReader audioFileReaderForDrums = new AudioFileReader(channel.sampleData.FirstOrDefault().Value);//get sample at playPosition
                                    audioFileReaderForDrums.Volume = channel.mainControls.Volume.Volume;
                                
                                    fileReaders.Add(audioFileReaderForDrums);
                                }
                                catch { }
                            }
                            break;
                    }
                }

            }

            waveMixer = new WaveMixerStream32(fileReaders,true);// mix the sounds

           
            waveOutEvent.Init(waveMixer);

            waveOutEvent.Play();
        }
    }
}
