using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Services;
using WPF.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using WPF.Common;

namespace WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerListViewModel : ViewModelBase
    {
        [ImportingConstructor]
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            Customers = customerRepository.GetAll();
        }


        public ObservableCollection<Customer> Customers { get; } = new ObservableCollection<Customer>();
    }
}
