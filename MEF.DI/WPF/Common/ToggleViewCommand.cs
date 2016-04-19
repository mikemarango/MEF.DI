using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Common
{
    public class ToggleViewCommand : ICommand
    {
        MainWindowViewModel _ViewModel;
        public ToggleViewCommand(MainWindowViewModel viewModel)
        {
            _ViewModel = viewModel;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _ViewModel.OnToggleViewCommand();
        }
    }
}
