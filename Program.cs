using System.Media;
using System;

namespace silent_audio {
    class Program {
        static void Main(string[] args) {
            try {
                SoundPlayer simpleSound = new SoundPlayer("audio.wav");
                simpleSound.PlaySync();
            } catch (Exception e) {
                // Do nothing
            }
        }
    }
}
