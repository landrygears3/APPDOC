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

        DateTime PropertyMinimumDate = DateTime.Now;
        DateTime ProertyMaxDate = new DateTime(2100, 12, 31);

        private List<string> horas;
        public List<string> Horas
        {
            get
            {

                System.Console.WriteLine("Selfech="+selfech);

                String da = Convert.ToDateTime(selfech, System.Threading.Thread.CurrentThread.CurrentCulture).ToString("yyyy/MM/dd");
                System.Console.WriteLine("da=" + da);
                System.Console.WriteLine("ADIOS  popo");
                string json = "\"{fecha:'" + da + "'}\"";
                kv.SetPost(json, "horas");
                String[] aux = kv.GetPost().Trim('"').Split(',');
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


        string selfech = DateTime.Now.ToString();
        public string HorChan
        {
            get
            {
                return selfech;
            }
            set
            {

                selfech = value;
                System.Console.WriteLine("1");
                OnPropertyChanged();
                System.Console.WriteLine("2");
                OnPropertyChanged("Horas");
                System.Console.WriteLine("3");

            }
        }

    }

}
