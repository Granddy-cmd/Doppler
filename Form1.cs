namespace Doppler
{
    public partial class Doppler : Form
    {
        private const int _minActualFrequency = 384;

        private const int _minRelativeSpeed = 1;

        private const double _frequencyPrecision = 1e12;

        private const double _speedPrecision = 1e6;

        public Doppler()
        {
            InitializeComponent();
            frequencyTrackBar.Minimum = _minActualFrequency;
            frequencyTrackBar.Maximum = 789;
            speedTrackBar.Minimum = _minRelativeSpeed;
            speedTrackBar.Maximum = 300;

            Variables.ActualFrequency = _minActualFrequency * _frequencyPrecision;
            Variables.RelativeSpeed = _minRelativeSpeed * _speedPrecision;
            frequencyTrackBar.Value = _minActualFrequency;
            speedTrackBar.Value = _minRelativeSpeed;
            actualFrequencyValue.Text = $"{frequencyTrackBar.Value}e12 Hz";
            relativeSpeedValue.Text = $"{speedTrackBar.Value / 1e2}e8 m/sec";
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Draw(e);
        }

        private void Draw(PaintEventArgs e)
        {
            var actualRgb = FrequncyToRGBConverter.ConvertFrequencyToRGB(Variables.ActualFrequency);

            DrawCircle(e, actualRgb.Red, actualRgb.Green, actualRgb.Blue, 10, 10);

            var frequency = FrequencyShiftCalculator.CalculateRelativeFrequency();

            var relativeRgb = FrequncyToRGBConverter.ConvertFrequencyToRGB(frequency);

            DrawCircle(e, relativeRgb.Red, relativeRgb.Green, relativeRgb.Blue, 150, 10);
        }

        private void DrawCircle(PaintEventArgs e, int red, int green, int blue, int x, int y)
        {
            Pen pen = new Pen(Color.FromArgb(red, green, blue), 2);
            Brush brush = new SolidBrush(Color.FromArgb(red, green, blue));
            Rectangle rect = new Rectangle(x, y, 100, 100);

            e.Graphics.DrawEllipse(pen, rect);
            e.Graphics.FillEllipse(brush, rect);
        }

        private void frequencyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Variables.ActualFrequency = frequencyTrackBar.Value * _frequencyPrecision;
            actualFrequencyValue.Text = $"{frequencyTrackBar.Value}e12 Hz";
            pictureBox.Refresh();
        }

        private void relativeSpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Variables.RelativeSpeed = speedTrackBar.Value * _speedPrecision;
            relativeSpeedValue.Text = $"{speedTrackBar.Value / 1e2}e8 m/sec";
            pictureBox.Refresh();
        }
    }
}