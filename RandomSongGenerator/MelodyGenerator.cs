﻿using System;
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
        
        /// <summary>
        /// getrandomtone will accept whatever scale is in parenthesis as the parameter and get a random tone at 90%. will also rest at 10%
        /// </summary>
        /// <param name="s">s = scale i set as parameter</param> 
        /// <returns> returns one random scale tone from within the scale</returns>
        public Tone GetRandomTone(Scale s)
        {
            int c = s.toneCollection.Length;
            int randomNote = randomizer.Next(c);
            Tone scaleTone = s.toneCollection[randomNote];
            int randomScenario = randomizer.Next(0, 10);

            if (randomScenario == 0)
            {
                scaleTone = Tone.REST; 
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

        public Note GetRandomNote(Scale scaleChoice) 
         {
              
             Tone tone = GetRandomTone(scaleChoice); 
             Duration duration = GetRandomDuration(); 
             Note note = new Note(tone, duration);
             
             return note; 
         } 

    }
}

