using Microsoft.UI.Xaml;
using MinesolverLibrary;

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
    }
}
