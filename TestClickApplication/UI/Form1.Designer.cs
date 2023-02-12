using System.ComponentModel;
using System.Timers;
using TestClickApplication;
using TestClickApplication.OS;

namespace TestClickApplication.UI
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
            this.clickNumLabel = new System.Windows.Forms.Label();
            this.clickNumber = new System.Windows.Forms.Label();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.refreshText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickNumLabel
            // 
            this.clickNumLabel.AutoSize = true;
            this.clickNumLabel.Location = new System.Drawing.Point(25, 23);
            this.clickNumLabel.Name = "clickNumLabel";
            this.clickNumLabel.Size = new System.Drawing.Size(65, 15);
            this.clickNumLabel.TabIndex = 0;
            this.clickNumLabel.Text = "# of Clicks:";
            // 
            // clickNumber
            // 
            this.clickNumber.AutoSize = true;
            this.clickNumber.Location = new System.Drawing.Point(96, 23);
            this.clickNumber.Name = "clickNumber";
            this.clickNumber.Size = new System.Drawing.Size(13, 15);
            this.clickNumber.TabIndex = 1;
            this.clickNumber.Text = "0";
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Location = new System.Drawing.Point(472, 23);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(80, 15);
            this.refreshLabel.TabIndex = 2;
            this.refreshLabel.Text = "LastRefreshed";
            // 
            // refreshText
            // 
            this.refreshText.AutoSize = true;
            this.refreshText.Location = new System.Drawing.Point(589, 23);
            this.refreshText.Name = "refreshText";
            this.refreshText.Size = new System.Drawing.Size(0, 15);
            this.refreshText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshText);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.clickNumber);
            this.Controls.Add(this.clickNumLabel);
            this.Name = "Form1";
            this.Text = "Click Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        private Label clickNumLabel;
        private Label clickNumber;
        private Label refreshLabel;
        private Label refreshText;
    }
}