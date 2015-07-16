using Assisticant.Fields;

namespace ResumeWpf.Model
{
    public class SkillModel
    {
        private Observable<string> _skillName = new Observable<string>();
        private Observable<int> _gaugeValueInPercent = new Observable<int>();

        public string SkillName
        {
            get { return _skillName; }
            set { _skillName.Value = value; }
        }

        public int GaugeValueInPercent
        {
            get { return _gaugeValueInPercent; }
            set { _gaugeValueInPercent.Value = value; }
        }
    }
}