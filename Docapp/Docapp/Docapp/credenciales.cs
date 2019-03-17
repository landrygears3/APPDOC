using System;
using System.Collections.Generic;
using System.Text;

namespace Docapp
{
    static class credenciales
    {
        private static String cred=String.Empty;
        public static String Cred
        {
            get
            {
                return cred;
            }
            set
            {
                cred = value;
            }
        }

       

    }
}
