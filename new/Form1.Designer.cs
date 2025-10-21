namespace @new
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelYellow
            // 
            this.panelYellow.Location = new System.Drawing.Point(12, 119);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(200, 100);
            this.panelYellow.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.Location = new System.Drawing.Point(12, 225);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(200, 100);
            this.panelGreen.TabIndex = 2;
            // 
            // panelRed
            // 
            this.panelRed.Location = new System.Drawing.Point(12, 12);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(200, 100);
            this.panelRed.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(405, 119);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(184, 100);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonstop
            // 
            this.buttonstop.Location = new System.Drawing.Point(405, 265);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(182, 91);
            this.buttonstop.TabIndex = 5;
            this.buttonstop.Text = "stop";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonstop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelYellow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonstop;
    }
}

