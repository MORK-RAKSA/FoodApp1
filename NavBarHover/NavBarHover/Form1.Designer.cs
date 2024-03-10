namespace NavBarHover
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
            this.slideBar = new System.Windows.Forms.Timer(this.components);
            this.bar = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // slideBar
            // 
            this.slideBar.Interval = 10;
            this.slideBar.Tick += new System.EventHandler(this.slideBar_Tick);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.White;
            this.bar.Location = new System.Drawing.Point(0, 1);
            this.bar.MaximumSize = new System.Drawing.Size(1472, 65);
            this.bar.MinimumSize = new System.Drawing.Size(1472, 5);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1472, 65);
            this.bar.TabIndex = 0;
            this.bar.MouseLeave += new System.EventHandler(this.bar_MouseLeave);
            this.bar.MouseHover += new System.EventHandler(this.bar_MouseHover);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 838);
            this.Controls.Add(this.bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer slideBar;
        private System.Windows.Forms.FlowLayoutPanel bar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

