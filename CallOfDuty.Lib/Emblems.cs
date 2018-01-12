using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Lib
{
    public class Emblems
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("exceptionMessageList")]
        public List<object> ExceptionMessageList { get; set; }
        [JsonProperty("errors")]
        public Dictionary<string, string> Errors { get; set; }
        [JsonProperty("exceptionMessageCode")]
        public object ExceptionMessageCode { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        public class Datum
        {
            [JsonProperty("filename")]
            public string Filename { get; set; }
            [JsonProperty("layers")]
            public List<Layer> Layers { get; set; }
            [JsonProperty("layerCount")]
            public int LayerCount { get; set; }
            [JsonProperty("background")]
            public object Background { get; set; }
            [JsonProperty("type")]
            public object Type { get; set; }
            [JsonProperty("id")]
            public object Id { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }

            public class Layer
            {
                [JsonProperty("emblemLayerIndex")]
                public int EmblemLayerIndex { get; set; }
                [JsonProperty("icon")]
                public int Icon { get; set; }
                [JsonProperty("materialID")]
                public int MaterialID { get; set; }
                [JsonProperty("red")]
                public int Red { get; set; }
                [JsonProperty("green")]
                public int Green { get; set; }
                [JsonProperty("blue")]
                public int Blue { get; set; }
                [JsonProperty("alpha")]
                public int Alpha { get; set; }
                [JsonProperty("red1")]
                public int Red1 { get; set; }
                [JsonProperty("green1")]
                public int Green1 { get; set; }
                [JsonProperty("blue1")]
                public int Blue1 { get; set; }
                [JsonProperty("alpha1")]
                public int Alpha1 { get; set; }
                [JsonProperty("gradientAngle")]
                public int GradientAngle { get; set; }
                [JsonProperty("gradientFill")]
                public object GradientFill { get; set; }
                [JsonProperty("gradientType")]
                public bool GradientType { get; set; }
                [JsonProperty("posX")]
                public int PosX { get; set; }
                [JsonProperty("posY")]
                public int PosY { get; set; }
                [JsonProperty("scaleX")]
                public int ScaleX { get; set; }
                [JsonProperty("scaleY")]
                public int ScaleY { get; set; }
                [JsonProperty("angle")]
                public int Angle { get; set; }
                [JsonProperty("materialScaleX")]
                public int MaterialScaleX { get; set; }
                [JsonProperty("materialScaleY")]
                public int MaterialScaleY { get; set; }
                [JsonProperty("materialAngle")]
                public int MaterialAngle { get; set; }
                [JsonProperty("outline")]
                public bool Outline { get; set; }
                [JsonProperty("flip")]
                public bool Flip { get; set; }
                [JsonProperty("blend")]
                public bool Blend { get; set; }
                [JsonProperty("groupIndex")]
                public object GroupIndex { get; set; }
                [JsonProperty("materialPosX")]
                public int MaterialPosX { get; set; }
                [JsonProperty("materialPosY")]
                public int MaterialPosY { get; set; }
                [JsonProperty("gradientOffset")]
                public int GradientOffset { get; set; }
                [JsonProperty("gradientSpread")]
                public int GradientSpread { get; set; }
            }
        }
    }
}
