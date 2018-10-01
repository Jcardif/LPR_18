using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPR_18_WIN_FORMS
{
    public partial class Form1 : Form
    {
        string vehicleFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectCarClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter="Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
                if(dialog.ShowDialog()==DialogResult.OK)
                {
                    vehicleFilePath = dialog.FileName;
                    vehiclePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    vehiclePictureBox.Image = new Bitmap(vehicleFilePath);
                }
            }
            catch
            {
                throw new ApplicationException("Image loading error....");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void ExtractNumberPlateClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicleFilePath))
                return;

            await ExecutePythonScript();

            lPpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lPpictureBox.Image = new Bitmap(@"D:\Projects\LPR_18\LPR_18\numberPlate.jpg");
        }

        private async Task ExecutePythonScript()
        {
            //var setup = Python.CreateRuntimeSetup(null);
            //var runtime = new ScriptRuntime(setup);
            //var engine = Python.GetEngine(runtime);
            //var source = engine.CreateScriptSourceFromFile(@"D:\Projects\LPR_18\LPR_18\Object_Detection\scripts\5. Test.py");
            //var scope = engine.CreateScope();
            //var argv = new List<string> { vehicleFilePath };
            //engine.GetSysModule().SetVariable("argv", argv);
            //await source.Execute(scope);
        }
    }
}
