using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop.Client.Forms
{
    partial class Loading
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel pnlLoading;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbBackground;
        private System.Windows.Forms.Timer timerLoading;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.cpbBackground = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            this.pnlLoading.SuspendLayout();
            this.cpbBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoading
            // 
            this.pnlLoading.Controls.Add(this.cpbBackground);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoading.Location = new System.Drawing.Point(0, 0);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(1097, 489);
            this.pnlLoading.TabIndex = 0;
            // 
            // cpbBackground
            // 
            this.cpbBackground.Controls.Add(this.lblLoading);
            this.cpbBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cpbBackground.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpbBackground.ForeColor = System.Drawing.Color.White;
            this.cpbBackground.Location = new System.Drawing.Point(393, 104);
            this.cpbBackground.Minimum = 0;
            this.cpbBackground.Name = "cpbBackground";
            this.cpbBackground.ProgressColor = System.Drawing.Color.Tomato;
            this.cpbBackground.ProgressColor2 = System.Drawing.Color.Gold;
            this.cpbBackground.Size = new System.Drawing.Size(293, 293);
            this.cpbBackground.TabIndex = 0;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 20;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Gray;
            this.lblLoading.Location = new System.Drawing.Point(82, 124);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(119, 31);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "Loading...";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 489);
            this.Controls.Add(this.pnlLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.pnlLoading.ResumeLayout(false);
            this.cpbBackground.ResumeLayout(false);
            this.cpbBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblLoading;
    }
}
