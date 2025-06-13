using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace T14.MTH.DataGenerator.Desktop.ViewModels
{
    public partial class HomeViewModel : ObservableValidator
    {

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _incTemHours = 4;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _incTemMinutes = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _incTemSeconds = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _constTemHours = 12;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _constTemMinutes = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _constTemSeconds = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _decTemHours = 8;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _decTemMinutes = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _decTemSeconds = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(-50, 100)]
        private double _initTem = 18.0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(-50, 100)]
        private double _maxTem = 25.0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required]
        private double _temErr = 2.0;

        [ObservableProperty] private bool _autoGetTem = true;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _incHumHours = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _incHumMinutes = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _incHumSeconds = 10;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _constHumHours = 23;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _constHumMinutes = 59;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _constHumSeconds = 50;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _decHumHours = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _decHumMinutes = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _decHumSeconds = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(-50, 100)]
        private double _initHum = 70.0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(-50, 100)]
        private double _maxHum = 99.4;

        [ObservableProperty] [NotifyDataErrorInfo] [Required]
        private double _humErr = 0.2;

        [ObservableProperty] private bool _autoGetHum = true;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [DataType(DataType.Time)]
        private DateTime _startDateTime = DateTime.Now;

        [ObservableProperty]
        private string _dateTimeFormat = "yyyy/M/d H:mm:ss";

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _sampIntvHours = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _sampIntvMinutes = 5;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private double _sampIntvSeconds = 0;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private int _sampTemNum = 16;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private int _sampHumNum = 2;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private int _areaNo = 1;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private int _lineNo = 1;

        [ObservableProperty] [NotifyDataErrorInfo] [Required]
        private string _wmoNo = "59485";

        [ObservableProperty] [NotifyDataErrorInfo] [Required]
        private string _selectedSavePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "蒸养温湿度数据");

        [ObservableProperty]
        private string _suggestSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        [ObservableProperty] private bool _autoFileName = true;

        [ObservableProperty] private bool _exportAreaLine = true;

        [ObservableProperty] private bool _exportSampDate = true;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private int _temPrec = 1;

        [ObservableProperty] [NotifyDataErrorInfo] [Required] [Range(0, int.MaxValue)]
        private int _humPrec = 1;

        [ObservableProperty] private ObservableCollection<LogItem> _logList = new ObservableCollection<LogItem>(
            new List<LogItem>()
            {
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Info", Message = "初始化完成" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Error", Message = "发生错误" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Warning", Message = "发生警告" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Info", Message = "初始化完成" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Error", Message = "发生错误" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Warning", Message = "发生警告" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Info", Message = "初始化完成" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Error", Message = "发生错误" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Warning", Message = "发生警告" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Info", Message = "初始化完成" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Error", Message = "发生错误" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Warning", Message = "发生警告" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Info", Message = "初始化完成" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Error", Message = "发生错误" },
                new LogItem() { Time = "2021-12-12 12:12:12", Level = "Warning", Message = "发生警告" },
            });
    }

    public class LogItem
    {
        public required string Time { get; set; }
        public required string Level { get; set; }
        public required string Message { get; set; }
    }
}
