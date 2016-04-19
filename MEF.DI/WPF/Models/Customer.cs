﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Models
{
    public class Customer : BindableBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
    }
}
