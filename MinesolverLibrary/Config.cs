using Windows.ApplicationModel.Calls;

namespace MinesolverLibrary
{
    public struct Config 
    {
        private Dimension _screenSize;
        private Dimension _boardSize;
        private int _squareSpacing;
        private Point _firstSquarePosition;

        public Dimension ScreenSize
        {
            get { return _screenSize; }
            set { _screenSize = value; }
        }
        public Dimension BoardSize 
        {
            get { return _boardSize; }
            set { _boardSize = value; }
        }
        public int SquareSpacing 
        {
            get { return _squareSpacing; }
            set { _squareSpacing = value; }
        }
        public Point FirstSquarePosition 
        {
            get { return _firstSquarePosition; }
            set { _firstSquarePosition = value; }
        }

        public Config(Dimension inScreenSize, Dimension inBoardSize, int inSquareSpacing, Point _inFirstSquarePosition)
        {
            ScreenSize = inScreenSize;
            BoardSize = inBoardSize;
            SquareSpacing = inSquareSpacing;
            FirstSquarePosition = _inFirstSquarePosition;
        }
        public override string ToString()
        {
            return 
                $"Screen Size: {ScreenSize.ToString()}\n" +
                $"Board Size: {BoardSize.ToString()}\n" +
                $"Square Spacing: {SquareSpacing.ToString()}\n" +
                $"First Square Pos: {FirstSquarePosition.ToString()}\n";
        }
    }
}
