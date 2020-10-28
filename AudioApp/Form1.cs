﻿using NAudio.Wave;
using System;
using System.Collections.Generic;
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
        private WMPLib.WindowsMediaPlayer Player;


        //otwieranie pliku wav
        private void openBtn_Click(object sender, EventArgs e)
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
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
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

        private void sourceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void refBtn_Click(object sender, EventArgs e)
        {
            // tworzymy liste mozliwych zrodel dzwieku,
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();
            for(int i=0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i)); // dodajemy zrodla do listy sources
            }
            sourceList.Items.Clear(); // upewniamy sie ze lista sourceList w oknie jest pusta
            foreach(var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);   // tworzymy obiekt listy w oknie
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                sourceList.Items.Add(item); // dodajemy do listy w oknie
            }

        }
        private NAudio.Wave.WaveIn sourceStream = null;    // wejscie 
        private NAudio.Wave.DirectSoundOut waveOut = null; // wyjscie
        private NAudio.Wave.WaveFileWriter waveWriter = null; // zapisywanie pliku

        // wywolanie dispose oraz zatrzymanie i ustawienie na null wszystkiego co uzywamy
        private void stopBtn_Click(object sender, EventArgs e)
        {
            if( waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if(waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
        }
        // WaveInEventArgs - jesli zmienia się pobierany dzwiek to
        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded); //buforujemy dane
            waveWriter.Flush(); // czyszczenie buforu dla tego strumienia

        }

        private void waveBtn_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0) return;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave File (*.wav)|*.wav;";
            // jesli cos sie nie zgadza sie w oknie dialogowym - return
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) return; 

            int deviceNumber = sourceList.SelectedItems[0].Index;
            sourceStream = new NAudio.Wave.WaveIn(); // przechowuje to co wchodzi 
            sourceStream.DeviceNumber = deviceNumber; // z danego urzadzenia
            // format strumienia
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);
            // kiedy jest mozliwe pobranie nowych danych - pobierz ze strumienia
            sourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
            // zapisz plik o takiej nazwie w formacie wav
            waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
        }
    }
}
