using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using pr0p0llDiagrams.Entities;
using pr0p0llDiagrams.Logic;
using pr0p0llDiagrams.Properties;


namespace pr0p0llDiagrams.Views
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Poll _poll;
        private Question _selectedQuestion;


        public void Initialize()
        {
            var jsonString = File.ReadAllText("TODO");
            var poll = JsonDeserializer.DeserializePoll(jsonString);
            Poll = poll;
        }


        #region Properties

        public Question SelectedQuestion
        {
            get => _selectedQuestion;
            set
            {
                _selectedQuestion = value;
                OnPropertyChanged();
            }
        }


        public Poll Poll
        {
            get => _poll;
            set
            {
                _poll = value;
                OnPropertyChanged();
            }
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion PropertyChanged

        #endregion Properties
    }
}
