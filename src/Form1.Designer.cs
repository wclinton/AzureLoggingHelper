using System;

namespace AzureLoggingHelper
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
            this.Calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.localTime = new System.Windows.Forms.TextBox();
            this.utcTime = new System.Windows.Forms.TextBox();
            this.UTCQueryTime = new System.Windows.Forms.TextBox();
            this.Ticks = new System.Windows.Forms.TextBox();
            this.localQueryTime = new System.Windows.Forms.TextBox();
            this.Difference = new System.Windows.Forms.TextBox();
            this.Query = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(277, 307);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 0;
            this.Calc.Text = "Calc";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Local Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current UTC Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Local Query Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Difference(hrs)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Query UCT Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ticks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Query";
            // 
            // localTime
            // 
            this.localTime.Location = new System.Drawing.Point(122, 36);
            this.localTime.Name = "localTime";
            this.localTime.ReadOnly = true;
            this.localTime.Size = new System.Drawing.Size(156, 20);
            this.localTime.TabIndex = 8;
            this.localTime.Text = "7/17/2013 11:22:47 AM";
            // 
            // utcTime
            // 
            this.utcTime.Location = new System.Drawing.Point(122, 68);
            this.utcTime.Name = "utcTime";
            this.utcTime.ReadOnly = true;
            this.utcTime.Size = new System.Drawing.Size(156, 20);
            this.utcTime.TabIndex = 9;
            // 
            // UTCQueryTime
            // 
            this.UTCQueryTime.Location = new System.Drawing.Point(122, 152);
            this.UTCQueryTime.Name = "UTCQueryTime";
            this.UTCQueryTime.Size = new System.Drawing.Size(156, 20);
            this.UTCQueryTime.TabIndex = 10;
            // 
            // Ticks
            // 
            this.Ticks.Location = new System.Drawing.Point(122, 189);
            this.Ticks.Name = "Ticks";
            this.Ticks.ReadOnly = true;
            this.Ticks.Size = new System.Drawing.Size(156, 20);
            this.Ticks.TabIndex = 11;
            // 
            // localQueryTime
            // 
            this.localQueryTime.Location = new System.Drawing.Point(122, 122);
            this.localQueryTime.Name = "localQueryTime";
            this.localQueryTime.ReadOnly = true;
            this.localQueryTime.Size = new System.Drawing.Size(156, 20);
            this.localQueryTime.TabIndex = 12;
            // 
            // Difference
            // 
            this.Difference.Location = new System.Drawing.Point(122, 94);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(35, 20);
            this.Difference.TabIndex = 13;
            this.Difference.Text = "1";
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(124, 220);
            this.Query.Name = "Query";
            this.Query.ReadOnly = true;
            this.Query.Size = new System.Drawing.Size(228, 20);
            this.Query.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 354);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.localQueryTime);
            this.Controls.Add(this.Ticks);
            this.Controls.Add(this.UTCQueryTime);
            this.Controls.Add(this.utcTime);
            this.Controls.Add(this.localTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calc);
            this.Name = "Form1";
            this.Text = "Azure Logging Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UpdateTime()
        {
            var currentTime = DateTime.Now;
            var currentUtcTime = currentTime.ToUniversalTime();
            localTime.Text = currentTime.ToString();
            utcTime.Text = currentUtcTime.ToString();

            var queryTime= currentTime.AddHours(-1*Convert.ToDouble(Difference.Text));
            var queryUTCTime = queryTime.ToUniversalTime();

            localQueryTime.Text = queryTime.ToString();
            UTCQueryTime.Text = queryUTCTime.ToString();


            Ticks.Text = queryUTCTime.Ticks.ToString();

            Query.Text = "PartitionKey ge '0" + Ticks.Text + "'";
        }

        #endregion

        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox localTime;
        private System.Windows.Forms.TextBox utcTime;
        private System.Windows.Forms.TextBox UTCQueryTime;
        private System.Windows.Forms.TextBox Ticks;
        private System.Windows.Forms.TextBox localQueryTime;
        private System.Windows.Forms.TextBox Difference;
        private System.Windows.Forms.TextBox Query;
    }
}

