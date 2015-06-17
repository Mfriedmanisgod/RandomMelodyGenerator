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
        Scale scale = new Scale();
        
        public Tone GetRandomTone(Scale s)
        {
            int randomNote = randomizer.Next(0, 7);
            Tone scaleTone = Scale.GetAminorSeptatonicScale().noteCollection[randomNote];
            int randomScenario = randomizer.Next(0, 1);

            switch(randomScenario)
            {

                case 0: scale = null; break;
                case 1:
                    {
                        s = Scale.GetAminorSeptatonicScale();
                    }
                    break;
            }

            return scaleTone;
            
        }

        public Duration GetRandomDuration()
        {
            int durRand = randomizer.Next(0, 11);
            Duration duration = Duration.WHOLE;
            switch (durRand)
            {
                case 0: duration = Duration.WHOLE; break;
                case 1: duration = Duration.HALF; break;
                case 2: duration = Duration.QUARTER; break;
                case 3: duration = Duration.EIGHTH; break; 
                case 4: duration = Duration.SIXTEENTH; break;
                /*
                case 5: duration = Duration.HALFTRIPLET; break;
                case 6: duration = Duration.QUARTERTRIPLET; break;
                case 7: duration = Duration.EIGHTHTRIPLET; break;
                case 8: duration = Duration.SIXTEENTHTRIPLET; break;
                case 9: duration = Duration.DOTTEDHALF; break;
                case 10: duration = Duration.DOTTEDQUARTER; break;
                case 11: duration = Duration.DOTTEDEIGHTH; break;
                 */ 
            }

            return duration;
        }

        public Note GetRandomNote() 
         {
              
             Tone tone = GetRandomTone(scale); 
             Duration duration = GetRandomDuration(); 
             Note note = new Note(tone, duration);
             
             return note; 
         } 

    }
}

