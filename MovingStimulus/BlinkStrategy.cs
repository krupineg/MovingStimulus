using System.Windows;

namespace MovingStimulus
{
    public class BlinkStrategy : IStrategy
    {
        public void NextStep(Stimulus stimulus)
        {
            var x = ThreadLocalRandom.Next(1, 9);
            var y = ThreadLocalRandom.Next(1, 9);
            stimulus.Move((double)x /10, (double)y /10);
        }

        public override string ToString()
        {
            return "Random point";
        }
    }
}