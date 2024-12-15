using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Krest_Nol
{
    public partial class Form2 : Form1
    {
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;
        private SoundPlayer soundButton;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Clear();
            this.BackgroundImage = Image.FromFile("fon.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            audioFile = new AudioFileReader("music_main.mp3");
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();

            soundButton = new SoundPlayer("click.wav");

            Button startButton = new Button();
            startButton.Text = "Начать игру";
            startButton.Size = new Size(200, 50);
            startButton.Location = new Point(this.Width / 2 - startButton.Width / 2, this.Height / 2 - startButton.Height / 2);
            startButton.Font = new Font(new FontFamily("Segoe Print"), 15);
            startButton.Click += StartButton_Click;
            startButton.BackColor = Color.White;
            this.Controls.Add(startButton);
           
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            soundButton.Play();
            Form1 gameForm = new Form1();
            gameForm.Show();

            this.Hide();
            outputDevice.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
