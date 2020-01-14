using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
//using System.Windows.Input;
//using System.Windows.Controls;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;

namespace Search_Algorithms_Visualization
{
    public partial class Form1 : Form
    {
        Field AlgField = null;
        BackgroundWorker BGW = new BackgroundWorker() { WorkerSupportsCancellation = true };
        private Bitmap BitField;
        private bool LeftHeldDown;

        //static System.Drawing.Pen Outline = new System.Drawing.Pen(System.Drawing.Color.Black);

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
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 32;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 32;
            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.9375);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.9375);
        }

        private void FillField()
        {
            int SqSize = 2 * trackSizeCtrl.Value + 2;
            AlgField = new Field(SqSize, pictureBox1.Size);
            StatusUpdate();
            pictureBox1.Refresh();
            pictureBox1.Image = BitField;
        }

        private void StatusUpdate()
        {
            int SqSize = 2 * trackSizeCtrl.Value + 2;
            toolStripStatusLabelStatus.Text = "Square size: " + SqSize + "; Squares total: " + AlgField.Quantity + "; Dimensions: " + AlgField.Width + " x " + AlgField.Height + ";";
        }

        private void ResetMenu(object sender)
        {
            foreach (ToolStripMenuItem n in ((sender as ToolStripMenuItem).OwnerItem as ToolStripMenuItem).DropDownItems)
            {
                n.Checked = (n == (sender as ToolStripMenuItem));
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu(sender);
        }

        private void depthfirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu(sender);
        }

        private void breadthfirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu(sender);
        }

        private void bestfirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenu(sender);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tableLayoutPanelPauseStop.Visible = true;
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            if (searchWithToolStripMenuItem.Selected)
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
                    g.FillRectangle(GetBrush(AlgField.State[i, j]), AlgField.FieldArray[i, j]);
                    {
                        //if (i == 0 || j == 0 || i == (AlgField.Width - 1) || j == (AlgField.Height - 1))
                        //{
                        //    g.FillRectangle(AreaWall, AlgField.FieldArray[i, j]);
                        //}
                        //else g.FillRectangle(AreaUnchecked, AlgField.FieldArray[i, j]);
                        //{
                        //    //if (!done)
                        //    //{
                        //    //    g.DrawLine(Outline, AlgField.FieldArray[0, j].Location.X, AlgField.FieldArray[0, j].Location.Y,
                        //    //AlgField.FieldArray[AlgField.Width - 1, j].Location.X + AlgField.Size, AlgField.FieldArray[AlgField.Width - 1, j].Location.Y);
                        //    //}
                        //}
                    }
                }
                {
                    //done = true;
                    //g.DrawLine(Outline, AlgField.FieldArray[i, 0].Location.X, AlgField.FieldArray[i, 0].Location.Y,
                    //    AlgField.FieldArray[i, AlgField.Height - 1].Location.X, AlgField.FieldArray[i, AlgField.Height - 1].Location.Y + AlgField.Size);
                }
            }

            g.Dispose();
        }

        private Brush GetBrush(Field.EStates eStates)
        {
            switch ((int)eStates)
            {
                case 0:
                    return new SolidBrush(System.Drawing.Color.DimGray); // Free Space
                case 1:
                    return new SolidBrush(System.Drawing.Color.Black); // Wall Placed
                case 2:
                    return new SolidBrush(System.Drawing.Color.Snow); // Area Scanned
                case 3:
                    return new SolidBrush(System.Drawing.Color.Firebrick); // Path Paved
                default:
                    throw new ArgumentOutOfRangeException("Error 01: Object state is out of range - Brush unsupported.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            AlgField.Alter(new Point(Cursor.Position.X, Cursor.Position.Y));
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftHeldDown = false;
                AlgField.ResetLocks();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftHeldDown = true;
            }
            //pictureBox1.Invalidate(new Rectangle(MousePosition.X - (int)(1.2f * AlgField.Size), MousePosition.Y - (int)(1.2f * AlgField.Size), (int)(1.2f * AlgField.Size), (int)(1.2f * AlgField.Size)));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (LeftHeldDown)
            {
                AlgField.Alter(new Point(e.X, e.Y));
                pictureBox1.Invalidate();
            }
        }
    }
}
