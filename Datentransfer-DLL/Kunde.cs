using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatentransferDLL
{
    public class Kunde
    {
        private string kundenId;
        private string kundenName;
        private string ansprechpartner;
        private string strasse;
        private string ort;

        public string KundenId
        {
            get
            {
                return kundenId;
            }

            set
            {
                kundenId = value;
            }
        }

        public string KundenName
        {
            get
            {
                return kundenName;
            }

            set
            {
                kundenName = value;
            }
        }

        public string Ansprechpartner
        {
            get
            {
                return ansprechpartner;
            }

            set
            {
                ansprechpartner = value;
            }
        }

        public string Strasse
        {
            get
            {
                return strasse;
            }

            set
            {
                strasse = value;
            }
        }

        public string Ort
        {
            get
            {
                return ort;
            }

            set
            {
                ort = value;
            }
        }
    }
}
