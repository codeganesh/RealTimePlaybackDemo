using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace RealTimePlaybackDemo
{
    public partial class Form1 : Form
    {
        WaveIn wave;
        WaveOut waveOut;
        BufferedWaveProvider provider;
        public Form1()
        {
            InitializeComponent();
            LoadDevices();
        }

        private void LoadDevices()
        {
            for (int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveIn.GetCapabilities(deviceId);
                RecordingDeviceComboBox.Items.Add(deviceInfo.ProductName);
            }

            for (int deviceId = 0; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveOut.GetCapabilities(deviceId);
                PlaybackDeviceComboBox.Items.Add(deviceInfo.ProductName);
            }

        }
        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = false;
            StopButton.Enabled = true;

            wave = new WaveIn();
            wave.DeviceNumber = RecordingDeviceComboBox.SelectedIndex;

            waveOut = new WaveOut();
            waveOut.DeviceNumber = PlaybackDeviceComboBox.SelectedIndex;
            waveOut.DesiredLatency = 100;

            provider = new BufferedWaveProvider(wave.WaveFormat);
            waveOut.Init(provider);
            waveOut.Play();

            wave.DataAvailable += Wave_DataAvailable;
            wave.StartRecording();
        }

        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            provider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = true;
            StopButton.Enabled = false;
            wave.StopRecording();
            wave.Dispose();
            waveOut.Dispose();
        }
    }
}
