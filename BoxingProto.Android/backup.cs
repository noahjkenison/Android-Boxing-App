using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxingProto.Droid
{
    internal class backup
    {




        public class ProximitySensorService : Java.Lang.Object, ISensorEventListener, IProximitySensorService
        { 

            private bool isProximitySensorAvailable;
            private Sensor proximitysensor;

            private string sensorReadout;

            public IntPtr Handle => throw new NotImplementedException();

            public int JniIdentityHashCode => throw new NotImplementedException();

            public JniObjectReference PeerReference => throw new NotImplementedException();

            public JniPeerMembers JniPeerMembers => throw new NotImplementedException();

            public JniManagedPeerStates JniManagedPeerState => throw new NotImplementedException();

            SensorManager sensormanager = (SensorManager)Android.App.Application.Context.GetSystemService(Context.SensorService);


            ProximitySensorService()
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




            public string AccessProximitySensor()
            {

                return sensorReadout;

            }





            public void registerListener()
            {

            }

            public void unregisterListener()
            {
            }







            public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
            {
                throw new NotImplementedException();
            }

            public void OnSensorChanged(SensorEvent e)
            {
                sensorReadout = e.Values[0].ToString(); 

            }


            [Android.Runtime.Register("onResume", "()V", "GetOnResumeHandler")]

            protected void OnResume()
            {
                OnResume();

                if (isProximitySensorAvailable == true)
                {
                    sensormanager.RegisterListener(this, proximitysensor, SensorDelay.Normal);
                }


            }

            protected void OnPause()
            {
                OnPause();

                if (isProximitySensorAvailable == true)
                {
                    sensormanager.UnregisterListener(this);
                }
            }


            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public void Disposed()
            {
                throw new NotImplementedException();
            }

            public void DisposeUnlessReferenced()
            {
                throw new NotImplementedException();
            }

            public void Finalized()
            {
                throw new NotImplementedException();
            }



            public void SetJniIdentityHashCode(int value)
            {
                throw new NotImplementedException();
            }

            public void SetJniManagedPeerState(JniManagedPeerStates value)
            {
                throw new NotImplementedException();
            }

            public void SetPeerReference(JniObjectReference reference)
            {
                throw new NotImplementedException();
            }

            public void UnregisterFromRuntime()
            {
                throw new NotImplementedException();
            }


        }































    }
}