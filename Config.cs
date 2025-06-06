using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CuffConversion
{
    public class Config : IConfig
    {
        [Description("تفعيل أو تعطيل البلجن")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("تفعيل أو تعطيل البلجن")]
        public bool Debug { get; set; }

        [Description("تفعيل التحويل عندما يهرب لاعب Chaos بعد أن يُقيد من طرف MTF")]
        public bool ConvertChaosToMTF { get; set; } = true;

        [Description("تفعيل التحويل عندما يهرب لاعب MTF بعد أن يُقيد من طرف Chaos")]
        public bool ConvertMTFToChaos { get; set; } = true;

        [Description("مدة ظهور الرسالة عند التحويل (بالثواني)")]
        public ushort BroadcastDuration { get; set; } = 5;

        [Description("الرسالة التي تظهر عند التحويل إلى MTF")]
        public string ChaosToMTFMessage { get; set; } = "<color=green>لقد تم تحويلك إلى MTF بعد هروبك!</color>";

        [Description("الرسالة التي تظهر عند التحويل إلى Chaos")]
        public string MTFToChaosMessage { get; set; } = "<color=red>لقد تم تحويلك إلى Chaos بعد هروبك!</color>";
    }
}