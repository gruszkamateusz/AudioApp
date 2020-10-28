using NAudio.Wave;
using System;
using System.Windows.Forms;
using System.IO;


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
        private WMPLib.WindowsMediaPlayer Player;
        //Tablica na nagłówek pliku WAV
        private char [] chunkID;

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
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
                
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

       

        private void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.play();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Close();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }

        private void buttonWMP_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " MP3 File (*.mp3)|*.mp3;";
            if (open.ShowDialog() != DialogResult.OK) return;
            PlayFile(open.FileName); //odtwarza plik .mp3 z podanego adresu URL
        }

        private void buttonReadHeader_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Wave File (*.wav)|*.wav;";
            open.ShowDialog();

            using (BinaryReader reader = new BinaryReader(File.Open(open.FileName, FileMode.Open)))
            {
                chunkID = reader.ReadChars(44);
            }

            Console.WriteLine("ChunkID is set to: " + chunkID[0] + chunkID[1] + chunkID[2] + chunkID[3]);

        }
    }
}
