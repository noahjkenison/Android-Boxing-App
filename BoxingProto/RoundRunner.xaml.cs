using BoxingProto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoxingProto

    
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoundRunner : ContentPage
    {

        public TimeSpan timeremaining { get; private set; } = new TimeSpan(1,1,1);
        TimeSpan oneSecond = new TimeSpan(0, 0, 1);
        TimeSpan zeroSeconds = new TimeSpan(0, 0, 0);
        bool roundPaused = true;
        Round _round { get; set; }
        public string timeremainingstring { get; private set; }
        new ComboGenerator combogenerator;
        string combotext;
        FullListGenerator fulllistgenerator = new FullListGenerator();
        List<int> fullstrikelist = new List<int>(); 
        List<int> fullcombolengthlist = new List<int>();
        AudioGenerator audiogenerator = new AudioGenerator();
        bool voiceEnabled = false;
        public IProximitySensorService proximityInfoService = DependencyService.Get<IProximitySensorService>();
        string newProximity;
        private int roundcount;
        string timerformat = @"mm\:ss";
        Timer pausechecktimer = new Timer(100);
        float x = 0;
        float y = 0;
        bool PauseByProximity = false;
        bool UnpauseByProximity = false;

        private float pageopacity = 1f;

        public float PageOpacity
        {
            get
            {
                return pageopacity;
            }

            set
            {
                pageopacity = value;
                OnPropertyChanged();
            }
        }

        public int RoundCount
        {
            get
            {
                return roundcount;
            }

            set
            {
                if (value == roundcount)
                    return;

                roundcount = value;
                OnPropertyChanged();
            }
        }


        private float pauseTimerFloat = 0;
        public float PauseTimerFloat
        {
            get
            {
                return pauseTimerFloat;
            }

            set
            {
                if (value == pauseTimerFloat)
                    return;

                pauseTimerFloat = value;
                OnPropertyChanged();
            }
        }


        private int currentroundnumber;
        public int CurrentroundNumber
        {
            get
            {
                return currentroundnumber;
            }

            set
            {
                if (value == currentroundnumber)
                    return;

                currentroundnumber = value;
                OnPropertyChanged();
            }
        }

        private bool tenSecondNoticePlayed = false;


        public RoundRunner(Round round) 
        {
            InitializeComponent();

            playroundButton.Source = ImageSource.FromResource("BoxingProto.Images.play.png");
            voiceImage.Source = ImageSource.FromResource("BoxingProto.Images.voice.png");
            pauseroundButton.Source = ImageSource.FromResource("BoxingProto.Images.pause.png");
            voiceImageCanceled.Source = ImageSource.FromResource("BoxingProto.Images.voiceCanceled.png");

            proximityInfoService.registerListener();
            Disappearing += RoundRunner_Disappearing;


            if (Application.Current.Properties.ContainsKey("roundcount") == true)
                RoundCount = (int) Application.Current.Properties["roundcount"];

            if (Application.Current.Properties.ContainsKey("currentroundnumber") == true)
                CurrentroundNumber = (int)Application.Current.Properties["currentroundnumber"];


            _round = round;

            if (_round.strikesEnabled == false)
            {
                voiceImageCanceled.IsVisible = false;
                voiceImage.IsVisible = false;
                combotextlabel.IsVisible = false;
            }

            BeginRound();
            Task.Delay(5000);
            Run();
        }






        private void RoundRunner_Disappearing(object sender, EventArgs e)
        {
            roundPaused = true;

            MessagingCenter.Send(this, "currentround", _round);

            if (Application.Current.Properties.ContainsKey("voiceEnabled"))
                Application.Current.Properties["voiceEnabled"] = voiceEnabled;


            proximityInfoService.unregisterListener();


        }

        public void Run()
        {
            if (timeremaining == _round._roundLength)
            {
                audiogenerator.startRoundPlayer.Play();
            }

            Device.StartTimer(new TimeSpan(0, 0, 0, 0, 100), () =>
            { 


                if (roundPaused == true)
                {
                    return false;
                }


                if (timeremaining == zeroSeconds)
                {
                    roundEnd();
                    return false;
                    
                }

                if (timeremaining == new TimeSpan (0,0, 10) && tenSecondNoticePlayed == false)
                {
                    audiogenerator.tenSecondPlayer.Play();
                    tenSecondNoticePlayed = true;
                }

                Device.BeginInvokeOnMainThread(() => 
                {

                    x += .1f;
                    y += .1f;

                    if (y >= 1)
                        y = 0;

                    if (x >= 1.00)
                    {
                        x = 0;
                        timeremaining = timeremaining - oneSecond;
                        _round._RemainingRoundTime = timeremaining;

                        timeremaininglabel.Text = timeremaining.ToString(timerformat);  

                        if (timeremaining <= new TimeSpan(0, 0, 3) && timeremaining >= oneSecond)
                        {
                            audiogenerator.clapPlayer4.Play();
                        }
                    }
                        
               
                    PauseCheck();

                    if (_round.strikesEnabled == true)
                    {
                        if (y == .1f)
                        {
                            if (timeremaining.TotalSeconds % _round._comboInterval == 0) 
                            {

                                combotext = combogenerator.Run();
                                combotextlabel.Text = combotext;

                                if (voiceEnabled == true)
                                    audiogenerator.PlayAudioTTS(combotext);


                            }
                        }
                    }

                   
  

                });



                if (roundPaused == false)
                    return true;


                return true;


            });





        }


        public void PauseCheck()
        {


            newProximity = proximityInfoService.AccessProximitySensor();

            if (roundPaused == false) 
            {
                if (newProximity == "5")
                {
                    PauseTimerFloat = 0;
                    progressbar.AbortAnimation("Progress");
                    progressbar.Progress = 0; 
                }

                if (newProximity == "0") 
                {
                    if (PauseTimerFloat <2)
                        PauseTimerFloat += .1f;
                    if (progressbar.AnimationIsRunning("Progress") != true)
                        progressbar.ProgressTo(1.00, 2000, Easing.Linear);


                    if (PauseTimerFloat >= 2)
                    {
                        
                        PauseByProximity = true;
                        PauseRoundAsync();

                    }
                }
            }

            if (roundPaused == true) 
            {
                if (newProximity == "5")
                {
                   
                    PauseTimerFloat = 0;
                    progressbar.AbortAnimation("Progress");
                    progressbar.Progress = 1;

                }

                if (newProximity == "0")
                {
            

                    if(PauseTimerFloat < 2)
                        PauseTimerFloat += .1f;

                    if (progressbar.AnimationIsRunning("Progress") != true)
                        progressbar.ProgressTo(0, 2000, Easing.Linear);



                    if (PauseTimerFloat >= 2)
                    {
                        UnpauseByProximity = true;
                        UnpauseRoundAsync();
                    }
                }
            }
           
            
        }

        private void BeginRound()
        {

            timeremaining = _round._RemainingRoundTime;

            if (Application.Current.Properties.ContainsKey("voiceEnabled"))
                voiceEnabled = (bool)Application.Current.Properties["voiceEnabled"];


            else
            {
                Application.Current.Properties["voiceEnabled"] = voiceEnabled;
            }


            timeremainingstring = timeremaining.ToString();

            fullstrikelist = fulllistgenerator.GenerateFullStrikeList(_round._strikesList);
            fullcombolengthlist = fulllistgenerator.GenerateFullComboLengthList(_round.combolengthlist);

            combogenerator = new ComboGenerator(_round, fullstrikelist, fullcombolengthlist);
            _round.roundstatus = RoundStatus.Inprogress;
            _round.CellColor = Color.LightYellow;

            roundPaused = false;
            playroundButton.IsVisible = false;



        }

        private void roundEnd()
        {
            _round.CellColor = Color.LightGreen;
            _round.roundstatus = RoundStatus.Complete;

            audiogenerator.PlayRoundEndBell();
            Task.Delay(1000);

            Navigation.PopAsync();
        }


        private void UnpauseRoundButton(object sender, EventArgs e)
        {
            UnpauseRoundAsync();
        }

        private void PauseRoundButton(object sender, EventArgs e)
        {
            PauseRoundAsync();
        }

        private async Task UnpauseRoundAsync()
        {
            PageOpacity = 1;
            roundPaused = false;
            playroundButton.IsVisible = false;
            pauseroundButton.IsVisible = true;
            pauseTimerFloat = 0;
            if (UnpauseByProximity == true)
            {
                UnpauseByProximity = false;

                await Task.Delay(1500);
                progressbar.AbortAnimation("Progress");
                progressbar.Progress = 0;
            }

            Run();

        }
        private async Task PauseRoundAsync()
        {
            PageOpacity = .15f;


            progressbar.Progress = 1;
            roundPaused = true;
            pauseroundButton.IsVisible = false;
            playroundButton.IsVisible = true;
            pauseTimerFloat = 0;

            if (PauseByProximity == true)
            {
                PauseByProximity = false;

                await Task.Delay(1500);
                progressbar.AbortAnimation("Progress");

            }
                
                


            Device.StartTimer(new TimeSpan(0,0,0,0, 100), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    PauseCheck(); 


                });


                if (roundPaused == true)
                    return true;

                if (roundPaused == false)
                    return false;

                return true;
            });
        }

        private void toggleVoice(object sender, EventArgs e)
        {
            
            switch (voiceEnabled)
            {
                case false:
                    voiceEnabled = true;
                    voiceImage.IsVisible = true;
                    voiceImageCanceled.IsVisible = false;
                    break;

                case true:
                    voiceEnabled = false;
                    voiceImage.IsVisible = false;
                    voiceImageCanceled.IsVisible = true;

                    break;
            }

        }

    }
}