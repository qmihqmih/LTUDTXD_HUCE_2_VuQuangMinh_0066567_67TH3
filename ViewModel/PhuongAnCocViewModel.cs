using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Model;
using LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Service;
using LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.View;

namespace LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.ViewModel
{
    public class PhuongAnCocViewModel : INotifyPropertyChanged
    {
        private string _loaiCoc;
        private double _kichThuoc;
        private double _chieuDai;

        public string LoaiCoc
        {
            get => _loaiCoc;
            set { _loaiCoc = value; OnPropertyChanged(); }
        }

        public double KichThuoc
        {
            get => _kichThuoc;
            set { _kichThuoc = value; OnPropertyChanged(); }
        }

        public double ChieuDai
        {
            get => _chieuDai;
            set { _chieuDai = value; OnPropertyChanged(); }
        }

        public ObservableCollection<double> DanhSachKichThuoc { get; set; }
        public ObservableCollection<double> DanhSachChieuDai { get; set; }

        public ICommand LuuCommand { get; }

        public PhuongAnCocViewModel()
        {
            DanhSachKichThuoc = new ObservableCollection<double> { 0.2, 0.25, 0.3, 0.35 };
            DanhSachChieuDai = new ObservableCollection<double> { 5, 6, 7, 8, 9, 10, 11 };

            LuuCommand = new RelayCommand(LuuPhuongAn);
        }

        private void LuuPhuongAn()
        {
            DataService.Instance.InputData.PhuongAnCoc = new PhuongAnCoc
            {
                LoaiCoc = this.LoaiCoc,
                KichThuoc = this.KichThuoc,
                ChieuDai = this.ChieuDai
            };

            // Có thể đóng cửa sổ hoặc báo người dùng
            MessageBox.Show("Đã lưu phương án cọc.");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}