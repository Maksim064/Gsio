namespace MyCompany.UserControls
{
    partial class Check
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
            this.beepButton1 = new MyCompany.UserControls.BeepButton(this.components);
            this.SuspendLayout();
            // 
            // beepButton1
            // 
            this.beepButton1.Location = new System.Drawing.Point(157, 68);
            this.beepButton1.Name = "beepButton1";
            this.beepButton1.Size = new System.Drawing.Size(75, 23);
            this.beepButton1.TabIndex = 0;
            this.beepButton1.Text = "beepButton1";
            this.beepButton1.UseVisualStyleBackColor = true;
            this.beepButton1.Click += new System.EventHandler(this.beepButton1_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beepButton1);
            this.Name = "Check";
            this.Text = "Check";
            this.ResumeLayout(false);

        }

        #endregion

        private BeepButton beepButton1;
    }
}