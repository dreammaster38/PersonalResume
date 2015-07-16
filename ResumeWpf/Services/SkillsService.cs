using System.Collections.Generic;
using System.Linq;
using Assisticant.Collections;
using Assisticant.Fields;
using ResumeWpf.Model;

namespace ResumeWpf.Services
{
    /// <summary>
    /// Creates skills and searches for skills.
    /// </summary>
    public class SkillsService
    {
        // stores a collection of skills
        private readonly ObservableList<SkillModel> _skillModels = new ObservableList<SkillModel>();

        public SkillsService()
        {
            // initialize a collection of skills
            Initialize();
        }

        /// <summary>
        /// Create some skills and add them to an observable collection
        /// </summary>
        public void Initialize()
        {
            SkillModel skillModel = new SkillModel();
            skillModel.SkillName = "Skill_1";
            skillModel.GaugeValueInPercent = 60;
            _skillModels.Add(skillModel);

            skillModel = new SkillModel();
            skillModel.SkillName = "Skill_2";
            skillModel.GaugeValueInPercent = 80;
            _skillModels.Add(skillModel);

            skillModel = new SkillModel();
            skillModel.SkillName = "Skill_3";
            skillModel.GaugeValueInPercent = 40;
            _skillModels.Add(skillModel);
        }

        /// <summary>
        /// Try to get a special skill from the collection identified by skill name.
        /// </summary>
        /// <param name="skillName">The name of the skill we are searching for</param>
        /// <returns>The found skill model or null if not found.</returns>
        public SkillModel LoadSkill(string skillName)
        {
            // searching for the skill giving by name via LINQ
            return (from model in _skillModels
                where model.SkillName.Equals(skillName)
                select model).FirstOrDefault();
        }

        //public IEnumerable<SkillModel> GetAllSkillModels
        //{
        //    get
        //    {
        //        var models = from model in _skillModels select model;
        //        return models;
        //    }
        //}
        public ObservableList<SkillModel> GetAllSkillModels
        {
            get
            {
                return _skillModels;
            }
        }
    }
}