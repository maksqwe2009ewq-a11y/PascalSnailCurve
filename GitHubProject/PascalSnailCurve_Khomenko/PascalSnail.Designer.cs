namespace PascalSnailCurve_Khomenko
{
    partial class PascalSnail
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
            this.panelConrol = new System.Windows.Forms.Panel();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numB2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numA2 = new System.Windows.Forms.NumericUpDown();
            this.checkCompare = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numB1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numA1 = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureGraph = new System.Windows.Forms.PictureBox();
            this.panelConrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConrol
            // 
            this.panelConrol.Controls.Add(this.pictureBox2);
            this.panelConrol.Controls.Add(this.groupBox3);
            this.panelConrol.Controls.Add(this.groupBox2);
            this.panelConrol.Controls.Add(this.groupBox1);
            this.panelConrol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConrol.Location = new System.Drawing.Point(0, 0);
            this.panelConrol.Name = "panelConrol";
            this.panelConrol.Size = new System.Drawing.Size(245, 604);
            this.panelConrol.TabIndex = 1;
            this.panelConrol.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConrol_Paint);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.BackColor = System.Drawing.Color.White;
            this.buttonZoomOut.Location = new System.Drawing.Point(117, 142);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(64, 23);
            this.buttonZoomOut.TabIndex = 15;
            this.buttonZoomOut.Text = "-";
            this.buttonZoomOut.UseVisualStyleBackColor = false;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.BackColor = System.Drawing.Color.White;
            this.buttonZoomIn.Location = new System.Drawing.Point(34, 142);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(64, 23);
            this.buttonZoomIn.TabIndex = 2;
            this.buttonZoomIn.Text = "+";
            this.buttonZoomIn.UseVisualStyleBackColor = false;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonLeft.Location = new System.Drawing.Point(34, 75);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(44, 23);
            this.buttonLeft.TabIndex = 14;
            this.buttonLeft.Text = "3";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonRight.Location = new System.Drawing.Point(137, 75);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(44, 23);
            this.buttonRight.TabIndex = 13;
            this.buttonRight.Text = "4";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.White;
            this.buttonDown.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonDown.Location = new System.Drawing.Point(85, 101);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(44, 23);
            this.buttonDown.TabIndex = 12;
            this.buttonDown.Text = "6";
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.White;
            this.buttonUp.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonUp.Location = new System.Drawing.Point(85, 44);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(44, 23);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "5";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(6, 61);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Скинути";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(6, 26);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(176, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Експортувати у PNG";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "b2 = ";
            // 
            // numB2
            // 
            this.numB2.DecimalPlaces = 1;
            this.numB2.Location = new System.Drawing.Point(58, 131);
            this.numB2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numB2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numB2.Name = "numB2";
            this.numB2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numB2.Size = new System.Drawing.Size(120, 22);
            this.numB2.TabIndex = 10;
            this.numB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numB2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numB2.ValueChanged += new System.EventHandler(this.Parameters_ValueChanged2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "a2 = ";
            // 
            // numA2
            // 
            this.numA2.DecimalPlaces = 1;
            this.numA2.Location = new System.Drawing.Point(58, 103);
            this.numA2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numA2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numA2.Name = "numA2";
            this.numA2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numA2.Size = new System.Drawing.Size(120, 22);
            this.numA2.TabIndex = 8;
            this.numA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numA2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numA2.ValueChanged += new System.EventHandler(this.Parameters_ValueChanged2);
            // 
            // checkCompare
            // 
            this.checkCompare.AutoSize = true;
            this.checkCompare.Location = new System.Drawing.Point(20, 77);
            this.checkCompare.Name = "checkCompare";
            this.checkCompare.Size = new System.Drawing.Size(176, 20);
            this.checkCompare.TabIndex = 2;
            this.checkCompare.Text = "Порівняти результати";
            this.checkCompare.UseVisualStyleBackColor = true;
            this.checkCompare.CheckedChanged += new System.EventHandler(this.checkCompare_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "b = ";
            // 
            // numB1
            // 
            this.numB1.DecimalPlaces = 1;
            this.numB1.Location = new System.Drawing.Point(58, 49);
            this.numB1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numB1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numB1.Name = "numB1";
            this.numB1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numB1.Size = new System.Drawing.Size(120, 22);
            this.numB1.TabIndex = 5;
            this.numB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numB1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numB1.ValueChanged += new System.EventHandler(this.Parameters_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "a = ";
            // 
            // numA1
            // 
            this.numA1.DecimalPlaces = 1;
            this.numA1.Location = new System.Drawing.Point(58, 21);
            this.numA1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numA1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numA1.Name = "numA1";
            this.numA1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numA1.Size = new System.Drawing.Size(120, 22);
            this.numA1.TabIndex = 3;
            this.numA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numA1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numA1.ValueChanged += new System.EventHandler(this.Parameters_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(245, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numA1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numB1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkCompare);
            this.groupBox1.Controls.Add(this.numA2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numB2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Налаштування параметрів";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUp);
            this.groupBox2.Controls.Add(this.buttonZoomOut);
            this.groupBox2.Controls.Add(this.buttonDown);
            this.groupBox2.Controls.Add(this.buttonZoomIn);
            this.groupBox2.Controls.Add(this.buttonRight);
            this.groupBox2.Controls.Add(this.buttonLeft);
            this.groupBox2.Location = new System.Drawing.Point(12, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управління координатними осями";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonExport);
            this.groupBox3.Controls.Add(this.buttonReset);
            this.groupBox3.Location = new System.Drawing.Point(12, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управління даними";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PascalSnailCurve_Khomenko.Properties.Resources.Formula;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PascalSnailCurve_Khomenko.Properties.Resources.Formula_Dodatok;
            this.pictureBox2.Location = new System.Drawing.Point(8, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureGraph
            // 
            this.pictureGraph.BackColor = System.Drawing.Color.White;
            this.pictureGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureGraph.Location = new System.Drawing.Point(0, 0);
            this.pictureGraph.Name = "pictureGraph";
            this.pictureGraph.Size = new System.Drawing.Size(1027, 604);
            this.pictureGraph.TabIndex = 0;
            this.pictureGraph.TabStop = false;
            this.pictureGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureGraph_Paint);
            // 
            // PascalSnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelConrol);
            this.Controls.Add(this.pictureGraph);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PascalSnail";
            this.Text = "Крива Равлик Паскаля";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureGraph;
        private System.Windows.Forms.Panel panelConrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numA1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numB2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numA2;
        private System.Windows.Forms.CheckBox checkCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numB1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

