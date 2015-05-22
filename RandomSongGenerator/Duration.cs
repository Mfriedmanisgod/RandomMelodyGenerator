using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    public enum Duration
    {
        //DIFFERENCE between enum and float and int???
        WHOLE = 1600,
        HALF = WHOLE / 2,
        QUARTER = HALF / 2,
        EIGHTH = QUARTER / 2,
        SIXTEENTH = EIGHTH / 2,
        HALFTRIPLET = WHOLE / 3,
        QUARTERTRIPLET = WHOLE / 6,
        EIGHTHTRIPLET = WHOLE / 12,
        SIXTEENTHTRIPLET = WHOLE / 24,
        DOTTEDHALF = (int)(HALF * 1.5),
        DOTTEDQUARTER = (int)(QUARTER * 1.5),
        DOTTEDEIGHTH = (int)(EIGHTH * 1.5),
    }
}
