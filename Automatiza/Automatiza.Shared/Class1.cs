using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Windows.Media.Devices;

namespace Automatiza
{
    public class Person : InotifyPropertyChanged

    {
        private string name;

        private int idade;

        public string Name { get => name; set => name = value; }
        public int Idade { get => idade; set => idade = value; }
    
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
