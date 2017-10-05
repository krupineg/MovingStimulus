using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MovingStimulus
{
    public class StrategySelector : INotifyPropertyChanged
    {
        private readonly IEnumerable<IStrategy> _strategies;

        private IStrategy _currentStrategy;
        
        public IStrategy CurrentStrategy
        {
            get { return _currentStrategy; }
            set
            {
                _currentStrategy = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<IStrategy> AvailableStrategies
        {
            get { return _strategies; }
        }

        public StrategySelector(IEnumerable<IStrategy> strategies)
        {
            _strategies = strategies;
            CurrentStrategy = _strategies.First();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}