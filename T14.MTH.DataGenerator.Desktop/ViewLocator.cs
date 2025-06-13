using Avalonia.Controls;
using Avalonia.Controls.Templates;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Diagnostics;

namespace T14.MTH.DataGenerator.Desktop
{
    /// <summary>
    /// ViewLocator 可以用于页面导航，根据 ContentControl 的 Content 属性所使用的 ViewModel 自动创建对应的 View <para>ViewLocator 本质上是一个
    /// DataTemplate，其 Data 为 ViewModel，Template 为 View</para>
    /// </summary>
    public class ViewLocator : IDataTemplate
    {
        /// <summary>
        /// 根据 ViewModel 的实例自动创建对应的 View 实例
        /// </summary>
        /// <param name="param">ViewModel</param>
        /// <returns>View</returns>
        public Control? Build(object? param)
        {
            if (param is null)
            {
                return null;
            }

            // 根据 ViewModel 的完全限定名来获取 View 的完全限定名（将完全限定名中的所有 "View" 替换为 "ViewModel"）
            // 例如：T14.MTH.DataGenerator.Desktop.ViewModels.HomeViewModel -> T14.MTH.DataGenerator.Desktop.Views.HomeView
            // 注意：将 View 绑定到 UserControl 上使用时，View 的根元素也必须使用 UserControl，View 生成的类也必须继承自 UserControl，而不能使用 Window 等顶层元素
            string name = param.GetType().FullName!.Replace("ViewModel", "View", StringComparison.Ordinal);

            // 根据 View 的完全限定名获取对应的 Type
            Type? type = Type.GetType(name);

            // 如果找到 View 的 Type，则创建实例并返回
            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }

            // 如果没有找到对应的 View，则返回一个简单的 TextBlock 显示未找到的消息
            return new TextBlock { Text = $"Not Found: {name}" };
        }

        /// <summary>
        /// 判断 Data 是否是 ObservableObject
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Match(object? data)
        {
            return data is ObservableObject;
        }
    }
}
