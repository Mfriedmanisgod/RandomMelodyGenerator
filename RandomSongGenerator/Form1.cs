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
        List<Scale> scaleChoicesList = new List<Scale>();
        List<string> stringList = new List<string>();
        Scale scale = new Scale();

        public Form1()
        {
            InitializeComponent();

            string a_Aeolien = RandomSongGenerator.Scale.GetAminorSeptatonicScale().ToString();
            string a_Dorian = RandomSongGenerator.Scale.GetA_DorianSeptatonicScale().ToString();
            string a_Ionian = RandomSongGenerator.Scale.GetAmajorSeptatonicScale().ToString();
            string a_MinorPentatonic = RandomSongGenerator.Scale.GetAminorPentatonicScale().ToString();
            string a_Chromatic = RandomSongGenerator.Scale.GetA_chromaticScale().ToString();

            a_Aeolien = "A Aeolien";
            a_Dorian = "A Dorian";
            a_Ionian = "A Ionian";
            a_MinorPentatonic = "A Minor Pentatonic";
            a_Chromatic = "A Chromatic";

            stringList.Add(a_Aeolien);
            stringList.Add(a_Dorian);
            stringList.Add(a_MinorPentatonic);
            stringList.Add(a_Ionian);
            stringList.Add(a_Chromatic);

            ScaleOptions.DataSource = stringList;
            ScaleOptions.Text = stringList.ToString();

            tempoInput.Maximum = Audioplayer.MAX_TEMPO;
            tempoInput.Minimum = Audioplayer.MIN_TEMPO;
        }
        int min, sec, ms = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayTimer(label2);
            ms++;

            if (ms == 10)
            {
                sec++;
                ms = 0;
            }
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayMaryButton(object sender, EventArgs e)
        {
            audioPlayer.Play(PreloadedMelody.Mary, (int)tempoInput.Value);
        }

        private void PlaySmokeButton_Click(object sender, EventArgs e)
        {
            audioPlayer.Play(PreloadedMelody.Smoke, (int)tempoInput.Value);
        }

        private void PlayScale_Click(object sender, EventArgs e)
        {
            timer1.Start();
            DisplayTimer(label2);
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {


            while (true)
            {
                timer1.Start();
                DisplayTimer(label2);
                int selectedIndex = ScaleOptions.SelectedIndex;
                label1.Text = stringList[selectedIndex].ToString();

                if (label1.Text == "A Aeolien")
                {
                    audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetAminorSeptatonicScale()), (int)tempoInput.Value);
                }
                if (label1.Text == "A Ionian")
                {
                    audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetAmajorSeptatonicScale()), (int)tempoInput.Value);
                }
                if (label1.Text == "A Dorian")
                {
                    audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetA_DorianSeptatonicScale()), (int)tempoInput.Value);
                }
                if (label1.Text == "A Minor Pentatonic")
                {
                    audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetAminorPentatonicScale()), (int)tempoInput.Value);
                }
                if (label1.Text == "A Chromatic")
                {
                    audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetA_chromaticScale()), (int)tempoInput.Value);
                }

            }

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ScaleOptions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = ScaleOptions.SelectedIndex;
                label1.Text = stringList[selectedIndex].ToString();
            }
            catch
            {
                //http://www.c-sharpcorner.com/UploadFile/mike4/DotNetPiano11122005012432AM/DotNetPiano.aspx
                //http://www.codeproject.com/Articles/6165/A-Piano-Key-Control-in-C
            }

        }

        private void DisplayTimer(Label timerDisplay)
        {
            timerDisplay.Text = min + ":" + sec + ":" + ms.ToString();
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Scale a_Aeolien = RandomSongGenerator.Scale.GetAminorSeptatonicScale();

            timer1.Start();
            DisplayTimer(label2);
            int selectedIndex = ScaleOptions.SelectedIndex;
            label1.Text = stringList[selectedIndex].ToString();

            Note note1 = new Note(a_Aeolien.toneCollection[0], Duration.QUARTER);
            Note note2 = new Note(a_Aeolien.toneCollection[1], Duration.QUARTER);
            Note note3 = new Note(a_Aeolien.toneCollection[2], Duration.QUARTER);
            Note note4 = new Note(a_Aeolien.toneCollection[3], Duration.QUARTER);
            Note note5 = new Note(a_Aeolien.toneCollection[4], Duration.QUARTER);
            Note note6 = new Note(a_Aeolien.toneCollection[5], Duration.QUARTER);
            Note note7 = new Note(a_Aeolien.toneCollection[6], Duration.QUARTER);
            Note note8 = new Note(a_Aeolien.toneCollection[7], Duration.QUARTER);

            

            if (label1.Text == "A Aeolien")
            {
                audioPlayer.Play();
            }
            /*
            if (label1.Text == "A Ionian")
            {
                audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetAmajorSeptatonicScale()), (int)tempoInput.Value);
            }
            if (label1.Text == "A Dorian")
            {
                audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetA_DorianSeptatonicScale()), (int)tempoInput.Value);
            }
            if (label1.Text == "A Minor Pentatonic")
            {
                audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetAminorPentatonicScale()), (int)tempoInput.Value);
            }
            if (label1.Text == "A Chromatic")
            {
                audioPlayer.Play(melodyGenerator.GetRandomNote(RandomSongGenerator.Scale.GetA_chromaticScale()), (int)tempoInput.Value);
            }
            /*

            /*
            try
            {
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
            catch(NullReferenceException)
            {
                
            }
             */ 

        }

         










    }
}
