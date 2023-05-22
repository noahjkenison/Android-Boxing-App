using System;
using System.Collections.Generic;
using System.Text;


    public interface IProximitySensorService
    {
        string AccessProximitySensor();

        void registerListener();

        void unregisterListener();

    }

