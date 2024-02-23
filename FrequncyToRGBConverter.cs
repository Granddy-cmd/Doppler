using Doppler.Models;

namespace Doppler
{
    public static class FrequncyToRGBConverter
    {
        public static RGB ConvertFrequencyToRGB(double frequency)
        {
            double wavelength = Constants.LightSpeed / frequency * 10e8;
            double gamma = 0.8;
            double intensityMax = 255;
            double factor;
            double red, green, blue;

            if ((wavelength >= 380) && (wavelength < 440))
            {
                red = -(wavelength - 440) / (440 - 380);
                green = 0.0;
                blue = 1.0;
            }
            else if ((wavelength >= 440) && (wavelength < 490))
            {
                red = 0.0;
                green = (wavelength - 440) / (490 - 440);
                blue = 1.0;
            }
            else if ((wavelength >= 490) && (wavelength < 510))
            {
                red = 0.0;
                green = 1.0;
                blue = -(wavelength - 510) / (510 - 490);
            }
            else if ((wavelength >= 510) && (wavelength < 580))
            {
                red = (wavelength - 510) / (580 - 510);
                green = 1.0;
                blue = 0.0;
            }
            else if ((wavelength >= 580) && (wavelength < 645))
            {
                red = 1.0;
                green = -(wavelength - 645) / (645 - 580);
                blue = 0.0;
            }
            else if ((wavelength >= 645) && (wavelength < 780))
            {
                red = 1.0;
                green = 0.0;
                blue = 0.0;
            }
            else
            {
                red = 0.0;
                green = 0.0;
                blue = 0.0;
            }

            // Adjust intensity
            if ((wavelength >= 380) && (wavelength < 420))
            {
                factor = 0.3 + 0.7 * (wavelength - 380) / (420 - 380);
            }
            else if ((wavelength >= 420) && (wavelength < 645))
            {
                factor = 1.0;
            }
            else if ((wavelength >= 645) && (wavelength < 780))
            {
                factor = 0.3 + 0.7 * (780 - wavelength) / (780 - 645);
            }
            else
            {
                factor = 0.0;
            }

            // Adjust intensity
            red = Math.Round(intensityMax * Math.Pow(red * factor, gamma));
            green = Math.Round(intensityMax * Math.Pow(green * factor, gamma));
            blue = Math.Round(intensityMax * Math.Pow(blue * factor, gamma));

            return new RGB((int)red, (int)green, (int)blue);
        }
    }
}