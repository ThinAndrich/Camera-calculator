using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera_calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void verticalEFLButton_Click(object sender, EventArgs e)
        {
            double focalLength = 0;
            double focalReducer = 1;

            if (!Double.TryParse(this.focalLengthInput.Text, out focalLength))
            {
                return;
            }
            if (!Double.TryParse(this.focalReducerInput.Text, out focalReducer))
            {
                focalReducer = 1;
                this.focalReducerInput.Text = focalReducer.ToString();
            }

            this.verticalEFLInput.Text = (focalLength * focalReducer).ToString();

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
            this.horizontalEFLInput.Text = (focalLength * focalReducer * squeezeFactor).ToString();
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

            double sensorAspectRatio = 0;
            double squeezeFactor = 1;

            

            if (!Double.TryParse(this.sensorAspectRatioInput.Text, out sensorAspectRatio))
            {
                sensorAspectRatio = 0;
                this.sensorAspectRatioInput.Text = sensorAspectRatio.ToString();
            }
            if (!Double.TryParse(this.squeezeFactorInput.Text, out squeezeFactor))
            {
                squeezeFactor = 1;
                this.squeezeFactorInput.Text = squeezeFactor.ToString();
            }

            this.videoAspectRatioInput.Text = (sensorAspectRatio * squeezeFactor).ToString();
        }
    }
}
