using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Model
{
    public class Ground : INotifyPropertyChanged
    {
        private int? lopdat;
        private int? phi;
        private int? h;
        private int? gamma;
        private int? c;
        private int? modun;
        private int? delta;
        private int? e;
        private string groundtype;
        private int? doset;
        private int? spt;
        private int? cpt;

        public int? Lopdat
        {
            get
            {
                return lopdat;
            }
            set
            {
                lopdat = value;
                OnPropertyChanged("Lopdat");
            }
        }

        public int? Phi
        {
            get
            {
                return phi;
            }
            set
            {
                phi = value;
                OnPropertyChanged("Phi");
            }
        }

        public int? H
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
                OnPropertyChanged("H");
            }
        }

        public int? Gamma
        {
            get
            {
                return gamma;
            }
            set
            {
                gamma = value;
                OnPropertyChanged("Gamma");
            }
        }

        public int? C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
                OnPropertyChanged("C");
            }
        }

        public int? Modun
        {
            get
            {
                return modun;
            }
            set
            {
                modun = value;
                OnPropertyChanged("Modun");
            }
        }

        public int? Delta
        {
            get
            {
                return delta;
            }
            set
            {
                delta = value;
                OnPropertyChanged("Delta");
            }
        }

        public int? E
        {
            get
            {
                return e;
            }
            set
            {
                e = value;
                OnPropertyChanged("E");
            }
        }

        public string GroundType
        {
            get
            {
                return groundtype;
            }
            set
            {
                groundtype = value;
                OnPropertyChanged("GroundType");
            }
        }

        public int? Doset
        {
            get
            {
                return doset;
            }
            set
            {
                doset = value;
                OnPropertyChanged("Doset");
            }
        }

        public int? Spt
        {
            get
            {
                return spt;
            }
            set
            {
                spt = value;
                OnPropertyChanged("Spt");
            }
        }

        public int? Cpt
        {
            get
            {
                return cpt;
            }
            set
            {
                cpt = value;
                OnPropertyChanged("Cpt");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
