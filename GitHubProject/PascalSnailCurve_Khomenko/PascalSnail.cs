using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PascalSnailCurve_Khomenko
{
    public partial class PascalSnail : Form
    {
        public PascalSnail()
        {
            InitializeComponent();
            pictureGraph.Paint += pictureGraph_Paint;
            UpdateCompareStatus();
            SetStatus("Система координат ініціалізована. Змініть параметри a та b для дослідження");
        }
        private float scale = 40f; // масштабування графіка (40 пікселів == 1 одиниця)
        private float offsetX = 0f; // зсув центру графіка
        private float offsetY = 0f;
        private void pictureGraph_Paint(object sender, PaintEventArgs e) // все, що малюється на графіку
        {
            Graphics graphic = e.Graphics;
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //зглажування країв замість пікселів 
            DrawСoordinateAxis(graphic);

            double a1 = (double)numA1.Value;
            double b1 = (double)numB1.Value;
            DrawPascalSnailCurve(graphic, a1, b1, Color.Blue, 1.5f);// Малюємо першу криву Паскаля

            if (checkCompare.Checked)
            {
                double a2 = (double)numA2.Value;
                double b2 = (double)numB2.Value;
                DrawPascalSnailCurve(graphic, a2, b2, Color.Red, 1.5f);// Малюємо другу криву Паскаля
            }
        }
        private void DrawСoordinateAxis(Graphics graphic)
        {
            int w = pictureGraph.Width;
            int h = pictureGraph.Height;

            PointF center = CartesianCoordTransform(0, 0, w, h); // центр координат

            using (Pen axis = new Pen(Color.Black, 1.5f)) //осі координат
            {
                graphic.DrawLine(axis, 0, center.Y, w, center.Y);
                graphic.DrawLine(axis, center.X, 0, center.X, h);
            }
            using (Pen line = new Pen(Color.Black, 1.5f)) // лінії сітки
            {
                float step = scale; //крок сітки
                float valueStep = 1f;
                if (step < 10)
                {
                    step = 10;
                    valueStep = 10f / scale;
                }

                //X
                float currentValue = valueStep;
                for (float x = center.X + step; x < w; x += step)
                {
                    graphic.DrawLine(line, x, center.Y - 4, x, center.Y + 4);
                    currentValue += valueStep;
                }
                currentValue = -valueStep;
                for (float x = center.X - step; x > 0; x -= step)
                {
                    graphic.DrawLine(line, x, center.Y - 4, x, center.Y + 4);
                    currentValue -= valueStep;
                }
                //Y
                currentValue = valueStep;
                for (float y = center.Y - step; y > 0; y -= step)
                {
                    graphic.DrawLine(line, center.X - 4, y, center.X + 4, y);
                    currentValue += valueStep;
                }
                currentValue = -valueStep;
                for (float y = center.Y + step; y < h; y += step)
                {
                    graphic.DrawLine(line, center.X - 4, y, center.X + 4, y);
                    currentValue -= valueStep;
                }
            }
        }
        private PointF CartesianCoordTransform(double x, double y, int w, int h)
        {
            float screenX = w / 2f + offsetX + (float)(x * scale); // перетворення + центрування графіка на середину вікна
            float screenY = h / 2f + offsetY - (float)(y * scale); //спеціфікація комп екрану
            return new PointF(screenX, screenY);
        }
        private void DrawPascalSnailCurve(Graphics graphic, double a, double b, Color color, float width)
        {
            List<PointF> points = new List<PointF>();
            double step = 0.01;

            for (double t = 0; t < 2 * Math.PI; t += step)
            {
                //за рівнянням:
                double x = a * Math.Cos(2 * t) + b * Math.Cos(t);
                double y = -a * Math.Cos(t) * Math.Sin(t) + b * Math.Sin(t);

                points.Add(CartesianCoordTransform(x, y, pictureGraph.Width, pictureGraph.Height));
            }

            if (points.Count > 1)
            {
                using (Pen pen = new Pen(color, width))
                {
                    graphic.DrawLines(pen, points.ToArray());
                }
            }
        }





        private void UpdateCompareStatus()
        {
            bool enabled = checkCompare.Checked;
            numA2.Enabled = enabled;
            numB2.Enabled = enabled;
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
            SetStatus("Створено новий об'єкт моделювання. Параметри та масштаб скинуто до початкових");
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
            SetStatus("СК зміщено вгору");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            offsetX -= 30;
            pictureGraph.Invalidate();
            SetStatus("СК зміщено вправо");
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            offsetY -= 30;
            pictureGraph.Invalidate();
            SetStatus("СК зміщено вниз");
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            offsetX += 30;
            pictureGraph.Invalidate();
            SetStatus("СК зміщено вліво");
        }

        private void checkCompare_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCompareStatus();
            if (checkCompare.Checked)
            {
                SetStatus("Режим порівняння увімкнено: нанесіть другу криву з новими параметрами");
            }
            else
            {
                SetStatus("Режим порівняння вимкнено");
            }
            pictureGraph.Invalidate();
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            scale *= 1.25f;
            pictureGraph.Invalidate();
            SetStatus($"Масштаб збільшено. Поточний масштаб: {scale:0.00} пікс/од.");
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            scale /= 1.25f;
            pictureGraph.Invalidate();
            SetStatus($"Масштаб зменшено. Поточний масштаб: {scale:0.00} пікс/од.");
        }
        private void Parameters_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)numA1.Value;
            double b = (double)numB1.Value;
            string infoType;
            if (a > b) infoType = "з петлею";
            else if (a < b) infoType = "з угином";
            else infoType = "без петлі та угину";
            SetStatus($"Параметри Кривої 1 змінено: a = {a}, b = {b} | Вид кривої: {infoType} | Масштаб: {scale:0.00} пікс/од.");
            pictureGraph.Invalidate();
        }
        private void Parameters_ValueChanged2(object sender, EventArgs e)
        {
            double a = (double)numA2.Value;
            double b = (double)numB2.Value;
            string infoType;
            if (a > b) infoType = "з петлею";
            else if (a < b) infoType = "з угином";
            else infoType = "без петлі та угину";
            SetStatus($"Параметри Кривої 2 змінено: a = {a}, b = {b} | Вид кривої: {infoType} | Масштаб: {scale:0.00} пікс/од.");
            pictureGraph.Invalidate();
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureGraph.Width, pictureGraph.Height); //пустий малюнок
            pictureGraph.DrawToBitmap(bmp, new Rectangle(0, 0, pictureGraph.Width, pictureGraph.Height)); //перемалювання графіка на малюнок

            using (SaveFileDialog sfd = new SaveFileDialog()) //збереження
            {
                sfd.Filter = "PNG Image|*.png";
                if (sfd.ShowDialog() == DialogResult.OK) bmp.Save(sfd.FileName);
                SetStatus($"Результати успішно експортовано у файл: {sfd.FileName}");
            }
            bmp.Dispose(); //видалення малюнка
        }
        private void SetStatus(string message)
        {
            if (toolStripStatusLabel1 != null)
            {
                toolStripStatusLabel1.Text = message;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panelConrol_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
