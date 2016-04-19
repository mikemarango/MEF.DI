using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Services;
using WPF.Models;
using System.Collections.ObjectModel;

namespace WPF.ViewModels
{
    public class CustomerListViewModel : BindableBase
    {
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            Customers = customerRepository.GetAll();
        }


        public ObservableCollection<Customer> Customers { get; } = new ObservableCollection<Customer>();
    }
}
