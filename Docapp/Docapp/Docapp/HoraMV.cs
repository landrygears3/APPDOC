using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Docapp
{
    public class HoraMV : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<string> horas = new List<string> { "Hora" };
        public List<string> Horas => horas;
    }

}
