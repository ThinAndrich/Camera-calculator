using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera_calculator
{
    public partial class Form2 : Form
    {
        // List<Tuple<double, string>> sensorTypes = new List<Tuple<double, string>>();
        Dictionary<string, double> sensorTypes = new Dictionary<string, double>();

        private enum Inputs
        {
            SensorType,
            AspectRatio,
            CameraLensMount,
            FocalReducer,
            FocalLength,
            SqueezeFactor,
            VerticalEFL,
            HorizontalEFL,
            VideoAspectRatio,
        }

        private void InputsToString(Inputs source, List<Inputs> defaulted, List<Inputs> errored)
        {            
            string result = "When calculating " + source.ToString() + ", there were some unset values.\n";

            if (defaulted.Count != 0)
            {
                result += "These values were set to their default:\n";
                foreach (Inputs input in defaulted)
                {
                    result += "    " + input.ToString();
                }
                result += "\n";
            }

            if (errored.Count != 0)
            {
                result += "These values need to be filled:\n";
                foreach (Inputs input in errored)
                {
                    result += "    " + input.ToString();
                }
                result += "\n";
            }

            this.errorMSG.Text = result;
        }

        public Form2()
        {
            InitializeComponent();
            List<Inputs> default_shit = new List<Inputs>();
            default_shit.Add(Inputs.SensorType);

            List<Inputs> error_shit = new List<Inputs>();
            error_shit.Add(Inputs.AspectRatio);

            this.InputsToString(Inputs.FocalReducer, default_shit, error_shit);

            // sensorTypeButton_Click
            StreamReader vnos = new StreamReader("..\\..\\..\\sensorCropFactor.txt");
            while (!vnos.EndOfStream)
            {
                string line = vnos.ReadLine();
                string[] number_name = line.Split(' ');
                double cropFactor;

                if (!Double.TryParse(number_name[0], out cropFactor))
                {
                    return;
                }

                string name = "";
                for (int i = 1; i < number_name.Length; i++)
                {
                    name += number_name[i] + " ";
                }

                // Tuple<double, string> tuple = new Tuple<double, string>(cropFactor, name);
                // sensorTypes.Add(tuple);
                sensorTypes[name] = cropFactor;
            }

            vnos.Close();

            // dodaj v sensorTypeInput
            foreach(KeyValuePair<string, double> entry in this.sensorTypes)
            {
                this.sensorTypeInput.Items.Add(entry.Key);
            }

            this.sensorTypeInput.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void focalLengthButton_Click(object sender, EventArgs e)
        {
            // this.focalLengthInput;
        }

        private void squeezeFactorButton_Click(object sender, EventArgs e)
        {

        }

        private void focalReducerButton_Click(object sender, EventArgs e)
        {

        }

        private void sensorTypeButton_Click(object sender, EventArgs e)
        {
               
        }

        private void sensorAspectRatioButton_Click(object sender, EventArgs e)
        {

        }

        private void cameraLensMountButton_Click(object sender, EventArgs e)
        {

        }

        private enum InputStatus
        {
            Valid,
            Default,
            Fatal
        }

        private void verticalEFLButton_Click(object sender, EventArgs e)
        {
            double focalLength = 0;
            double focalReducer = 1;
            InputStatus input_status = InputStatus.Valid;

            if (!Double.TryParse(this.focalLengthInput.Text, out focalLength))
            {
                input_status = InputStatus.Fatal; // exit
            }
            if (!Double.TryParse(this.focalReducerInput.Text, out focalReducer))
            {
                input_status = InputStatus.Default;
                focalReducer = 1; // default
                this.focalReducerInput.Text = focalReducer.ToString();
            }

            if (input_status != InputStatus.Valid)
            {
                List<Inputs> defaulted = new List<Inputs>();
                defaulted.Add(Inputs.FocalReducer);

                List<Inputs> errored = new List<Inputs>();
                errored.Add(Inputs.FocalLength);

                this.InputsToString(Inputs.VerticalEFL, defaulted, errored);

                if (errored.Count != 0)
                    return;
            }
            else {
                this.errorMSG.Text = "";
            }

            double cropFactor = this.sensorTypes[this.sensorTypeInput.Text];
            this.verticalEFLInput.Text = (focalLength * focalReducer * cropFactor).ToString();
        }

        private void horizontalEFLButton_Click(object sender, EventArgs e)
        {
            double focalLength = 0;
            double focalReducer = 1;
            double squeezeFactor = 1;

            if (!Double.TryParse(this.focalLengthInput.Text, out focalLength))
            {
                return;
            }
            if (!Double.TryParse(this.focalReducerInput.Text, out focalReducer))
            {
                focalReducer = 1;
                this.focalReducerInput.Text = focalReducer.ToString();
            }
            if (!Double.TryParse(this.squeezeFactorInput.Text, out squeezeFactor))
            {
                squeezeFactor = 1;
                this.squeezeFactorInput.Text = squeezeFactor.ToString();
            }

            double cropFactor = this.sensorTypes[this.sensorTypeInput.Text];
            this.horizontalEFLInput.Text = (focalLength * focalReducer * squeezeFactor * cropFactor).ToString();
        }

        private void videoAspectRatioButton_Click(object sender, EventArgs e)
        {
            /*
            Pri aspect ratio inputu lahko preveri kaj je noter,
            potem pa loči obe števili vsako v svojo spremenljivko s tisto funkcijo,
            ki razdeli string glede na določen znak.

            Za tem delji prvo števko (a) z drugo števko (b).

            Količnik (c) je druga števka razmerja videa
            Želen izpis: 1:c
            Primer: 1:2.66

            Primer I/O
            Vnos:
	            aspect ratio = 16:9
	            squeeze factor = 1.5

            Izračun:
	            16 / 9 = 1.77
	            1.77 * 1.5 = 2.655

            Izpis:
	            1:2.655
            */

            Ratio aspect_ratio = new Ratio(sensorAspectRatioInput.Text);

            if (!Double.TryParse(this.squeezeFactorInput.Text, out double squeezeFactor))
            {
                squeezeFactor = 1;
                this.squeezeFactorInput.Text = squeezeFactor.ToString();
            }

            double result = aspect_ratio.Top / aspect_ratio.Bottom * squeezeFactor;

            this.videoAspectRatioInput.Text = result.ToString();
        }
    }
}
