
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
            this.squeezeFactorButton = new System.Windows.Forms.Button();
            this.focalReducerButton = new System.Windows.Forms.Button();
            this.focalReducerInput = new System.Windows.Forms.ComboBox();
            this.focalLengthButton = new System.Windows.Forms.Button();
            this.focalLengthInput = new System.Windows.Forms.TextBox();
            this.squeezeFactorInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cameraLensMountButton = new System.Windows.Forms.Button();
            this.sensorTypeButton = new System.Windows.Forms.Button();
            this.sensorAspectRatioButton = new System.Windows.Forms.Button();
            this.cameraLensMountInput = new System.Windows.Forms.ComboBox();
            this.sensorTypeInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sensorAspectRatioInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.verticalEFLInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.horizontalEFLInput = new System.Windows.Forms.TextBox();
            this.videoAspectRatioInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.videoAspectRatioButton = new System.Windows.Forms.Button();
            this.horizontalEFLButton = new System.Windows.Forms.Button();
            this.verticalEFLButton = new System.Windows.Forms.Button();
            this.errorMSG = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.squeezeFactorButton);
            this.groupBox1.Controls.Add(this.focalReducerButton);
            this.groupBox1.Controls.Add(this.focalReducerInput);
            this.groupBox1.Controls.Add(this.focalLengthButton);
            this.groupBox1.Controls.Add(this.focalLengthInput);
            this.groupBox1.Controls.Add(this.squeezeFactorInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(303, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lens system";
            // 
            // squeezeFactorButton
            // 
            this.squeezeFactorButton.Location = new System.Drawing.Point(281, 77);
            this.squeezeFactorButton.Name = "squeezeFactorButton";
            this.squeezeFactorButton.Size = new System.Drawing.Size(121, 24);
            this.squeezeFactorButton.TabIndex = 8;
            this.squeezeFactorButton.Text = "Calculate";
            this.squeezeFactorButton.UseVisualStyleBackColor = true;
            this.squeezeFactorButton.Click += new System.EventHandler(this.squeezeFactorButton_Click);
            // 
            // focalReducerButton
            // 
            this.focalReducerButton.Location = new System.Drawing.Point(8, 75);
            this.focalReducerButton.Name = "focalReducerButton";
            this.focalReducerButton.Size = new System.Drawing.Size(121, 24);
            this.focalReducerButton.TabIndex = 7;
            this.focalReducerButton.Text = "Calculate";
            this.focalReducerButton.UseVisualStyleBackColor = true;
            this.focalReducerButton.Click += new System.EventHandler(this.focalReducerButton_Click);
            // 
            // focalReducerInput
            // 
            this.focalReducerInput.FormattingEnabled = true;
            this.focalReducerInput.Items.AddRange(new object[] {
            "0.9",
            "0.85",
            "0.8",
            "0.77",
            "0.75",
            "0.73",
            "0.72",
            "0.71",
            "0.7",
            "0.66",
            "0.62",
            "0.5",
            "0.33"});
            this.focalReducerInput.Location = new System.Drawing.Point(8, 47);
            this.focalReducerInput.Name = "focalReducerInput";
            this.focalReducerInput.Size = new System.Drawing.Size(121, 24);
            this.focalReducerInput.TabIndex = 5;
            // 
            // focalLengthButton
            // 
            this.focalLengthButton.Location = new System.Drawing.Point(143, 75);
            this.focalLengthButton.Name = "focalLengthButton";
            this.focalLengthButton.Size = new System.Drawing.Size(121, 24);
            this.focalLengthButton.TabIndex = 6;
            this.focalLengthButton.Text = "Calculate";
            this.focalLengthButton.UseVisualStyleBackColor = true;
            this.focalLengthButton.Click += new System.EventHandler(this.focalLengthButton_Click);
            // 
            // focalLengthInput
            // 
            this.focalLengthInput.Location = new System.Drawing.Point(143, 47);
            this.focalLengthInput.Name = "focalLengthInput";
            this.focalLengthInput.Size = new System.Drawing.Size(121, 22);
            this.focalLengthInput.TabIndex = 4;
            // 
            // squeezeFactorInput
            // 
            this.squeezeFactorInput.FormattingEnabled = true;
            this.squeezeFactorInput.Items.AddRange(new object[] {
            "2.0",
            "1.8",
            "1.75",
            "1.5",
            "1.42",
            "1.33"});
            this.squeezeFactorInput.Location = new System.Drawing.Point(281, 47);
            this.squeezeFactorInput.Name = "squeezeFactorInput";
            this.squeezeFactorInput.Size = new System.Drawing.Size(121, 24);
            this.squeezeFactorInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Focal reducer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Focal length (mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Squeeze factor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cameraLensMountButton);
            this.groupBox2.Controls.Add(this.sensorTypeButton);
            this.groupBox2.Controls.Add(this.sensorAspectRatioButton);
            this.groupBox2.Controls.Add(this.cameraLensMountInput);
            this.groupBox2.Controls.Add(this.sensorTypeInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sensorAspectRatioInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(158, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera";
            // 
            // cameraLensMountButton
            // 
            this.cameraLensMountButton.Location = new System.Drawing.Point(9, 269);
            this.cameraLensMountButton.Name = "cameraLensMountButton";
            this.cameraLensMountButton.Size = new System.Drawing.Size(121, 24);
            this.cameraLensMountButton.TabIndex = 15;
            this.cameraLensMountButton.Text = "Calculate";
            this.cameraLensMountButton.UseVisualStyleBackColor = true;
            this.cameraLensMountButton.Click += new System.EventHandler(this.cameraLensMountButton_Click);
            // 
            // sensorTypeButton
            // 
            this.sensorTypeButton.Location = new System.Drawing.Point(9, 75);
            this.sensorTypeButton.Name = "sensorTypeButton";
            this.sensorTypeButton.Size = new System.Drawing.Size(121, 24);
            this.sensorTypeButton.TabIndex = 9;
            this.sensorTypeButton.Text = "Calculate";
            this.sensorTypeButton.UseVisualStyleBackColor = true;
            this.sensorTypeButton.Click += new System.EventHandler(this.sensorTypeButton_Click);
            // 
            // sensorAspectRatioButton
            // 
            this.sensorAspectRatioButton.Location = new System.Drawing.Point(9, 173);
            this.sensorAspectRatioButton.Name = "sensorAspectRatioButton";
            this.sensorAspectRatioButton.Size = new System.Drawing.Size(121, 24);
            this.sensorAspectRatioButton.TabIndex = 10;
            this.sensorAspectRatioButton.Text = "Calculate";
            this.sensorAspectRatioButton.UseVisualStyleBackColor = true;
            this.sensorAspectRatioButton.Click += new System.EventHandler(this.sensorAspectRatioButton_Click);
            // 
            // cameraLensMountInput
            // 
            this.cameraLensMountInput.FormattingEnabled = true;
            this.cameraLensMountInput.Items.AddRange(new object[] {
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
            this.cameraLensMountInput.Location = new System.Drawing.Point(9, 239);
            this.cameraLensMountInput.Name = "cameraLensMountInput";
            this.cameraLensMountInput.Size = new System.Drawing.Size(121, 24);
            this.cameraLensMountInput.TabIndex = 7;
            // 
            // sensorTypeInput
            // 
            this.sensorTypeInput.FormattingEnabled = true;
            this.sensorTypeInput.Location = new System.Drawing.Point(9, 45);
            this.sensorTypeInput.Name = "sensorTypeInput";
            this.sensorTypeInput.Size = new System.Drawing.Size(121, 24);
            this.sensorTypeInput.TabIndex = 2;
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
            // sensorAspectRatioInput
            // 
            this.sensorAspectRatioInput.FormattingEnabled = true;
            this.sensorAspectRatioInput.Items.AddRange(new object[] {
            "16:9",
            "4:3"});
            this.sensorAspectRatioInput.Location = new System.Drawing.Point(10, 143);
            this.sensorAspectRatioInput.Name = "sensorAspectRatioInput";
            this.sensorAspectRatioInput.Size = new System.Drawing.Size(121, 24);
            this.sensorAspectRatioInput.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Camera lens mount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Aspect ratio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "vertical effective focal length (mm)";
            // 
            // verticalEFLInput
            // 
            this.verticalEFLInput.Location = new System.Drawing.Point(20, 47);
            this.verticalEFLInput.Name = "verticalEFLInput";
            this.verticalEFLInput.Size = new System.Drawing.Size(121, 22);
            this.verticalEFLInput.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "horizontal effective focal length (mm)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "video aspect ratio";
            // 
            // horizontalEFLInput
            // 
            this.horizontalEFLInput.Location = new System.Drawing.Point(20, 105);
            this.horizontalEFLInput.Name = "horizontalEFLInput";
            this.horizontalEFLInput.Size = new System.Drawing.Size(121, 22);
            this.horizontalEFLInput.TabIndex = 12;
            // 
            // videoAspectRatioInput
            // 
            this.videoAspectRatioInput.Location = new System.Drawing.Point(20, 161);
            this.videoAspectRatioInput.Name = "videoAspectRatioInput";
            this.videoAspectRatioInput.Size = new System.Drawing.Size(121, 22);
            this.videoAspectRatioInput.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.videoAspectRatioButton);
            this.groupBox3.Controls.Add(this.horizontalEFLButton);
            this.groupBox3.Controls.Add(this.verticalEFLButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.videoAspectRatioInput);
            this.groupBox3.Controls.Add(this.verticalEFLInput);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.horizontalEFLInput);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(724, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 201);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other calculations";
            // 
            // videoAspectRatioButton
            // 
            this.videoAspectRatioButton.Location = new System.Drawing.Point(147, 160);
            this.videoAspectRatioButton.Name = "videoAspectRatioButton";
            this.videoAspectRatioButton.Size = new System.Drawing.Size(121, 24);
            this.videoAspectRatioButton.TabIndex = 18;
            this.videoAspectRatioButton.Text = "Calculate";
            this.videoAspectRatioButton.UseVisualStyleBackColor = true;
            this.videoAspectRatioButton.Click += new System.EventHandler(this.videoAspectRatioButton_Click);
            // 
            // horizontalEFLButton
            // 
            this.horizontalEFLButton.Location = new System.Drawing.Point(147, 104);
            this.horizontalEFLButton.Name = "horizontalEFLButton";
            this.horizontalEFLButton.Size = new System.Drawing.Size(121, 24);
            this.horizontalEFLButton.TabIndex = 17;
            this.horizontalEFLButton.Text = "Calculate";
            this.horizontalEFLButton.UseVisualStyleBackColor = true;
            this.horizontalEFLButton.Click += new System.EventHandler(this.horizontalEFLButton_Click);
            // 
            // verticalEFLButton
            // 
            this.verticalEFLButton.Location = new System.Drawing.Point(147, 46);
            this.verticalEFLButton.Name = "verticalEFLButton";
            this.verticalEFLButton.Size = new System.Drawing.Size(121, 24);
            this.verticalEFLButton.TabIndex = 16;
            this.verticalEFLButton.Text = "Calculate";
            this.verticalEFLButton.UseVisualStyleBackColor = true;
            this.verticalEFLButton.Click += new System.EventHandler(this.verticalEFLButton_Click);
            // 
            // errorMSG
            // 
            this.errorMSG.AutoSize = true;
            this.errorMSG.Location = new System.Drawing.Point(308, 509);
            this.errorMSG.Name = "errorMSG";
            this.errorMSG.Size = new System.Drawing.Size(655, 17);
            this.errorMSG.TabIndex = 15;
            this.errorMSG.Text = "Če klikneš calculate pa nima dovolj podatkov izpiše katere vse podatke moraš vnes" +
    "t da lahko izračuna.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 892);
            this.Controls.Add(this.errorMSG);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Camera calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox focalLengthInput;
        private System.Windows.Forms.ComboBox focalReducerInput;
        private System.Windows.Forms.ComboBox squeezeFactorInput;
        private System.Windows.Forms.ComboBox cameraLensMountInput;
        private System.Windows.Forms.ComboBox sensorAspectRatioInput;
        private System.Windows.Forms.ComboBox sensorTypeInput;
        private System.Windows.Forms.Button focalLengthButton;
        private System.Windows.Forms.Button squeezeFactorButton;
        private System.Windows.Forms.Button focalReducerButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox verticalEFLInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox horizontalEFLInput;
        private System.Windows.Forms.TextBox videoAspectRatioInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sensorTypeButton;
        private System.Windows.Forms.Button cameraLensMountButton;
        private System.Windows.Forms.Button sensorAspectRatioButton;
        private System.Windows.Forms.Button videoAspectRatioButton;
        private System.Windows.Forms.Button horizontalEFLButton;
        private System.Windows.Forms.Button verticalEFLButton;
        private System.Windows.Forms.Label errorMSG;
    }
}