namespace Doppler.Models
{
    public class RGB
    {
        public int Red { get; init; }

        public int Green { get; init; }

        public int Blue { get; init; }

        public RGB(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}