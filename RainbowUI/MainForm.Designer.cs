namespace RainbowUI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.minimizelabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.RainbowPanel = new System.Windows.Forms.Panel();
            this.PanelRainbow = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.DragPanel);
            this.panel1.Controls.Add(this.RainbowPanel);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 41);
            this.panel1.TabIndex = 0;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.DragPanel.Controls.Add(this.minimizelabel);
            this.DragPanel.Controls.Add(this.CloseLabel);
            this.DragPanel.Controls.Add(this.LogoLabel);
            this.DragPanel.Location = new System.Drawing.Point(3, 3);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(806, 35);
            this.DragPanel.TabIndex = 2;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // minimizelabel
            // 
            this.minimizelabel.AutoSize = true;
            this.minimizelabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizelabel.ForeColor = System.Drawing.Color.White;
            this.minimizelabel.Location = new System.Drawing.Point(749, 9);
            this.minimizelabel.Name = "minimizelabel";
            this.minimizelabel.Size = new System.Drawing.Size(19, 25);
            this.minimizelabel.TabIndex = 3;
            this.minimizelabel.Text = "-";
            this.minimizelabel.Click += new System.EventHandler(this.minimizelabel_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.Color.Transparent;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(774, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(26, 25);
            this.CloseLabel.TabIndex = 2;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.Red;
            this.LogoLabel.Location = new System.Drawing.Point(3, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(121, 25);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "Rainbow UI";
            this.LogoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.LogoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // RainbowPanel
            // 
            this.RainbowPanel.BackColor = System.Drawing.Color.Red;
            this.RainbowPanel.Location = new System.Drawing.Point(3, 15);
            this.RainbowPanel.Name = "RainbowPanel";
            this.RainbowPanel.Size = new System.Drawing.Size(806, 34);
            this.RainbowPanel.TabIndex = 1;
            // 
            // PanelRainbow
            // 
            this.PanelRainbow.Enabled = true;
            this.PanelRainbow.Interval = 1;
            this.PanelRainbow.Tick += new System.EventHandler(this.PanelRainbow_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rainbow UI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Label minimizelabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Panel RainbowPanel;
        private System.Windows.Forms.Timer PanelRainbow;
    }
}

