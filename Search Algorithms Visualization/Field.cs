using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithms_Visualization
{
    public class Field
    {
        public int Size { get; private set; }
        private int PanelWidth { get; set; }
        private int PanelHeight { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Quantity { get; private set; }
        public Rectangle[,] FieldArray { get; private set; }
        
        

        public Field(int sqSize, Size size)
        {
            Size = sqSize;
            PanelWidth = size.Width;
            PanelHeight = size.Height;
            Width = size.Width / (sqSize + 1) - 1;
            Height = size.Height / (sqSize + 1) - 1;
            Quantity = Width * Height;
            FieldArray = CreateField();
        }

        private Rectangle[,] CreateField()
        {
            Rectangle[,] TmpRect = new Rectangle[Width, Height];
            int OffsetH = (PanelWidth - ((Width * Size) + (Width - 1))) / 3;
            int OffsetV = (PanelHeight - ((Height * Size) + (Height - 1))) / 3;

            for (int m = 0; m < Width; m++)
            {
                for (int n = 0; n < Height; n++)
                {
                    TmpRect[m, n] = new Rectangle(new Point(OffsetH + (m * (Size + 1)), OffsetV + n + (n * Size)), new Size(Size, Size));
                }
            }
            return TmpRect;
        }
    }
}
