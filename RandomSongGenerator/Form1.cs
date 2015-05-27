using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;





namespace RandomSongGenerator
{
    public partial class Form1 : Form
    {
        MelodyGenerator melodyGenerator = new MelodyGenerator();
        Audioplayer audioPlayer = new Audioplayer();
        
        public Form1()
        {
            InitializeComponent();

            tempoInput.Maximum = Audioplayer.MAX_TEMPO; 
            tempoInput.Minimum = Audioplayer.MIN_TEMPO; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void PlayMaryButton(object sender, EventArgs e)
        {
            
            
            /*
            //gotta add something for a test cmmit. 
            var p1 = new System.Media.Windows.MediaPlayer();
            p1.Open(new System.Uri(@"C:\windows\media\tada.wav"));
            p1.Play();

            // this sleep is here just so you can distinguish the two sounds playing simultaneously
            //System.Threading.Thread.Sleep(500);

            var p2 = new System.Windows.Media.MediaPlayer();
            p2.Open(new System.Uri(@"C:\windows\media\tada.wav"));
            p2.Play();

            new System.Threading.Thread(() =>
            {
                var c = new System.Windows.Media.MediaPlayer();
                c.Open(new System.Uri(@"C:\users\katherine\desktop\solo.wav"));
                c.Play();
            }).Start();

            System.Threading.Thread.Sleep(500);

            new System.Threading.Thread(() =>
            {
                var c = new System.Windows.Media.MediaPlayer();
                c.Open(new System.Uri(@"C:\users\katherine\desktop\solo.wav"));
                c.Play();
            }).Start();
             */ 
        }

        private void PlaySmokeButton_Click(object sender, EventArgs e)
        {
            audioPlayer.Play(PreloadedMelody.Mary, (int)tempoInput.Value);
        }

        private void PlaySeptatonicScale_Click(object sender, EventArgs e)
        {
            Scale a_Aeolien = RandomSongGenerator.Scale.GetAminorSeptatonicScale();

            Note note1 = new Note(a_Aeolien.noteCollection[0], Duration.QUARTER);
            Note note2 = new Note(a_Aeolien.noteCollection[1], Duration.QUARTER);
            Note note3 = new Note(a_Aeolien.noteCollection[2], Duration.QUARTER);
            Note note4 = new Note(a_Aeolien.noteCollection[3], Duration.QUARTER);
            Note note5 = new Note(a_Aeolien.noteCollection[4], Duration.QUARTER);
            Note note6 = new Note(a_Aeolien.noteCollection[5], Duration.QUARTER);
            Note note7 = new Note(a_Aeolien.noteCollection[6], Duration.QUARTER);
            Note note8 = new Note(a_Aeolien.noteCollection[7], Duration.QUARTER);

            audioPlayer.Play(note1, (int)tempoInput.Value);
            audioPlayer.Play(note2, (int)tempoInput.Value);
            audioPlayer.Play(note3, (int)tempoInput.Value);
            audioPlayer.Play(note4, (int)tempoInput.Value);
            audioPlayer.Play(note5, (int)tempoInput.Value);
            audioPlayer.Play(note6, (int)tempoInput.Value);
            audioPlayer.Play(note7, (int)tempoInput.Value);
            audioPlayer.Play(note8, (int)tempoInput.Value);

        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            while(true)
            {
                audioPlayer.Play(melodyGenerator.GetRandomNote(), (int)tempoInput.Value);
            }
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            
        }

        public void Stop()
        {
            Thread.Sleep(0);
        }
        
        
    }
}
