using System.Drawing;

namespace Search_Algorithms_Visualization
{
    public class Field
    {
        public enum EStates : byte
        {
            FreeSpace,
            WallPlaced,
            AreaScanned,
            PathPaved
        }
        public int Size { get; private set; }
        private int PanelWidth { get; set; }
        private int PanelHeight { get; set; }
        private int OffsetH { get; set; }
        private int OffsetV { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Quantity { get; private set; }
        public Rectangle[,] FieldArray { get; private set; }
        public bool[,] Lock { get; private set; }
        public EStates[,] State { get; private set; }

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
            bool[,] TmpLocks = new bool[Width, Height];
            EStates[,] TmpStates = new EStates[Width, Height];
            OffsetH = (PanelWidth - ((Width * Size) + (Width - 1))) / 3;
            OffsetV = (PanelHeight - ((Height * Size) + (Height - 1))) / 3;

            for (int m = 0; m < Width; m++)
            {
                for (int n = 0; n < Height; n++)
                {
                    TmpRect[m, n] = new Rectangle(new Point(OffsetH + (m * (Size + 1)), OffsetV + (n * (Size + 1))), new Size(Size, Size));
                    TmpLocks[m, n] = false;
                    if (m == 0 || m == Width - 1 || n == 0 || n == Height - 1) TmpStates[m, n] = EStates.WallPlaced;
                    else TmpStates[m, n] = EStates.FreeSpace;
                }
            }
            State = TmpStates;
            Lock = TmpLocks;
            return TmpRect;
        }

        public void ResetLocks()
        {
            Lock.Initialize();
        }

        public void Alter(Point position)
        {
            int xCheck = (position.X - OffsetH) / (Size + 1);
            int yCheck = (position.Y - OffsetV) / (Size + 1);
            if ((xCheck < 0 || yCheck < 0) || (xCheck > Width || xCheck > Height)) return;
            if (Lock[xCheck, yCheck] == false)
            {
                if (State[xCheck, yCheck] == EStates.WallPlaced && !IsOnEdge(xCheck, yCheck))
                {
                    State[xCheck, yCheck] = EStates.FreeSpace;
                }
                else State[xCheck, yCheck] = EStates.WallPlaced;
                Lock[xCheck, yCheck] = true;
            }
        }

        public bool IsOnEdge(int m, int n)
        {
            if (m == 0 || m == Width - 1 || n == 0 || n == Height - 1) return true;
            else return false;
        }
    }
}
