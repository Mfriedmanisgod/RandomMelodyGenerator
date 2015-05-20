using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RandomSongGenerator
{
    class PreloadedMelody
    {
        public void PreloadedMelody()
        {
            // Declare the first few notes of the song, "Mary Had A Little Lamb".
            Note[] Mary = 
            {
                new Note(Tone.B, Duration.DOTTEDHALF),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.GbelowC, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.B, Duration.HALF),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.A, Duration.HALF),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.D, Duration.HALF),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.GbelowC, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.B, Duration.HALF),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.GbelowC, Duration.WHOLE),
            };
            
            Play(Mary);
        }

        // Play the notes in a song. 
        public static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }
    }
}
