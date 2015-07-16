using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Assisticant;
using ResumeWpf.Services;
using ResumeWpf.ViewModels;

namespace ResumeWpf.Views
{
    /// <summary>
    /// Interaction logic for SkillsView.xaml
    /// </summary>
    public partial class SkillsView : UserControl
    {
        public SkillsView()
        {
            InitializeComponent();
            //SkillsService serv = new SkillsService();
            //this.DataContext = new SkillsPageViewModel(serv);
        }

        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                //this.DataContext = ForView.Unwrap<SkillsPageViewModel>(e.NewValue);
                int i = 0;
            }
            //this.DataContext = ForView.Unwrap<SkillsPageViewModel>(e.NewValue);

            //this.DataContext = ForView.Unwrap<SkillsPageViewModel>(e.NewValue, vm => vm.Load());
            //this.DataContext = new SkillsPageViewModel(serv);
            //this.DataContext = e.NewValue;
        }
    }
}
