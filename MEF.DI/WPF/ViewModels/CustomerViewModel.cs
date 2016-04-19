using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Common;
using WPF.Models;
using WPF.Services;

namespace WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerViewModel : ViewModelBase
    {
        [ImportingConstructor]
        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            Customer = customerRepository.GetById(1);
        }

        private Customer _Customer;

        public Customer Customer
        {
            get { return _Customer; }
            set { Customer = value; }
        }

    }
}
