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

    public struct NoteCollection
    {
        public Note[] noteCollection { get; set; }
        
        public static Note[] GetAminorSeptatonicScale()
        {
            Note[] septatonicScale1 = new Note[];
            
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

        Tone[] scale = new Tone;
        Note note1 = new Note(scale, Duration.QUARTER);
        Note note2 = new Note(a_Aeolien.noteCollection[1], Duration.QUARTER);
        Note note3 = new Note(a_Aeolien.noteCollection[2], Duration.QUARTER);
        Note note4 = new Note(a_Aeolien.noteCollection[3], Duration.QUARTER);
        Note note5 = new Note(a_Aeolien.noteCollection[4], Duration.QUARTER);
        Note note6 = new Note(a_Aeolien.noteCollection[5], Duration.QUARTER);
        Note note7 = new Note(a_Aeolien.noteCollection[6], Duration.QUARTER);
        Note note8 = new Note(a_Aeolien.noteCollection[7], Duration.QUARTER);

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
