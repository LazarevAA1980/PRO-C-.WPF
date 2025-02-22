﻿using MainWpfApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MainWpfApp.ViewModels
{
    public class LocationViewViewModel : INotifyPropertyChanged
    {

        public LocationViewViewModel()
        {
            
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
