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
        public Scale[] scaleCollection { get; set; }
        
        public Note[] GetAminorArray()
        {
            
            Note[] noteArray = new Note[5];  
            
            
         

            
            
            
            return noteArray;
        }

        

        /*        
        audioPlayer.Play(note1, (int)tempoInput.Value);
        audioPlayer.Play(note2, (int)tempoInput.Value);
                audioPlayer.Play(note3, (int)tempoInput.Value);
                audioPlayer.Play(note4, (int)tempoInput.Value);
                audioPlayer.Play(note5, (int)tempoInput.Value);
                audioPlayer.Play(note6, (int)tempoInput.Value);
                audioPlayer.Play(note7, (int)tempoInput.Value);
                audioPlayer.Play(note8, (int)tempoInput.Value);
          /*      
    }
        
            
        


}
