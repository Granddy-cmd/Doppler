namespace Doppler
{
    public static class FrequencyShiftCalculator
    {
        public static double CalculateRelativeFrequency(double angle = 0)
        {
            var coef = Variables.RelativeSpeed / Constants.LightSpeed;
            return Variables.ActualFrequency * (Math.Sqrt(1 - coef * coef) / (1 - coef * Math.Cos(DegreeToRadian(angle))));
        }

        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180;
        }
    }
}