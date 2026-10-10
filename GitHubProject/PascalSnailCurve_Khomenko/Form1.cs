using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PascalSnailCurve_Khomenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureGraph.Paint += pictureGraph_Paint;
            UpdateCompareStatus();
        }
        private float scale = 40f; 
        private float offsetX = 0f; 
        private float offsetY = 0f;
        private void pictureGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawcoordinateAxis(g);

            double a1 = (double)numA1.Value;
            double b1 = (double)numB1.Value;
            // Малюємо першу криву Паскаля

            if (checkCompare.Checked)
            {
                double a2 = (double)numA2.Value;
                double b2 = (double)numB2.Value;
                // Малюємо другу криву Паскаля
            }
        }
        private void UpdateCompareStatus()
        {
            bool enabled = checkCompare.Checked;
            numA2.Enabled = enabled;
            numB2.Enabled = enabled;
        }
        private void DrawcoordinateAxis(Graphics g)
        {
            int w = pictureGraph.Width;
            int h = pictureGraph.Height;
        }
       
        private void buttonReset_Click(object sender, EventArgs e)
        {
            scale = 40f;
            offsetX = 0f;
            offsetY = 0f;
            numA1.Value = 2.0M;
            numA2.Value = 3.0M;
            numB1.Value = 2.0M;
            numB2.Value = 3.0M;
            checkCompare.Checked = false;
            pictureGraph.Invalidate();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            offsetY += 30;
            pictureGraph.Invalidate();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            offsetX += 30;
            pictureGraph.Invalidate();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            offsetY -= 30;
            pictureGraph.Invalidate();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            offsetX -= 30;
            pictureGraph.Invalidate();
        }

        private void checkCompare_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompareStatus();
            pictureGraph.Invalidate();
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            scale *= 1.25f;
            pictureGraph.Invalidate();
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            scale /= 1.25f;
            pictureGraph.Invalidate();
        }
        private void Parameters_ValueChanged(object sender, EventArgs e)
        {
            pictureGraph.Invalidate();
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {

        }
    }
}
