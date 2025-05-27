using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.ViewModel.GroundViewModel;
using System.Windows.Input;
using LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Service;

namespace LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.ViewModel
{
    public class TaitrongViewModel : INotifyPropertyChanged //OnPropertyChanged(...): giúp View tự động cập nhật nếu giá trị thay đổi
    {
        private double _N;
        public double N
        {
            get => _N;
            set
            {
                _N = value;
                OnPropertyChanged(nameof(N));
            }
        }

        public ICommand LuuCommand { get; }

        public TaitrongViewModel()
        {
            LuuCommand = new RelayCommand(LuuDuLieu);
        }

        private void LuuDuLieu()
        {
            // Gán dữ liệu vào service dùng chung
            DataService.Instance.InputData.Taitrong.N = this.N;

            // Thông báo hoặc xử lý tiếp nếu cần
            // Ví dụ: mở cửa sổ mới hoặc hiện thông báo lưu thành công
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


        public class RelayCommand : ICommand
        {
            private readonly Action _execute;
            private readonly Func<bool> _canExecute;

            public RelayCommand(Action execute, Func<bool> canExecute = null)
            {
                _execute = execute;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter) => _canExecute == null || _canExecute();
            public void Execute(object parameter) => _execute();
            public event EventHandler CanExecuteChanged
            {
                add => CommandManager.RequerySuggested += value;
                remove => CommandManager.RequerySuggested -= value;
            }
        }


    }
}
