using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RandomSongGenerator
{
    static class PreloadedMelody //why was this static??? and not just 'class preloaded..'???
    {

        public static Note[] Mary = 
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

        public static Note[] Smoke = 
            {
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.DOTTEDQUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.Dsharp, Duration.EIGHTH),
                new Note(Tone.D, Duration.HALF),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.DOTTEDQUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.A, Duration.DOTTEDHALF),
            };

        public static Note[] Metronome = 
            {
                new Note(Tone.MetronomeClick, Duration.WHOLE),
                /*
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                new Note(Tone.MetronomeClick, Duration.QUARTER),
                 */ 
            };
    }
}

