using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{

    
    public struct Note
    {
        Tone toneVal;
        Duration durVal;

        // Define a constructor to create a specific note. 
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }

        

        // Define properties to return the note's tone and duration. 
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
    }

    public struct NoteArray
    {
        public Note[] noteCollection { get; set; }
        
        public Note[] GetNoteArray(Scale scale)
        {
            int count = scale.toneCollection.Length;
            Note[] noteArray = new Note[count];

            for (int i = 0; i < count; i++)
            {
                Note note = new Note(scale.toneCollection[i], Duration.QUARTER);
                noteArray[i] = note;
            }

            return noteArray;
        }

        
    
        

        
    }
        
            
        


}
