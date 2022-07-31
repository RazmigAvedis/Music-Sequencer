using Design_Patterns_Project.SamplesAdapter.Models;
using Design_Patterns_Project.SamplesAdapter.Target;
using System;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Design_Patterns_Project.SamplesAdapter.Adapter
{
    public class InstrumentGetSamplesAdapter: IGetSamplesAdapter
    {
        readonly sampleGroup InstrumentSamples=new sampleGroup();

        public sampleGroup GetSamples()
        {
            return InstrumentSamples;
        }

        public void SetSamples()
        {
            using (CommonOpenFileDialog folderBrowserDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select An Instrument Folder"
            }
            )
            {

                if (folderBrowserDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    sampleGroup sampleGroup = new sampleGroup();
                    this.InstrumentSamples.Add("Instrument Folder Name", Path.GetFileName(folderBrowserDialog.FileName));
                    foreach (var file in Directory.GetFiles(folderBrowserDialog.FileName))
                    {
                        if (Path.GetExtension(file) == ".wav" || Path.GetExtension(file) == ".mp3" || Path.GetExtension(file) == ".aif")
                            try
                            {
                                this.InstrumentSamples.Add(Path.GetFileNameWithoutExtension(file), file);
                            }
                            catch (ArgumentException) { }

                    }

                }

            }
        }

    }
}
