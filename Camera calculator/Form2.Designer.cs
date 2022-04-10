
namespace Camera_calculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.focalLength = new System.Windows.Forms.TextBox();
            this.focalReducer = new System.Windows.Forms.ComboBox();
            this.squeezeFactor = new System.Windows.Forms.ComboBox();
            this.cameraLensMount = new System.Windows.Forms.ComboBox();
            this.sensorType = new System.Windows.Forms.ComboBox();
            this.sensorAspectRatio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cameraLensMount);
            this.groupBox1.Controls.Add(this.squeezeFactor);
            this.groupBox1.Controls.Add(this.focalReducer);
            this.groupBox1.Controls.Add(this.focalLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lens system";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sensorAspectRatio);
            this.groupBox2.Controls.Add(this.sensorType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Focal length (mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Focal reducer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Squeeze factor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Camera lens mount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sensor type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Aspect ratio";
            // 
            // focalLength
            // 
            this.focalLength.Location = new System.Drawing.Point(9, 47);
            this.focalLength.Name = "focalLength";
            this.focalLength.Size = new System.Drawing.Size(121, 22);
            this.focalLength.TabIndex = 4;
            // 
            // focalReducer
            // 
            this.focalReducer.FormattingEnabled = true;
            this.focalReducer.Items.AddRange(new object[] {
            "x0.9",
            "x0.85",
            "x0.8",
            "x0.77",
            "x0.75",
            "x0.73",
            "x0.72",
            "x0.71",
            "x0.7",
            "x0.66",
            "x0.62",
            "x0.5",
            "x0.33"});
            this.focalReducer.Location = new System.Drawing.Point(9, 106);
            this.focalReducer.Name = "focalReducer";
            this.focalReducer.Size = new System.Drawing.Size(121, 24);
            this.focalReducer.TabIndex = 5;
            // 
            // squeezeFactor
            // 
            this.squeezeFactor.FormattingEnabled = true;
            this.squeezeFactor.Items.AddRange(new object[] {
            "2.0",
            "1.8",
            "1.75",
            "1.5",
            "1.42",
            "1.33"});
            this.squeezeFactor.Location = new System.Drawing.Point(9, 165);
            this.squeezeFactor.Name = "squeezeFactor";
            this.squeezeFactor.Size = new System.Drawing.Size(121, 24);
            this.squeezeFactor.TabIndex = 6;
            // 
            // cameraLensMount
            // 
            this.cameraLensMount.FormattingEnabled = true;
            this.cameraLensMount.Items.AddRange(new object[] {
            "EF",
            "MFT",
            "PL",
            "L",
            "RF",
            "Z",
            "E",
            "C/Y",
            "LEICA R",
            "M42",
            "F"});
            this.cameraLensMount.Location = new System.Drawing.Point(9, 224);
            this.cameraLensMount.Name = "cameraLensMount";
            this.cameraLensMount.Size = new System.Drawing.Size(121, 24);
            this.cameraLensMount.TabIndex = 7;
            // 
            // sensorType
            // 
            this.sensorType.FormattingEnabled = true;
            this.sensorType.Items.AddRange(new object[] {
            "Medium format (48 * 36mm)",
            "Full frame (36 * 24mm)",
            "Super 35 (?)",
            "APS-C [Nikon DX, Sony E](1.5x crop)",
            "APS-C [Nikon DX, Sony E](1.6x crop)",
            "Micro 3/4 (2x crop)",
            "Super 16",
            "(12.5 * 7mm)"});
            this.sensorType.Location = new System.Drawing.Point(9, 47);
            this.sensorType.Name = "sensorType";
            this.sensorType.Size = new System.Drawing.Size(121, 24);
            this.sensorType.TabIndex = 2;
            // 
            // sensorAspectRatio
            // 
            this.sensorAspectRatio.FormattingEnabled = true;
            this.sensorAspectRatio.Items.AddRange(new object[] {
            "16:9 -> 1.77:1(...)",
            "4:3 -> 1.33:1(...)"});
            this.sensorAspectRatio.Location = new System.Drawing.Point(10, 105);
            this.sensorAspectRatio.Name = "sensorAspectRatio";
            this.sensorAspectRatio.Size = new System.Drawing.Size(121, 24);
            this.sensorAspectRatio.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(158, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 24);
            this.button4.TabIndex = 5;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(158, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 24);
            this.button5.TabIndex = 6;
            this.button5.Text = "Calculate";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(158, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 24);
            this.button6.TabIndex = 7;
            this.button6.Text = "Calculate";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 892);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox focalLength;
        private System.Windows.Forms.ComboBox focalReducer;
        private System.Windows.Forms.ComboBox squeezeFactor;
        private System.Windows.Forms.ComboBox cameraLensMount;
        private System.Windows.Forms.ComboBox sensorAspectRatio;
        private System.Windows.Forms.ComboBox sensorType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}