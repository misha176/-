
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_open = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.b_black = new System.Windows.Forms.Button();
            this.b_red = new System.Windows.Forms.Button();
            this.b_orange = new System.Windows.Forms.Button();
            this.b_yellow = new System.Windows.Forms.Button();
            this.b_green = new System.Windows.Forms.Button();
            this.b_purple = new System.Windows.Forms.Button();
            this.b_cyan = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(915, 424);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(0, 0);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(100, 35);
            this.b_open.TabIndex = 2;
            this.b_open.Text = "Відкрити";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.b_black);
            this.flowLayoutPanel1.Controls.Add(this.b_red);
            this.flowLayoutPanel1.Controls.Add(this.b_orange);
            this.flowLayoutPanel1.Controls.Add(this.b_yellow);
            this.flowLayoutPanel1.Controls.Add(this.b_green);
            this.flowLayoutPanel1.Controls.Add(this.b_purple);
            this.flowLayoutPanel1.Controls.Add(this.b_cyan);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(766, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 78);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // b_black
            // 
            this.b_black.BackColor = System.Drawing.Color.Black;
            this.b_black.Location = new System.Drawing.Point(3, 3);
            this.b_black.Name = "b_black";
            this.b_black.Size = new System.Drawing.Size(30, 30);
            this.b_black.TabIndex = 0;
            this.b_black.UseVisualStyleBackColor = false;
            this.b_black.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_red
            // 
            this.b_red.BackColor = System.Drawing.Color.Red;
            this.b_red.Location = new System.Drawing.Point(39, 3);
            this.b_red.Name = "b_red";
            this.b_red.Size = new System.Drawing.Size(30, 30);
            this.b_red.TabIndex = 1;
            this.b_red.UseVisualStyleBackColor = false;
            this.b_red.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_orange
            // 
            this.b_orange.BackColor = System.Drawing.Color.Orange;
            this.b_orange.Location = new System.Drawing.Point(75, 3);
            this.b_orange.Name = "b_orange";
            this.b_orange.Size = new System.Drawing.Size(30, 30);
            this.b_orange.TabIndex = 2;
            this.b_orange.UseVisualStyleBackColor = false;
            this.b_orange.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_yellow
            // 
            this.b_yellow.BackColor = System.Drawing.Color.Yellow;
            this.b_yellow.Location = new System.Drawing.Point(111, 3);
            this.b_yellow.Name = "b_yellow";
            this.b_yellow.Size = new System.Drawing.Size(30, 30);
            this.b_yellow.TabIndex = 3;
            this.b_yellow.UseVisualStyleBackColor = false;
            this.b_yellow.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_green
            // 
            this.b_green.BackColor = System.Drawing.Color.Green;
            this.b_green.Location = new System.Drawing.Point(3, 39);
            this.b_green.Name = "b_green";
            this.b_green.Size = new System.Drawing.Size(30, 30);
            this.b_green.TabIndex = 4;
            this.b_green.UseVisualStyleBackColor = false;
            this.b_green.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_purple
            // 
            this.b_purple.BackColor = System.Drawing.Color.Purple;
            this.b_purple.Location = new System.Drawing.Point(39, 39);
            this.b_purple.Name = "b_purple";
            this.b_purple.Size = new System.Drawing.Size(30, 30);
            this.b_purple.TabIndex = 5;
            this.b_purple.UseVisualStyleBackColor = false;
            this.b_purple.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // b_cyan
            // 
            this.b_cyan.BackColor = System.Drawing.Color.Cyan;
            this.b_cyan.Location = new System.Drawing.Point(75, 39);
            this.b_cyan.Name = "b_cyan";
            this.b_cyan.Size = new System.Drawing.Size(30, 30);
            this.b_cyan.TabIndex = 6;
            this.b_cyan.UseVisualStyleBackColor = false;
            this.b_cyan.Click += new System.EventHandler(this.all_Color_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "images|*.bmp;*.png;*.jpg";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(915, 506);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.b_open);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 78);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Save);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "images|*.bmp;*.png;*.jpg";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(111, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.more_color);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 506);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
    }
}

