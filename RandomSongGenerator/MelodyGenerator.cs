using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace RandomSongGenerator
{
    class MelodyGenerator
    {
        Random randomizer = new Random();

        public Tone GetRandomTone()
        {
            int toneRand = randomizer.Next(0, 8);
            Tone tone = Tone.REST;
            switch (toneRand)
            {
                case 0: tone = Tone.REST; break;
                case 1: tone = Tone.A; break;
                case 2: tone = Tone.B; break;
                case 3: tone = Tone.C; break;
                case 4: tone = Tone.D; break;
                case 5: tone = Tone.E; break;
                case 6: tone = Tone.F; break;
                case 7: tone = Tone.G; break;
                case 8: tone = Tone.A2; break;
            }

            return tone;
        }

        public Duration GetRandomDuration()
        {
            // next step is to get the duration values to randomize too. 
            int durRand = randomizer.Next(0, 11);
            Duration duration = Duration.WHOLE;
            switch (durRand)
            {
                case 0: duration = Duration.WHOLE; break;
                case 1: duration = Duration.HALF; break;
                case 2: duration = Duration.QUARTER; break;
                case 3: duration = Duration.EIGHTH; break; 
                case 4: duration = Duration.SIXTEENTH; break;
                case 5: duration = Duration.HALFTRIPLET; break;
                case 6: duration = Duration.QUARTERTRIPLET; break;
                case 7: duration = Duration.EIGHTHTRIPLET; break;
                case 8: duration = Duration.SIXTEENTHTRIPLET; break;
                case 9: duration = Duration.DOTTEDHALF; break;
                case 10: duration = Duration.DOTTEDQUARTER; break;
                case 11: duration = Duration.DOTTEDEIGHTH; break;
            }

            return duration;
        }

        public Note GetRandomNote() 
         { 
             Tone tone = GetRandomTone(); 
             Duration duration = GetRandomDuration(); 
             Note note = new Note(tone, duration); 
             return note; 
         } 

    }
}

