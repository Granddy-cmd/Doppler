namespace Doppler
{
    partial class Doppler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            frequencyTrackBar = new TrackBar();
            speedTrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            actualFrequencyValue = new Label();
            relativeSpeedValue = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frequencyTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(195, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(400, 400);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // frequencyTrackBar
            // 
            frequencyTrackBar.Location = new Point(195, 453);
            frequencyTrackBar.Name = "frequencyTrackBar";
            frequencyTrackBar.Size = new Size(400, 56);
            frequencyTrackBar.TabIndex = 1;
            frequencyTrackBar.ValueChanged += frequencyTrackBar_ValueChanged;
            // 
            // speedTrackBar
            // 
            speedTrackBar.Location = new Point(195, 530);
            speedTrackBar.Name = "speedTrackBar";
            speedTrackBar.Size = new Size(400, 56);
            speedTrackBar.TabIndex = 3;
            speedTrackBar.ValueChanged += relativeSpeedTrackBar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 452);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 4;
            label1.Text = "Actual frequency";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 530);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 5;
            label2.Text = "Relative speed";
            // 
            // actualFrequencyValue
            // 
            actualFrequencyValue.AutoSize = true;
            actualFrequencyValue.Location = new Point(617, 453);
            actualFrequencyValue.Name = "actualFrequencyValue";
            actualFrequencyValue.Size = new Size(17, 20);
            actualFrequencyValue.TabIndex = 6;
            actualFrequencyValue.Text = "0";
            // 
            // relativeSpeedValue
            // 
            relativeSpeedValue.AutoSize = true;
            relativeSpeedValue.Location = new Point(617, 530);
            relativeSpeedValue.Name = "relativeSpeedValue";
            relativeSpeedValue.Size = new Size(17, 20);
            relativeSpeedValue.TabIndex = 7;
            relativeSpeedValue.Text = "0";
            // 
            // Doppler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
            Controls.Add(relativeSpeedValue);
            Controls.Add(actualFrequencyValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(speedTrackBar);
            Controls.Add(frequencyTrackBar);
            Controls.Add(pictureBox);
            Name = "Doppler";
            Text = "Doppler";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)frequencyTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private TrackBar frequencyTrackBar;
        private TrackBar speedTrackBar;
        private Label label1;
        private Label label2;
        private Label actualFrequencyValue;
        private Label relativeSpeedValue;
    }
}