namespace Calculator
{
    partial class aboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutUsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnToCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.returnToCalc);
            this.panel1.Location = new System.Drawing.Point(-66, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 441);
            this.panel1.TabIndex = 3;
            // 
            // returnToCalc
            // 
            this.returnToCalc.BackColor = System.Drawing.Color.Red;
            this.returnToCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnToCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToCalc.ForeColor = System.Drawing.Color.DarkBlue;
            this.returnToCalc.Location = new System.Drawing.Point(455, 382);
            this.returnToCalc.Name = "returnToCalc";
            this.returnToCalc.Size = new System.Drawing.Size(420, 52);
            this.returnToCalc.TabIndex = 14;
            this.returnToCalc.Text = "Return to Calculator";
            this.returnToCalc.UseVisualStyleBackColor = false;
            this.returnToCalc.Click += new System.EventHandler(this.returnToCalc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Made by Mark Mamdouh Mageed Eshaq";
            // 
            // aboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.panel1);
            this.Name = "aboutUsForm";
            this.Text = "About US";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button returnToCalc;
        private System.Windows.Forms.Label label1;
    }
}