using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovingStimulus
{
    public class Stimulus : INotifyPropertyChanged
    {
        private double _x;
        private double _y;
        private bool _isVisible;

        public Stimulus(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X
        {
            get { return _x; }
            set
            {
                _x = value; 
                OnPropertyChanged();
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged();
            }
        }

        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged();
            }
        }

        public void Move(double x, double y)
        {
            IsVisible = false;
            X = x;
            Y = y;
            IsVisible = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}