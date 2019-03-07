using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Docapp
{
    public class HoraMV : ViewModelBase
    {

        //  List<string> horas = new List<string> { "Hora" };
        //public List<string> Horas => horas;

        private List<string> horas = new List<string> { "Hora" };


        kevin kv = new kevin();
        String dats = "";
        public String[] div(String fec)
        {
            String da = Convert.ToDateTime(selfech).ToString("yyyy/MM/dd");
            string json = "\"{fecha:'" + da + "'}\"";
            kv.SetPost(json, "horas");
            dats = kv.GetPost();
            String[] aux = dats.Split(',');
            this.horas.Clear();
            foreach (string var in aux)
            {
                this.horas.Add(var);
            }


            return aux;
        }

        public List<string> Horas
        {
            get
            {
                
                String da = Convert.ToDateTime(selfech).Date.ToString("yyyy/MM/dd");
                string json = "\"{fecha:'" + da + "'}\"";
                kv.SetPost(json, "horas");
                dats = kv.GetPost();
                String[] aux = dats.Split(',');
                this.horas.Clear(); 
                foreach (string var in aux)
                {
                    this.horas.Add(var);
                }
                return horas;
            }
        }


        string selfech;
        public string HorChan
        {
            get { return selfech; }
            set
            {
                if (selfech != value)
                {
                    selfech = value;
                    
                    OnPropertyChanged();
                    OnPropertyChanged("Horas");
                }
            }
        }

    }

}
