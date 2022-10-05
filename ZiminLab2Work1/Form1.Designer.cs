namespace ZiminLab2Work1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trainHourArrive = new System.Windows.Forms.TextBox();
            this.trainMinArrive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainMinDep = new System.Windows.Forms.TextBox();
            this.trainHourDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passMinArrive = new System.Windows.Forms.TextBox();
            this.passHourArrive = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trainHourArrive
            // 
            this.trainHourArrive.Location = new System.Drawing.Point(30, 48);
            this.trainHourArrive.Name = "trainHourArrive";
            this.trainHourArrive.Size = new System.Drawing.Size(30, 23);
            this.trainHourArrive.TabIndex = 0;
            this.trainHourArrive.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // trainMinArrive
            // 
            this.trainMinArrive.Location = new System.Drawing.Point(66, 48);
            this.trainMinArrive.Name = "trainMinArrive";
            this.trainMinArrive.Size = new System.Drawing.Size(30, 23);
            this.trainMinArrive.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время прибытия поезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время отправки поезда";
            // 
            // trainMinDep
            // 
            this.trainMinDep.Location = new System.Drawing.Point(66, 108);
            this.trainMinDep.Name = "trainMinDep";
            this.trainMinDep.Size = new System.Drawing.Size(30, 23);
            this.trainMinDep.TabIndex = 4;
            // 
            // trainHourDep
            // 
            this.trainHourDep.Location = new System.Drawing.Point(30, 108);
            this.trainHourDep.Name = "trainHourDep";
            this.trainHourDep.Size = new System.Drawing.Size(30, 23);
            this.trainHourDep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время прихода пассажира поезда";
            // 
            // passMinArrive
            // 
            this.passMinArrive.Location = new System.Drawing.Point(66, 168);
            this.passMinArrive.Name = "passMinArrive";
            this.passMinArrive.Size = new System.Drawing.Size(30, 23);
            this.passMinArrive.TabIndex = 7;
            // 
            // passHourArrive
            // 
            this.passHourArrive.Location = new System.Drawing.Point(30, 168);
            this.passHourArrive.Name = "passHourArrive";
            this.passHourArrive.Size = new System.Drawing.Size(30, 23);
            this.passHourArrive.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Рассчитать стоянку поезда";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Условия вводимой задачи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 75);
            this.label5.TabIndex = 11;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // TimeResult
            // 
            this.TimeResult.AutoSize = true;
            this.TimeResult.Location = new System.Drawing.Point(255, 222);
            this.TimeResult.Name = "TimeResult";
            this.TimeResult.Size = new System.Drawing.Size(0, 15);
            this.TimeResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(720, 266);
            this.Controls.Add(this.TimeResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passMinArrive);
            this.Controls.Add(this.passHourArrive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trainMinDep);
            this.Controls.Add(this.trainHourDep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainMinArrive);
            this.Controls.Add(this.trainHourArrive);
            this.Name = "Form1";
            this.Text = "Рассчёт прибытия поезда и пассажира";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox trainHourArrive;
        private TextBox trainMinArrive;
        private Label label1;
        private Label label2;
        private TextBox trainMinDep;
        private TextBox trainHourDep;
        private Label label3;
        private TextBox passMinArrive;
        private TextBox passHourArrive;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label TimeResult;
    }
}