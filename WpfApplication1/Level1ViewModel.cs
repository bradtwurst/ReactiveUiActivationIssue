using ReactiveUI;

namespace WpfApplication1
{
    public class Level1ViewModel : ReactiveObject
    {
        public Level1ViewModel()
        {
            TextValue = "LEVEL 1 TEXT VALUE";
        }

        public string TextValue
        {
            get { return _textValue; }
            set { this.RaiseAndSetIfChanged(ref _textValue, value); }
        }

        private string _textValue;
    }
}