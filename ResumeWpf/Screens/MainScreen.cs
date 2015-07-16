using System.Windows;
using System.Windows.Input;
using Assisticant;
using ResumeWpf.Services;
using ResumeWpf.ViewModels;

namespace ResumeWpf.Screens
{
    public class MainScreen : ViewModelLocatorBase
    {
        private readonly SkillsService _skillsService;

        public MainScreen(SkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        public object PersonalContent
        {
            get
            {
                return ViewModel(() => new PersonalPageViewModel());
            }
        }

        public object SkillsContent
        {
            get
            {
                return ViewModel(() => new SkillsPageViewModel(_skillsService));
            }
        }

        public ICommand ChangeLanguageToGermanCommand
        {
            get
            {
                return MakeCommand.Do(() =>
                {
                    MessageBox.Show("Switched to German!");
                });
            }
        }

        public ICommand ChangeLanguageToEnglishCommand
        {
            get
            {
                return MakeCommand.Do(() =>
                {
                    MessageBox.Show("Switched to English!");
                });
            }
        }
    }
}