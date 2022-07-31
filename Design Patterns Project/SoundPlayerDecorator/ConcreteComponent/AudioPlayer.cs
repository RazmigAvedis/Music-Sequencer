using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product;
using Design_Patterns_Project.Singleton;
using Design_Patterns_Project.SoundPlayerDecorator.ComponentBase;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.SoundPlayerDecorator.ConcreteComponent
{
    public class AudioPlayer : Player
    {
        public override void Play(int playPosition)
        {
            foreach (Channel channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values)
            {
                if (channel.GetType().ToString() == "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.automationChannel")
                {
                    if (channel.mainControls.On.Checked)//If the automation channel is on, notify observers of the automation clip to self invoke and get their volumes changed
                    {
                        var ch = (automationChannel)channel;
                        ch.Notify(float.Parse(((NumericUpDown)ch.channelTrack[playPosition]).Value.ToString()));//notify 
                    }
                }
            }
            
            foreach (Channel channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values)
            {
                if (channel.mainControls.On.Checked)
                {
                    switch (channel.GetType().ToString())
                    {
                        case "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.instrumentChannel":
                            if (((ComboBox)channel.channelTrack[playPosition]).SelectedItem != null && ((ComboBox)channel.channelTrack[playPosition]).SelectedItem.ToString() != "None" && ((ComboBox)channel.channelTrack[playPosition]).SelectedItem.ToString() != "")
                            {
                                try
                                {
                                    AudioFileReader audioFileReaderForInstrument = new AudioFileReader(channel.sampleData[((ComboBox)channel.channelTrack[playPosition]).SelectedItem.ToString()]);//get sample at playPosition
                                    audioFileReaderForInstrument.Volume = channel.mainControls.Volume.Volume;
                                    fileReaders.Add(audioFileReaderForInstrument);
                                }
                                catch { }
                            }
                            break;

                        case "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.drumsChannel":
                            var tempCheckBox = (CheckBox)channel.channelTrack[playPosition];
                            if (tempCheckBox.Checked && channel.sampleData!=null && channel.sampleData.Count!=0)
                            {
                                try
                                {
                                    AudioFileReader audioFileReaderForDrums = new AudioFileReader(channel.sampleData.FirstOrDefault().Value);//get sample at playPosition
                                    audioFileReaderForDrums.Volume = channel.mainControls.Volume.Volume;

                                    fileReaders.Add(audioFileReaderForDrums);
                                }
                                catch
                                { }
                            }
                            break;
                    }
                }

            }

            foreach(AudioFileReader audioFileReader in fileReaders)
            {
                audioFileReader.Volume = audioFileReader.Volume * ((fileReaders.Count) ^ (-1));
            }

            using (WaveMixerStream32 waveMixer = new WaveMixerStream32(fileReaders, true))
            {
                waveOutEvent.Init(waveMixer);


                try // Try to Play The sound, If an error has occured, don't stop the application, just skip the current
                {
                    waveOutEvent.Play();
                    fileReaders = new List<AudioFileReader>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PlayBack Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
