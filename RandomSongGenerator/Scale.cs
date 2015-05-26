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

        //why does this scale not function in its own class??
        
        
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
        
    }
}
