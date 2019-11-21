using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
//using System.Windows.Input;
//using System.Windows.Controls;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;

namespace Search_Algorithms_Visualization
{
    public partial class Form1 : Form
    {
        int SqSize = 3;
        int Quant = 0;
        Field AlgField = null;
        BackgroundWorker BGW = new BackgroundWorker() { WorkerSupportsCancellation = true };
        private Bitmap BitField;

        static System.Drawing.Pen Outline = new System.Drawing.Pen(System.Drawing.Color.Black);
        static SolidBrush AreaChecked = new SolidBrush(System.Drawing.Color.Snow);
        static SolidBrush AreaWall = new SolidBrush(System.Drawing.Color.Black);
        static SolidBrush AreaUnchecked = new SolidBrush(System.Drawing.Color.DimGray);
        static SolidBrush AreaRoute = new SolidBrush(System.Drawing.Color.Firebrick);

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonStartPause.BringToFront();
            buttonStop.Visible = false;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 16;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 16;
            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.875);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.875);
            //pictureBox1.Width = (int)(this.Width * 0.75);
        }

        private void FillField()
        {
            //BitField.Dispose();
            //BitField = new Bitmap(pictureBox1.Width, pictureBox1.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            SqSize = 2 * trackSizeCtrl.Value + 2;
            AlgField = new Field(SqSize, pictureBox1.Size);
            StatusUpdate();
            pictureBox1.Image = BitField;
            pictureBox1.Invalidate();
        }

        private void StatusUpdate()
        {
            SqSize = 4 * trackSizeCtrl.Value + 2;
            Quant = AlgField.Quantity;
            toolStripStatusLabelStatus.Text = "Square size: " + SqSize + "; Squares total: " + Quant + ";";
        }

        private void ResetMenu()
        {
            foreach (ToolStripMenuItem n in searchWithToolStripMenuItem.DropDownItems)
            {
                n.Checked = false;
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu();
            aToolStripMenuItem.Checked = true;
        }

        private void depthfirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu();
            depthfirstToolStripMenuItem.Checked = true;
        }

        private void breadthfirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu();
            breadthfirstToolStripMenuItem.Checked = true;
        }

        private void bestfirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu();
            bestfirstToolStripMenuItem.Checked = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tableLayoutPanelPauseStop.Visible = true;
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            if (!buttonStop.Visible)
            {
                buttonStartPause.Text = "Pause";
                buttonStop.Visible = true;
            }
            else
            {
                buttonStartPause.Text = (buttonStartPause.Text == "Pause" ? "Continue" : "Pause");
            }
        }

        private void trackSizeCtrl_ValueChanged(object sender, EventArgs e)
        {
            FillField();
            pictureBox1.Refresh();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Visible = false;
            buttonStartPause.Text = "Start";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FillField();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            BitField = new Bitmap(pictureBox1.Width, pictureBox1.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            g = Graphics.FromImage(BitField);
            g.Clear(Color.White);

            for (int i = 0; i < AlgField.Width; i++)
            {
                for (int j = 0; j < AlgField.Height; j++)
                {
                    //g.DrawRectangle(Outline, AlgField.FieldArray[i, j]);
                    if (i == 0 || j == 0 || i == (AlgField.Width - 1) || j == (AlgField.Height - 1))
                    {
                        g.FillRectangle(AreaWall, AlgField.FieldArray[i, j]);
                    }
                    else g.FillRectangle(AreaUnchecked, AlgField.FieldArray[i, j]);
                    {
                        //if (!done)
                        //{
                        //    g.DrawLine(Outline, AlgField.FieldArray[0, j].Location.X, AlgField.FieldArray[0, j].Location.Y,
                        //AlgField.FieldArray[AlgField.Width - 1, j].Location.X + AlgField.Size, AlgField.FieldArray[AlgField.Width - 1, j].Location.Y);
                        //}
                    }

                }
                {
                    //done = true;
                    //g.DrawLine(Outline, AlgField.FieldArray[i, 0].Location.X, AlgField.FieldArray[i, 0].Location.Y,
                    //    AlgField.FieldArray[i, AlgField.Height - 1].Location.X, AlgField.FieldArray[i, AlgField.Height - 1].Location.Y + AlgField.Size);
                }

            }
            {
                //g.DrawLine(Outline, AlgField.FieldArray[AlgField.Width - 1, 0].Location.X + AlgField.Size, AlgField.FieldArray[AlgField.Width - 1, 0].Location.Y,
                //    AlgField.FieldArray[AlgField.Width - 1, AlgField.Height - 1].Location.X + AlgField.Size, AlgField.FieldArray[AlgField.Width - 1, AlgField.Height - 1].Location.Y + AlgField.Size);
                //g.DrawLine(Outline, AlgField.FieldArray[0, AlgField.Height - 1].Location.X, AlgField.FieldArray[0, AlgField.Height - 1].Location.Y + AlgField.Size,
                //    AlgField.FieldArray[AlgField.Width - 1, AlgField.Height - 1].Location.X + AlgField.Size, AlgField.FieldArray[AlgField.Width - 1, AlgField.Height - 1].Location.Y + AlgField.Size);
            }
            //g.DrawImage(BitField,new Point(0,0));
            //g.DrawImage(BitField, 0, 0, BitField.Width, BitField.Height);
            g.Dispose();
        }

        private void trackSizeCtrl_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
