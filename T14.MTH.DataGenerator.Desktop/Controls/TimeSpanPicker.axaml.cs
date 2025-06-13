using Avalonia;
using Avalonia.Controls.Primitives;

namespace T14.MTH.DataGenerator.Desktop.Controls
{
    /// <summary>
    /// 通过 TemplatedControl 类创建自定义模板控件
    /// </summary>
    public class TimeSpanPicker : TemplatedControl
    {
        /// <summary>
        /// 声明一个公有的静态只读字段，类型为 `StyledProperty<TValue>`，`Tvalue` 为自定义属性的实际数据类型
        /// `StyledProperty<TValue>` 字段可以通过 `AvaloniaProperty.Register<TOwner, TValue>(string name, TValue defaultValue = default)` 创建，
        /// 其中 `TOwner` 为属性所属的自定义控件类型，`TValue` 为属性的实际数据类型, `name` 为属性名称，`defaultValue` 为属性的默认值
        /// </summary>
        public static readonly StyledProperty<int> HoursProperty = AvaloniaProperty.Register<TimeSpanPicker, int>(nameof(Hours), defaultValue: 0);

        /// <summary>
        /// 声明一个公有属性，表示实际的自定义属性
        /// 属性值通过 `GetValue` 方法获取，通过 `SetValue` 方法设置
        /// </summary>
        public int Hours
        {
            get => GetValue(HoursProperty);
            set => SetValue(HoursProperty, value);
        }

        public static readonly StyledProperty<int> MinutesProperty =
            AvaloniaProperty.Register<TimeSpanPicker, int>(nameof(Minutes), defaultValue: 0);

        public int Minutes
        {
            get => GetValue(MinutesProperty);
            set => SetValue(MinutesProperty, value);
        }

        public static readonly StyledProperty<int> SecondsProperty =
            AvaloniaProperty.Register<TimeSpanPicker, int>(nameof(Seconds), defaultValue: 0);

        public int Seconds
        {
            get => GetValue(SecondsProperty);
            set => SetValue(SecondsProperty, value);
        }
    }
}