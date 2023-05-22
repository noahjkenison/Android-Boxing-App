using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using BoxingProto.Droid;
using Java.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly: Xamarin.Forms.Dependency(typeof(ProximitySensorService))]


namespace BoxingProto.Droid
{


    public class ProximitySensorService : Java.Lang.Object, ISensorEventListener, IProximitySensorService
    { 

        SensorManager sensormanager = (SensorManager)Android.App.Application.Context.GetSystemService(Context.SensorService);
        Sensor proximitysensor;
        bool isProximitySensorAvailable;
        string sensorReadout;
        string returnsSensorReadout;


        public ProximitySensorService()
        {
            {
                

                if (sensormanager.GetDefaultSensor(SensorType.Proximity) != null) 
                {
                    proximitysensor = sensormanager.GetDefaultSensor(SensorType.Proximity);
                    isProximitySensorAvailable = true;
                }

                else
                {
                    isProximitySensorAvailable = false;
                }

            }


        }

        public string AccessProximitySensor()
        {

            return sensorReadout;
        }



        public void registerListener()
        {
            if (isProximitySensorAvailable == true)
            {
                sensormanager.RegisterListener(this, proximitysensor, SensorDelay.Normal); 
            }
        }

        public void unregisterListener()
        {
            if (isProximitySensorAvailable == true)
            {
                sensormanager.UnregisterListener(this);
            }
        }


        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
        }


        public void OnSensorChanged(SensorEvent e)
        {
            sensorReadout = e.Values[0].ToString();  
        }

        protected void OnResume()
        {
            //OnResume();

            //if (isProximitySensorAvailable == true)
            //{
            //    sensormanager.RegisterListener(this, proximitysensor, SensorDelay.Normal);
            //}


        }

        protected void OnPause()
        {
            //OnPause();

            //if (isProximitySensorAvailable == true)
            //{
            //    sensormanager.UnregisterListener(this);
            //}
        }

    }

}