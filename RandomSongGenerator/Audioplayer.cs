using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace RandomSongGenerator
{
    class Audioplayer
    {
        public const int MAX_TEMPO = 300;
        public const int MIN_TEMPO = 60;
        

        public void Play(Note[] tune, int tempo)
        {
            foreach (Note n in tune)
            {
                Play(n, tempo);

            }
        }

        public void Play(Note note, int tempo)
        {
            if (note.NoteTone == Tone.REST)
            {
                Thread.Sleep(ConvertDuration(note.NoteDuration, tempo));
            }
            else
            {
                Console.Beep((int)note.NoteTone, ConvertDuration(note.NoteDuration, tempo));
            }
        }

        public void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        

        private int ConvertDuration(Duration originalDuration, int userTempo)
        {
            // user putting in 120 bpm will give us 2.0 since it is twice as fast 
            float tempoRatio = userTempo / 60.0f;
            //default tempo is 60 bpm???
            //how can user see bpm??


            // reverse the number because twice as fast is half the duration (change 2.0 to 0.5) 
            float multiplier = 1 / tempoRatio;


            // our new duration in milliseconds 
            int milliseconds = (int)((int)originalDuration * multiplier);


            return milliseconds;
        }

    }
}
