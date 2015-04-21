using ReactiveUI;
using Splat;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {

            Locator.CurrentMutable.Register(() => new Level1View(), typeof (IViewFor<Level1ViewModel>));
            var vm = new MainWindowModel {TextValue = "MAIN VM TEXT VALUE"};
            var view = new MainWindow { ViewModel = vm };

            view.ShowDialog();

        }
    }
}
