namespace MovingStimulus
{
    public class StopStrategy :IStrategy
    {
        public void NextStep(Stimulus stimulus)
        {
        }

        public override string ToString()
        {
            return "Stop";
        }
    }
}