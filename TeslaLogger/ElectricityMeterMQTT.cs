using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

using Exceptionless;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;

namespace TeslaLogger
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Keine allgemeinen Ausnahmetypen abfangen", Justification = "<Pending>")]
    class ElectricityMeterMQTT : ElectricityMeterBase
    {
        private string host;
        private int port = 1883;
        private string paramater;

        MqttClient client;

        internal string mockup_status, mockup_shelly;

        Guid guid; // defaults to new Guid();
        
        public ElectricityMeterMQTT(string host, int port, string paramater)
        {
            this.host = host;
            this.port = port;
            this.paramater = paramater;

            if (client == null)
            {
                client = new MqttClient(host, port, false, null, null, MqttSslProtocols.None);
            }
        }

        string GetCurrentData()
        {
            return "";
        }


        public override double? GetUtilityMeterReading_kWh()
        {
            return null;
        }

        public override double? GetVehicleMeterReading_kWh()
        {
            
            return null;
        }

        public override bool? IsCharging()
        {
            
            return null;
        }

        public override string GetVersion()
        {
            return "";
        }
    }
}
