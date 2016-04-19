using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Common;

namespace WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MainWindowViewModel : ViewModelBase, IPartImportsSatisfiedNotification
    {
        [ImportingConstructor]
        public MainWindowViewModel()
        {
            ToggleViewCommand = new ToggleViewCommand(this);
        }

        [Import]
        private CustomerListViewModel _CustomerListViewModel;
        [Import]
        private CustomerViewModel _CustomerViewModel;
        [Import]
        ViewModelBase _CurrentViewModel;


        public ICommand ToggleViewCommand { get; private set; }
        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { Set(ref _CurrentViewModel, value); }
        }

        public void OnToggleViewCommand()
        {
            if (_CurrentViewModel.Equals(_CustomerListViewModel))
                CurrentViewModel = _CustomerViewModel;
            else
                CurrentViewModel = _CustomerListViewModel;
        }
        public void OnImportsSatisfied()
        {
            CurrentViewModel = _CustomerListViewModel;
        }
    }
}
