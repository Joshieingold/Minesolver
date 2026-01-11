using Microsoft.UI.Xaml;
using MinesolverLibrary;
using System;

namespace MinesolverUI
{
    public sealed partial class MainWindow : Window
    {
        private Config _currentConfig;
        public Config CurrentConfig
        {
            get { return _currentConfig; }
            set { _currentConfig = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        // Generating Config
        private Config GetConfig()
        {
            Point inFirstSquare = GetFirstSquare();
            Dimension inScreenSize = GetScreenSize();
            Dimension inBoardSize = GetBoardSize();
            int inSquareSpacing = GetSquareSpacing();
            return new Config(inScreenSize, inBoardSize, inSquareSpacing, inFirstSquare);
        } 
        private int GetSquareSpacing()
        {
            return Convert.ToInt32(txtSquareSpacing.Text);
        }
        private Point GetFirstSquare()
        {
            int x = Convert.ToInt32(txtFirstSquarePositionX.Text);
            int y = Convert.ToInt32(txtFirstSquarePositionY.Text);
            return new Point(x, y);
        }
        private Dimension GetScreenSize()
        {
            int inWidth = Convert.ToInt32(txtScreenWidth.Text);
            int inHeight = Convert.ToInt32(txtScreenHeight.Text);
            return new Dimension(inWidth, inHeight);
        }
        private Dimension GetBoardSize()
        {
            int inWidth = Convert.ToInt32(txtBoardWidth.Text);
            int inHeight = Convert.ToInt32(txtBoardHeight.Text);
            return new Dimension(inWidth, inHeight);
        }

        private void Start_click(object sender, RoutedEventArgs e)
        {
            CurrentConfig = GetConfig();
            Console.WriteLine(CurrentConfig.ToString());
        }
    }
}
