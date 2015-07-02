using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    class Scale
    {
        public Tone[] noteCollection { get; set; }

        public static Scale GetAminorSeptatonicScale()
        {
            Scale septatonicScale1 = new Scale();
            
            septatonicScale1.noteCollection = new Tone[8];
            septatonicScale1.noteCollection[0] = Tone.A;
            septatonicScale1.noteCollection[1] = Tone.B;
            septatonicScale1.noteCollection[2] = Tone.C;
            septatonicScale1.noteCollection[3] = Tone.D; 
            septatonicScale1.noteCollection[4] = Tone.E;
            septatonicScale1.noteCollection[5] = Tone.F;
            septatonicScale1.noteCollection[6] = Tone.G;
            septatonicScale1.noteCollection[7] = Tone.A2;
            
            return septatonicScale1;
        }

        public static Scale GetAmajorSeptatonicScale()
        {
            Scale septatonicScale2 = new Scale();

            septatonicScale2.noteCollection = new Tone[8];
            septatonicScale2.noteCollection[0] = Tone.A;
            septatonicScale2.noteCollection[1] = Tone.B;
            septatonicScale2.noteCollection[2] = Tone.Csharp;
            septatonicScale2.noteCollection[3] = Tone.D;
            septatonicScale2.noteCollection[4] = Tone.E;
            septatonicScale2.noteCollection[5] = Tone.Fsharp;
            septatonicScale2.noteCollection[6] = Tone.Gsharp;
            septatonicScale2.noteCollection[7] = Tone.A2;

            return septatonicScale2;
        }

        public static Scale GetA_DorianSeptatonicScale()
        {
            Scale septatonicScale3 = new Scale();

            septatonicScale3.noteCollection = new Tone[8];
            septatonicScale3.noteCollection[0] = Tone.A;
            septatonicScale3.noteCollection[1] = Tone.B;
            septatonicScale3.noteCollection[2] = Tone.Csharp;
            septatonicScale3.noteCollection[3] = Tone.D;
            septatonicScale3.noteCollection[4] = Tone.E;
            septatonicScale3.noteCollection[5] = Tone.Fsharp;
            septatonicScale3.noteCollection[6] = Tone.G;
            septatonicScale3.noteCollection[7] = Tone.A2;

            return septatonicScale3;
        }

        public static Scale GetAminorPentatonicScale()
        {
            Scale pentatonicScale = new Scale();

            pentatonicScale.noteCollection = new Tone[6];
            pentatonicScale.noteCollection[0] = Tone.A;
            pentatonicScale.noteCollection[1] = Tone.C;
            pentatonicScale.noteCollection[2] = Tone.D;
            pentatonicScale.noteCollection[3] = Tone.E;
            pentatonicScale.noteCollection[4] = Tone.G;
            pentatonicScale.noteCollection[5] = Tone.A2;

            return pentatonicScale;
        }

        public static Scale GetA_chromaticScale()
        {
            Scale chromaticScale = new Scale();

            chromaticScale.noteCollection = new Tone[8];
            chromaticScale.noteCollection[0] = Tone.A;
            chromaticScale.noteCollection[1] = Tone.Asharp;
            chromaticScale.noteCollection[2] = Tone.B;
            chromaticScale.noteCollection[3] = Tone.C;
            chromaticScale.noteCollection[4] = Tone.Csharp;
            chromaticScale.noteCollection[5] = Tone.D;
            chromaticScale.noteCollection[6] = Tone.Dsharp;
            chromaticScale.noteCollection[7] = Tone.E;
            chromaticScale.noteCollection[8] = Tone.F;
            chromaticScale.noteCollection[9] = Tone.Fsharp;
            chromaticScale.noteCollection[10] = Tone.G;
            chromaticScale.noteCollection[11] = Tone.Gsharp;
            chromaticScale.noteCollection[12] = Tone.A2;

            return chromaticScale;
        }

        
    }
}
