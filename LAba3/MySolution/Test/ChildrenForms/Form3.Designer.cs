﻿namespace MyCompany.Shipakin
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericScan2 = new MyCompany.Shipakin.NumericScan();
            this.numericScan1 = new MyCompany.Shipakin.NumericScan();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // numericScan2
            // 
            this.numericScan2.DecimalPlaces = 0;
            this.numericScan2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericScan2.Location = new System.Drawing.Point(285, 117);
            this.numericScan2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericScan2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan2.Name = "numericScan2";
            this.numericScan2.Size = new System.Drawing.Size(52, 37);
            this.numericScan2.TabIndex = 1;
            this.numericScan2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan2.ValueChanged += new System.EventHandler(this.NumericScanOnValueChanged);
            // 
            // numericScan1
            // 
            this.numericScan1.DecimalPlaces = 0;
            this.numericScan1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericScan1.Location = new System.Drawing.Point(104, 117);
            this.numericScan1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericScan1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan1.Name = "numericScan1";
            this.numericScan1.Size = new System.Drawing.Size(52, 37);
            this.numericScan1.TabIndex = 0;
            this.numericScan1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan1.ValueChanged += new System.EventHandler(this.NumericScanOnValueChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericScan2);
            this.Controls.Add(this.numericScan1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericScan numericScan1;
        private NumericScan numericScan2;
        private System.Windows.Forms.Label label1;
    }
}