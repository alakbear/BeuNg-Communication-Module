using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeuNg_2015_Community.Classes
{
    public class Services
    {
        static string teamID;
        static string missionTime;
        static string packetCount;
        static string height;
        static string pressure;
        static string temperature;
        static string voltage;
        static string gpstime;
        static string longtitude;
        static string lengtitude;
        static string speed;
        static string gpsSatteliteCount;
        static string humidity;
        static string[] myData;

        //GET TEAM ID
        public static string getTeamId(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            teamID = myData[0].Substring(1).TrimEnd('>');
            return teamID;
        }

        //GET MISSION TIME
        public static string getMissionTime(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            missionTime = myData[1].Substring(1).TrimEnd('>');
            return missionTime;
        }

        //GET PACKET COUNT
        public static string getPacketCount(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            packetCount = myData[2].Substring(1).TrimEnd('>');
            return packetCount;
        }

        //GET HEIGHT
        public static float getHeight(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            height = myData[3].Substring(1).TrimEnd('>');
            float FLOAT_height;
            FLOAT_height = float.Parse(height);
            return FLOAT_height;
        }

        //GET PRESSURE
        public static float getPressure(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            pressure = myData[4].Substring(1).TrimEnd('>');
            float FLOAT_pressure;
            FLOAT_pressure = float.Parse(pressure);
            return FLOAT_pressure;
        }

        //GET TEMPERATURE
        public static float getTemperature(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            temperature = myData[5].Substring(1).TrimEnd('>');
            float FLOAT_tempreature;
            FLOAT_tempreature = float.Parse(temperature);
            return FLOAT_tempreature;
        }

        //GET VOLTAGE
        public static int getVoltage(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            voltage = myData[6].Substring(1).TrimEnd('>');
            int INT_voltage; ;
            INT_voltage = int.Parse(voltage);
            return INT_voltage;
        }

        //GET GPS TIME
        public static string getGpsTime(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            gpstime = myData[7].Substring(1).TrimEnd('>');
            return gpstime;
        }

        //GET LONGTITUDE
        public static string getLongtitude(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            longtitude = myData[8].Substring(1).TrimEnd('>');
            return longtitude;
        }

        //GET LENGTITUDE
        public static string getLengtitude(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            lengtitude = myData[9].Substring(1).TrimEnd('>');
            return lengtitude;
        }

        //GET SPEED
        public static float getSpeed(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            speed = myData[10].Substring(1).TrimEnd('>');
            float FLOAT_speed;
            FLOAT_speed = float.Parse(speed);
            return FLOAT_speed;
        }

        //GET GPS SATTELITE COUNT
        public static string getGpsSatteliteCount(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            gpsSatteliteCount = myData[11].Substring(1).TrimEnd('>');
            return gpsSatteliteCount;
        }

        //GET HUMIDITY
        public static int getHumidity(List<string> parsedDataFromMain)
        {
            myData = parsedDataFromMain.ToArray();
            humidity = myData[12].Substring(1, 1);/*.TrimEnd('>');*/
            int INT_humidity; ;
            INT_humidity = int.Parse(humidity);
            return INT_humidity;
        }
    }
}

