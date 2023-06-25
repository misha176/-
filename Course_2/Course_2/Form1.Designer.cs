
namespace Course_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.b_black = new System.Windows.Forms.Button();
            this.b_red = new System.Windows.Forms.Button();
            this.b_orange = new System.Windows.Forms.Button();
            this.b_yellow = new System.Windows.Forms.Button();
            this.b_green = new System.Windows.Forms.Button();
            this.b_purple = new System.Windows.Forms.Button();
            this.b_cyan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.b_open = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.b_open);
            this.panel2.Name = "panel2";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.trackBar1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.b_Draw);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.b_Brush);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Save);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.b_black);
            this.flowLayoutPanel1.Controls.Add(this.b_red);
            this.flowLayoutPanel1.Controls.Add(this.b_orange);
            this.flowLayoutPanel1.Controls.Add(this.b_yellow);
            this.flowLayoutPanel1.Controls.Add(this.b_green);
            this.flowLayoutPanel1.Controls.Add(this.b_purple);
            this.flowLayoutPanel1.Controls.Add(this.b_cyan);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // b_black
            // 
            resources.ApplyResources(this.b_black, "b_black");
            this.b_black.BackColor = System.Drawing.Color.Black;
            this.b_black.Name = "b_black";
            this.b_black.UseVisualStyleBackColor = false;
            this.b_black.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_red
            // 
            resources.ApplyResources(this.b_red, "b_red");
            this.b_red.BackColor = System.Drawing.Color.Red;
            this.b_red.Name = "b_red";
            this.b_red.UseVisualStyleBackColor = false;
            this.b_red.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_orange
            // 
            resources.ApplyResources(this.b_orange, "b_orange");
            this.b_orange.BackColor = System.Drawing.Color.Orange;
            this.b_orange.Name = "b_orange";
            this.b_orange.UseVisualStyleBackColor = false;
            this.b_orange.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_yellow
            // 
            resources.ApplyResources(this.b_yellow, "b_yellow");
            this.b_yellow.BackColor = System.Drawing.Color.Yellow;
            this.b_yellow.Name = "b_yellow";
            this.b_yellow.UseVisualStyleBackColor = false;
            this.b_yellow.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_green
            // 
            resources.ApplyResources(this.b_green, "b_green");
            this.b_green.BackColor = System.Drawing.Color.Green;
            this.b_green.Name = "b_green";
            this.b_green.UseVisualStyleBackColor = false;
            this.b_green.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_purple
            // 
            resources.ApplyResources(this.b_purple, "b_purple");
            this.b_purple.BackColor = System.Drawing.Color.Purple;
            this.b_purple.Name = "b_purple";
            this.b_purple.UseVisualStyleBackColor = false;
            this.b_purple.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_cyan
            // 
            resources.ApplyResources(this.b_cyan, "b_cyan");
            this.b_cyan.BackColor = System.Drawing.Color.Cyan;
            this.b_cyan.Name = "b_cyan";
            this.b_cyan.UseVisualStyleBackColor = false;
            this.b_cyan.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.more_color);
            // 
            // b_open
            // 
            resources.ApplyResources(this.b_open, "b_open");
            this.b_open.Name = "b_open";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button b_black;
        private System.Windows.Forms.Button b_red;
        private System.Windows.Forms.Button b_orange;
        private System.Windows.Forms.Button b_yellow;
        private System.Windows.Forms.Button b_green;
        private System.Windows.Forms.Button b_purple;
        private System.Windows.Forms.Button b_cyan;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

