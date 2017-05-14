﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace wsb_mobilka
{
    

    public class EmotionsData
    {
        

        public double Hapiness { get; set; }
        public double Sadness { get; set; }
        public double Suprise { get; set; }
        public double Neutral { get; set; }
        public double Anger { get; set; }
        public double Contempt { get; set; }
        public double Disgust { get; set; }
        public double Fear { get; set; }

        public double BestEmotionScore { get; set; }
        public string BestEmotionName { get; set; }

        public Geoposition position { get; set; }

        
    
    }
}
