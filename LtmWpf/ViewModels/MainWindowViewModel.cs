using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace LtmWpf.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }

        private DelegateCommand _btn1ClickCommand;
        public DelegateCommand Btn1ClickCommand =>
            _btn1ClickCommand ??= new DelegateCommand(() => {
                MessageBox.Show("Hello Prism");
            });









    }
}
