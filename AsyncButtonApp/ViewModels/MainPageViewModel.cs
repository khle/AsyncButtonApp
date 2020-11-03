using Xamarin.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
namespace AsyncButtonApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command FetchCommand { get; }
        public MainPageViewModel()
        {
            FetchCommand = new Command(async (obj) => await OnFetchClicked(obj));
        }
        private async Task OnFetchClicked(object obj)
        {
            IsFetching = true;
            await Task.Delay(1500); //simulates some async work
            IsFetching = false;
        }
        private bool _isFetching;
        public bool IsFetching
        {
            get { return _isFetching; }
            set
            {
                _isFetching = value;
                OnPropertyChanged(nameof(IsFetching));
            }
        }
    }
}