using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Models;

namespace WPF.Services
{
    public interface ICustomerRepository
    {
        Customer GetById(int id);
        ObservableCollection<Customer> GetAll();
        void Update(Customer customer);
    }
}
