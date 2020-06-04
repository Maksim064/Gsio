namespace MyCompany.Shipakin
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
            this.lblTickCount = new System.Windows.Forms.Label();
            this.Simple = new System.Windows.Forms.Button();
            this.btnClickGen = new MyCompany.Shipakin.ClickmaticButton(this.components);
            this.SuspendLayout();
            // 
            // lblTickCount
            // 
            this.lblTickCount.AutoSize = true;
            this.lblTickCount.Location = new System.Drawing.Point(335, 181);
            this.lblTickCount.Name = "lblTickCount";
            this.lblTickCount.Size = new System.Drawing.Size(63, 13);
            this.lblTickCount.TabIndex = 1;
            this.lblTickCount.Text = "ПОГНАЛИ!";
            // 
            // Simple
            // 
            this.Simple.Location = new System.Drawing.Point(252, 250);
            this.Simple.Name = "Simple";
            this.Simple.Size = new System.Drawing.Size(75, 23);
            this.Simple.TabIndex = 2;
            this.Simple.Text = "Simple";
            this.Simple.UseVisualStyleBackColor = true;
            this.Simple.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // btnClickGen
            // 
            this.btnClickGen.Location = new System.Drawing.Point(372, 250);
            this.btnClickGen.Name = "btnClickGen";
            this.btnClickGen.Size = new System.Drawing.Size(75, 23);
            this.btnClickGen.TabIndex = 0;
            this.btnClickGen.Text = "ClickGen";
            this.btnClickGen.UseVisualStyleBackColor = true;
            this.btnClickGen.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Simple);
            this.Controls.Add(this.lblTickCount);
            this.Controls.Add(this.btnClickGen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCompany.Shipakin.ClickmaticButton btnClickGen;
        private System.Windows.Forms.Label lblTickCount;
        private System.Windows.Forms.Button Simple;
    }
}