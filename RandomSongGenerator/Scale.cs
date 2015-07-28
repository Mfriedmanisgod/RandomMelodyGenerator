using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{
    class Scale
    {
        public Tone[] toneCollection { get; set; }

        public static Scale GetAminorSeptatonicScale()
        {
            Scale septatonicScale1 = new Scale();
            
            septatonicScale1.toneCollection = new Tone[8];
            septatonicScale1.toneCollection[0] = Tone.A;
            septatonicScale1.toneCollection[1] = Tone.B;
            septatonicScale1.toneCollection[2] = Tone.C;
            septatonicScale1.toneCollection[3] = Tone.D; 
            septatonicScale1.toneCollection[4] = Tone.E;
            septatonicScale1.toneCollection[5] = Tone.F;
            septatonicScale1.toneCollection[6] = Tone.G;
            septatonicScale1.toneCollection[7] = Tone.A2;
            
            return septatonicScale1;
        }

        public static Scale GetAmajorSeptatonicScale()
        {
            Scale septatonicScale2 = new Scale();

            septatonicScale2.toneCollection = new Tone[8];
            septatonicScale2.toneCollection[0] = Tone.A;
            septatonicScale2.toneCollection[1] = Tone.B;
            septatonicScale2.toneCollection[2] = Tone.Csharp;
            septatonicScale2.toneCollection[3] = Tone.D;
            septatonicScale2.toneCollection[4] = Tone.E;
            septatonicScale2.toneCollection[5] = Tone.Fsharp;
            septatonicScale2.toneCollection[6] = Tone.Gsharp;
            septatonicScale2.toneCollection[7] = Tone.A2;

            return septatonicScale2;
        }

        public static Scale GetA_DorianSeptatonicScale()
        {
            Scale septatonicScale3 = new Scale();

            septatonicScale3.toneCollection = new Tone[8];
            septatonicScale3.toneCollection[0] = Tone.A;
            septatonicScale3.toneCollection[1] = Tone.B;
            septatonicScale3.toneCollection[2] = Tone.Csharp;
            septatonicScale3.toneCollection[3] = Tone.D;
            septatonicScale3.toneCollection[4] = Tone.E;
            septatonicScale3.toneCollection[5] = Tone.Fsharp;
            septatonicScale3.toneCollection[6] = Tone.G;
            septatonicScale3.toneCollection[7] = Tone.A2;

            return septatonicScale3;
        }

        public static Scale GetAminorPentatonicScale()
        {
            Scale pentatonicScale = new Scale();

            pentatonicScale.toneCollection = new Tone[6];
            pentatonicScale.toneCollection[0] = Tone.A;
            pentatonicScale.toneCollection[1] = Tone.C;
            pentatonicScale.toneCollection[2] = Tone.D;
            pentatonicScale.toneCollection[3] = Tone.E;
            pentatonicScale.toneCollection[4] = Tone.G;
            pentatonicScale.toneCollection[5] = Tone.A2;

            return pentatonicScale;
        }

        public static Scale GetA_chromaticScale()
        {
            Scale chromaticScale = new Scale();

            chromaticScale.toneCollection = new Tone[13];
            chromaticScale.toneCollection[0] = Tone.A;
            chromaticScale.toneCollection[1] = Tone.Asharp;
            chromaticScale.toneCollection[2] = Tone.B;
            chromaticScale.toneCollection[3] = Tone.C;
            chromaticScale.toneCollection[4] = Tone.Csharp;
            chromaticScale.toneCollection[5] = Tone.D;
            chromaticScale.toneCollection[6] = Tone.Dsharp;
            chromaticScale.toneCollection[7] = Tone.E;
            chromaticScale.toneCollection[8] = Tone.F;
            chromaticScale.toneCollection[9] = Tone.Fsharp;
            chromaticScale.toneCollection[10] = Tone.G;
            chromaticScale.toneCollection[11] = Tone.Gsharp;
            chromaticScale.toneCollection[12] = Tone.A2;

            return chromaticScale;
        }

        public Note[](Tone[], temp

        
    }
}
