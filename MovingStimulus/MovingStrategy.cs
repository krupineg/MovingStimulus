namespace MovingStimulus
{
    public class MovingStrategy : IStrategy
    {
        private int _directionLength;
        private int _directionDone;
        private double _dx, _dy;
        public void NextStep(Stimulus stimulus)
        {
            if (DirectionAwaiting())
            {
                PrepareDirection();
            }
            MoveStimulusToNewPoint(stimulus);
        }

        private void MoveStimulusToNewPoint(Stimulus stimulus)
        {
            _directionDone++;
            var x = _dx + stimulus.X;
            var y = _dy + stimulus.Y;
            if (IsInAvailableBounds(x, y))
            {
                stimulus.Move(x, y);
            }
            else
            {
                _directionLength = 0;
            }
        }

        private static bool IsInAvailableBounds(double x, double y)
        {
            return x > 0.05 && x < 0.95 && y > 0.05 && y < 0.95;
        }

        private void PrepareDirection()
        {
            _directionDone = 0;
            _directionLength = ThreadLocalRandom.Next(20);
            _dx = (double)ThreadLocalRandom.Next(-10, 10) / 500;
            _dy = (double)ThreadLocalRandom.Next(-10, 10) / 500;
        }

        private bool DirectionAwaiting()
        {
            return _directionLength == 0 || _directionLength == _directionDone;
        }

        public override string ToString()
        {
            return "Moving point";
        }
    }
}