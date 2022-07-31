using Design_Patterns_Project.SamplesAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Design_Patterns_Project.SamplesAdapter.Target
{
    public interface IGetSamplesAdapter
    {
        void SetSamples();
        sampleGroup GetSamples();
    }
}
