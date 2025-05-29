using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class SucChiuTaiCocViewModel : INotifyPropertyChanged
{
    private double? _cpt, _spt, _thongke, _vatlieu, _min;

    public double? CPT
    {
        get => _cpt;
        set { _cpt = value; OnPropertyChanged(); UpdateMin(); }
    }

    public double? SPT
    {
        get => _spt;
        set { _spt = value; OnPropertyChanged(); UpdateMin(); }
    }

    public double? ThongKe
    {
        get => _thongke;
        set { _thongke = value; OnPropertyChanged(); UpdateMin(); }
    }

    public double? VatLieu
    {
        get => _vatlieu;
        set { _vatlieu = value; OnPropertyChanged(); UpdateMin(); }
    }

    public double? Min
    {
        get => _min;
        set { _min = value; OnPropertyChanged(); }
    }

    public ICommand TinhToanCPTCommand { get; }
    public ICommand TinhToanSPTCommand { get; }
    public ICommand TinhToanThongKeCommand { get; }
    public ICommand TinhToanVatLieuCommand { get; }

    public SucChiuTaiCocViewModel()
    {
        TinhToanCPTCommand = new RelayCommand(_ => CPT = TinhCPT());
        TinhToanSPTCommand = new RelayCommand(_ => SPT = TinhSPT());
        TinhToanThongKeCommand = new RelayCommand(_ => ThongKe = TinhThongKe());
        TinhToanVatLieuCommand = new RelayCommand(_ => VatLieu = TinhVatLieu());
    }

    private void UpdateMin()
    {
        var values = new[] { CPT, SPT, ThongKe, VatLieu };
        Min = values.Where(v => v.HasValue).Min();
    }

    private double TinhCPT() => 1200;       // giả sử
    private double TinhSPT() => 1000;       // giả sử
    private double TinhThongKe() => 1100;   // giả sử
    private double TinhVatLieu() => 900;    // giả sử

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Predicate<object> _canExecute;

    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);
    public void Execute(object parameter) => _execute(parameter);

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}