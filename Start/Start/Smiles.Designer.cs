namespace Start
{
    partial class Smiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smiles));
            this.picSmile = new System.Windows.Forms.PictureBox();
            this.picFrown = new System.Windows.Forms.PictureBox();
            this.picHappy = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).BeginInit();
            this.SuspendLayout();
            // 
            // picSmile
            // 
            this.picSmile.BackColor = System.Drawing.SystemColors.Control;
            this.picSmile.Image = ((System.Drawing.Image)(resources.GetObject("picSmile.Image")));
            this.picSmile.Location = new System.Drawing.Point(12, 40);
            this.picSmile.Name = "picSmile";
            this.picSmile.Size = new System.Drawing.Size(105, 105);
            this.picSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSmile.TabIndex = 0;
            this.picSmile.TabStop = false;
            this.picSmile.Click += new System.EventHandler(this.picSmile_Click);
            // 
            // picFrown
            // 
            this.picFrown.Image = ((System.Drawing.Image)(resources.GetObject("picFrown.Image")));
            this.picFrown.Location = new System.Drawing.Point(132, 40);
            this.picFrown.Name = "picFrown";
            this.picFrown.Size = new System.Drawing.Size(105, 105);
            this.picFrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFrown.TabIndex = 1;
            this.picFrown.TabStop = false;
            this.picFrown.Click += new System.EventHandler(this.picFrown_Click);
            // 
            // picHappy
            // 
            this.picHappy.Image = ((System.Drawing.Image)(resources.GetObject("picHappy.Image")));
            this.picHappy.Location = new System.Drawing.Point(255, 40);
            this.picHappy.Name = "picHappy";
            this.picHappy.Size = new System.Drawing.Size(105, 105);
            this.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHappy.TabIndex = 2;
            this.picHappy.TabStop = false;
            this.picHappy.Click += new System.EventHandler(this.picHappy_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(12, 179);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(344, 44);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Щелкайте на смайлики!)";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(148, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Smiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picHappy);
            this.Controls.Add(this.picFrown);
            this.Controls.Add(this.picSmile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Smiles - Упражнение №1";
            this.Load += new System.EventHandler(this.Smile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSmile;
        private System.Windows.Forms.PictureBox picFrown;
        private System.Windows.Forms.PictureBox picHappy;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
    }
}