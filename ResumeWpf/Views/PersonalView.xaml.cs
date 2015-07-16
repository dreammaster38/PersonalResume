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
using ResumeWpf.ViewModels;

namespace ResumeWpf.Views
{
    /// <summary>
    /// Interaction logic for PersonalView.xaml
    /// </summary>
    public partial class PersonalView : UserControl
    {
        public PersonalView()
        {
            InitializeComponent();
        }

        private void TextBlock_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ForView.Unwrap<PersonalPageViewModel>(e.NewValue, vm => vm.Load());
        }
    }
}
