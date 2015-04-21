using System.Windows;
using ReactiveUI;

namespace WpfApplication1
{
    public partial class MainWindow : IViewFor<MainWindowModel>
    {
        static MainWindow()
        {
            ViewModelProperty = DependencyProperty.Register("ViewModel", typeof (MainWindowModel), typeof (MainWindow));
        }

        public MainWindow()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                MessageBox.Show("Main Activated ");
                d(this.OneWayBind(ViewModel, vm => vm.Level1, v => v.Level1.ViewModel));
                d(this.OneWayBind(ViewModel, vm => vm.TextValue, v => v.MainText.Text));
                d(this.BindCommand(ViewModel, vm => vm.DoItCmd, v => v.DoIt));
            });
        }

        public static readonly DependencyProperty ViewModelProperty;

        public MainWindowModel ViewModel
        {
            get { return (MainWindowModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
    }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (MainWindowModel)value; }
}
    }
}