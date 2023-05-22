using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading;
using Xamarin.Essentials;

namespace BoxingProto.Classes
{



    public class AudioGenerator
    {
        public ISimpleAudioPlayer startRoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        public ISimpleAudioPlayer endRoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        public ISimpleAudioPlayer clapPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        public ISimpleAudioPlayer clapPlayer2 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        public ISimpleAudioPlayer clapPlayer3 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        public ISimpleAudioPlayer clapPlayer4= Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        public ISimpleAudioPlayer tenSecondPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();



        public AudioGenerator()
        {
            startRoundPlayer.Load(GetStreamFromFile("StartBell.wav"));
            startRoundPlayer.Volume = 0.2;
            endRoundPlayer.Load(GetStreamFromFile("EndBell.mp3"));
            endRoundPlayer.Volume = 0.2;

            clapPlayer.Load(GetStreamFromFile("Clap1.wav"));
            clapPlayer2.Load(GetStreamFromFile("Clap2.wav"));
            clapPlayer3.Load(GetStreamFromFile("Clap3.wav"));
            clapPlayer4.Load(GetStreamFromFile("Clap4.wav"));
            tenSecondPlayer.Load(GetStreamFromFile("tenSecondWarning.mp3"));
        }

        SpeechOptions settings = new SpeechOptions()
        {
            Volume = .75f,
            Pitch = .78f,
            //set locale here as well?
        };

        public void PlayRoundEndBell()
        {
            endRoundPlayer.Play();
            
        }

        public void PlayRoundStartBell()
        {
            startRoundPlayer.Play();
        }

        public void PlayTenSecondNotice()
        {
            clapPlayer.Play();
        }

        public void PlayTenSecondNotice2()
        {
            clapPlayer2.Play();
        }

        public void PlayTenSecondNotice3()
        {
            clapPlayer3.Play();
        }

        public void PlayTenSecondNotice4()
        {
            clapPlayer4.Play();
        }

        public void PlayTenSecondNoticeReal()
        {
            tenSecondPlayer.Play();
        }

        public void PlayAudioTTS(string combo)
        {

            TextToSpeech.SpeakAsync(combo, settings);


        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("BoxingProto.Resources." + filename);
            return stream;
        }

    }
}