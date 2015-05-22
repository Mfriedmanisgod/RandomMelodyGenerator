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





namespace RandomSongGenerator
{
    public partial class Form1 : Form
    {
        MelodyGenerator melodyGenerator = new MelodyGenerator();
        Audioplayer audioPlayer = new Audioplayer();
        
        public Form1()
        {
            InitializeComponent();

            //why are these tempoinputs not registering??
            tempoInput.Maximum = Audioplayer.MAX_TEMPO; 
            tempoInput.Minimum = Audioplayer.MIN_TEMPO; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void PlayMaryButton(object sender, EventArgs e)
        {
            Scale septatonicScale1 = new Scale();
            septatonicScale1.noteCollection = new Tone[7];
            septatonicScale1.noteCollection[0] = Tone.A;
            septatonicScale1.noteCollection[1] = Tone.B;
            septatonicScale1.noteCollection[2] = Tone.C;
            septatonicScale1.noteCollection[3] = Tone.D; 
            septatonicScale1.noteCollection[4] = Tone.E;
            septatonicScale1.noteCollection[5] = Tone.F;
            septatonicScale1.noteCollection[6] = Tone.G;
            
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
            audioPlayer.Play(PreloadedMelody.Mary, (int)tempoInput.value);
        }

        
        
    }
}
