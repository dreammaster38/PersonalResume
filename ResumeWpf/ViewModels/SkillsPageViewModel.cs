using System.Collections.Generic;
using System.Linq;
using Assisticant;
using Assisticant.Collections;
using Assisticant.Fields;
using ResumeWpf.Model;
using ResumeWpf.Services;

namespace ResumeWpf.ViewModels
{
    public class SkillsPageViewModel
    {
        private readonly SkillsService _skillService;

        public SkillsPageViewModel(SkillsService skillService)
        {
            _skillService = skillService;
        }

        public void Load()
        {
        }

        public string SkillsPageDescription
        {
            get { return "Here will come a meaningful description of the skill'S page."; }
        }

        //public IEnumerable<SkillModel> AllSkillModels
        //{
        //    get
        //    {
        //        return from models in _skillService.GetAllSkillModels select models;
        //    }
        //}

        //public ObservableList<SkillModel> AllSkillModels
        //{
        //    get { return _skillService.GetAllSkillModels; }
        //}

        public object AllSkillModels
        {
            get
            {
                //return ForView.Unwrap<IEnumerable<SkillModel>>(_skillService.GetAllSkillModels);
                return _skillService.GetAllSkillModels;
            }
        }
    }
}