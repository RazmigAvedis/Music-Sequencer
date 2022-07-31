using Design_Patterns_Project.SamplesAdapter.Target;
using Design_Patterns_Project.SamplesAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Design_Patterns_Project.SamplesAdapter.Adapter
{
    class DrumsGetSamplesAdapter : IGetSamplesAdapter
    {
        readonly sampleGroup DrumSample=new sampleGroup();

        public sampleGroup GetSamples()
        {
            return DrumSample;
        }

        public void SetSamples()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Drum Sample";
                openFileDialog.Filter = "Audio Files |*.wav;*.mp3";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DrumSample.Add(Path.GetFileNameWithoutExtension(openFileDialog.FileName), openFileDialog.FileName);
                }
            }
        }


    }
}

