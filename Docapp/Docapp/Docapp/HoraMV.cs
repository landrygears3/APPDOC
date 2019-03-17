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

        kevin kv = new kevin();
       

        private List<string> horas;
        public List<string> Horas
        {
            get
            {

                String dia = selfech.Day.ToString();
                String mes = selfech.Month.ToString();
                String año = selfech.Year.ToString();

                String da = año + "/" + mes + "/" + dia;

                string json = "\"{fecha:'" + da + "',token:'" + credenciales.Cred + "'}\"";
                kv.SetPost(json, "horas");
                String[] aux = kv.GetPost().Split(',');
                horas = new List<string>();
                this.horas.Clear();
                foreach (string var in aux)
                {
                    this.horas.Add(var);
                }
                this.horas.RemoveAt(this.horas.Count - 1);
                return horas;
            }
            set { return; }
        }


        DateTime selfech = DateTime.Now;
        public void HorChan(DateTime dat) {
            selfech = dat;
                    OnPropertyChanged();
                    OnPropertyChanged("Horas");

        }
        public String agendaA(String nombre, String telefono, String correo, int hora)
        {
            String dia = selfech.Day.ToString();
            String mes = selfech.Month.ToString();
            String año = selfech.Year.ToString();

            String da = año + "/" + mes + "/" + dia;

            string json = "\"{nom:'" + nombre + "',tel:'" + telefono + "',cor:'" + correo + "',fec:'" + da + "',hor:'" + this.horas[hora] + "'}\"";
            kv.SetPost(json, "Anonima");
            String aux = kv.GetPost();

            return aux;
        }

        
        public Boolean fechVal()
        {
            if (selfech > DateTime.Now)
            {
                return false;
            }
            else { return true; }
        }

    }

}
