using System.Windows;
using ReactiveUI;

namespace WpfApplication1
{
    public partial class Level1View : IViewFor<Level1ViewModel>
    {
        static Level1View()
        {
            ViewModelProperty = DependencyProperty.Register("ViewModel", typeof (Level1ViewModel), typeof (Level1View));
        }

        public Level1View()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                MessageBox.Show("Level1 Activated ");
            });
        }

        public static readonly DependencyProperty ViewModelProperty;

        public Level1ViewModel ViewModel
        {
            get { return (Level1ViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (Level1ViewModel)value; }
        }
    }
}