using LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;


namespace LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.ViewModel
{
    public class Vatlieu2ViewModel
    {
        private ObservableCollection<Vatlieu2> _Vatlieu2List;

        public Vatlieu2ViewModel()
        {
            _Vatlieu2List = new ObservableCollection<Vatlieu2>
        {
            new Vatlieu2 { },
            
        };
        }
        public ObservableCollection<Vatlieu2> Vatlieu2
        {
            get { return _Vatlieu2List; }
            set { _Vatlieu2List = value; OnPropertyChanged(nameof(Vatlieu2)); } // Đảm bảo cập nhật UI khi thay đổi 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
