using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.ViewModel
{
    class GroundViewModel
    {
        private ObservableCollection<Ground> _GroundList;

        public ICommand SaveCommand { get; set; }  //lệnh lưu dữ liệu
        public GroundViewModel()
        {
            _GroundList = new ObservableCollection<Ground>
        {
            new Ground { Lopdat = 1, Phi = null, H = null, Gamma = null, C =null, Modun = null, Delta = null, E = null, GroundType = " ", Doset = null, Spt = null, Cpt = null },
            new Ground { Lopdat = 2, Phi = null, H = null, Gamma = null, C =null, Modun = null, Delta = null, E = null, GroundType = " ", Doset = null, Spt = null, Cpt = null },
            new Ground { Lopdat = 3, Phi = null, H = null, Gamma = null, C =null, Modun = null, Delta = null, E = null, GroundType = " ", Doset = null, Spt = null, Cpt = null },
            new Ground { Lopdat = 4, Phi = null, H = null, Gamma = null, C =null, Modun = null, Delta = null, E = null, GroundType = " ", Doset = null, Spt = null, Cpt = null },
            new Ground { Lopdat = 5, Phi = null, H = null, Gamma = null, C =null, Modun = null, Delta = null, E = null, GroundType = " ", Doset = null, Spt = null, Cpt = null },
            new Ground { Lopdat = 6, Phi = null, H = null, Gamma = null, C =null, Modun = null, Delta = null, E = null, GroundType = " ", Doset = null, Spt = null, Cpt = null },
            new Ground { Lopdat = 7, Phi = null, H = null, Gamma = null, C =null, Modun = null, Delta = null, E = null, GroundType = " ", Doset = null, Spt = null, Cpt = null }
        };
            SaveCommand = new RelayCommand(SaveGroundData);
        }

        public ObservableCollection<Ground> Ground
        {
            get { return _GroundList; }
            set { _GroundList = value; OnPropertyChanged(nameof(Ground)); } // Đảm bảo cập nhật UI khi thay đổi 
        }

        private void SaveGroundData()
        {
            // Duyệt qua danh sách lớp đất và lấy dữ liệu
            foreach (var ground in _GroundList)
            {
                System.Diagnostics.Debug.WriteLine($"Lớp: {ground.Lopdat}, Phi: {ground.Phi}, H: {ground.H}, Gamma: {ground.Gamma}");
            }

            // Thông báo khi lưu thành công 
            MessageBox.Show("Dữ liệu đã được lưu và sẵn sàng cho tính toán!", "Thông báo");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //update button
        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        #region Updater
        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                // Code implementation for execution
            }
        }
        #endregion

        #region RelayCommand
        public class RelayCommand : ICommand
        {
            private readonly Action _execute;
            private readonly Func<bool> _canExecute;

            public RelayCommand(Action execute, Func<bool> canExecute = null)
            {
                _execute = execute;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return _canExecute == null || _canExecute();
            }

            public void Execute(object parameter)
            {
                _execute();
            }

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }
        }
        #endregion
    }
}
