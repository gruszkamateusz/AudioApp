using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace AudioApp
{
    public partial class AudioApp : Form
    {
        public AudioApp()
        {
            InitializeComponent();
        }
        private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut output = null;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Wave File (*.wav)|*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeWave(); 

            wave = new NAudio.Wave.WaveFileReader(open.FileName);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(new NAudio.Wave.WaveChannel32(wave));
            output.Play();

            pauseBtn.Enabled = true;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if(output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
                output.Dispose();
                output = null;
            }
        }
        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
                if (wave != null)
            {
                wave.Dispose();
                wave = null;
            }
        }

        private void AudioApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }
    }
}
