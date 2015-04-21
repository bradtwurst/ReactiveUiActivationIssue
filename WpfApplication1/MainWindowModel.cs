using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;

namespace WpfApplication1
{
    public class MainWindowModel : ReactiveObject
    {
        public MainWindowModel()
        {
            DoItCmd = ReactiveCommand.CreateAsyncTask(o =>
            {
                Level1 = Level1 == null ? new Level1ViewModel() : null;
                return Task.FromResult(Unit.Default);
            });
        }

        public ReactiveCommand<Unit> DoItCmd { get; set; }

        private string _textValue;
        public string TextValue
        {
            get
            {
                return _textValue;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _textValue, value);
            }
        }


        private Level1ViewModel _level1;
        public Level1ViewModel Level1
        {
            get { return _level1; }
            set { this.RaiseAndSetIfChanged(ref _level1, value); }
        }

    }
}
