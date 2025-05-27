using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Model
{
    public class Vatlieu2
    {
        public string loaithep;
        public string rs;
        public double rsw;
        public double rsc;
        public double eb;
        public string Loaithep
        {
            get
            {
                return loaithep;
            }
            set
            {
                loaithep = value;
                OnPropertyChanged("Loaithep");
            }
        }
        public string Rs
        {
            get
            {
                return rs;
            }
            set
            {
                rs = value;
                OnPropertyChanged("Rs");
            }
        }
        public double Rsw
        {
            get
            {
                return rsw;
            }
            set
            {
                rsw = value;
                OnPropertyChanged("Rsw");
            }
        }
        public double Rsc
        {
            get
            {
                return rsc;
            }
            set
            {
                rsc = value;
                OnPropertyChanged("Rsc");
            }
        }
        public double Eb
        {
            get
            {
                return eb;
            }
            set
            {
                eb = value;
                OnPropertyChanged("Eb");
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
