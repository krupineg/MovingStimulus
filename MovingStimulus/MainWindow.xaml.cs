using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovingStimulus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int DefaultDelay = 1000;
        public MainWindow()
        {
            InitializeComponent();
            CompositionRoot();
        }

        private void CompositionRoot()
        {
            var stimulus = new Stimulus(0.5, 0.5);
            var strategies = new List<IStrategy>()
            {
                new StopStrategy(), new BlinkStrategy(), new MovingStrategy()
            };
            var strategySelector = new StrategySelector(strategies);
            var mainViewModel = new MainViewModel(stimulus, DefaultDelay, strategySelector);
            DataContext = mainViewModel;
        }
    }
}
