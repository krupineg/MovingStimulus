using System.Threading.Tasks;

namespace MovingStimulus
{
    public class MainViewModel
    {
        public int Delay { get; set; }
        public Stimulus Stimulus { get; }
        public StrategySelector StrategySelector { get; }
        public MainViewModel(Stimulus stimulus, int delay, StrategySelector strategySelector)
        {
            Stimulus = stimulus;
            Delay = delay;
            StrategySelector = strategySelector;
            Task.Run(MainLoop);
        }

        private async Task MainLoop()
        {
            while (true)
            {
                await Task.Delay(Delay);
                StrategySelector.CurrentStrategy.NextStep(Stimulus);
            }
        }
    }
}