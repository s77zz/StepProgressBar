using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace StepProgressBarDemo.Primitives
{
    /// <summary>
    /// 步骤指引条子项
    /// </summary>
    public class StepProgressBarItem : ListBoxItem
    {
        static StepProgressBarItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StepProgressBarItem), new FrameworkPropertyMetadata(typeof(StepProgressBarItem)));
        }

        [Bindable(true), Description("获取或者设置该节点是否就绪")]
        public bool IsDone
        {
            get { return (bool)GetValue(IsDoneProperty); }
            set { SetValue(IsDoneProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsDone.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsDoneProperty =
            DependencyProperty.Register("IsDone", typeof(bool), typeof(StepProgressBarItem), new PropertyMetadata(false));




        [Bindable(true), Description("获取或者设置该节点的就绪图片")]
        public ImageSource DoneImageSource
        {
            get { return (ImageSource)GetValue(DoneImageSourceProperty); }
            set { SetValue(DoneImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DoneImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DoneImageSourceProperty =
            DependencyProperty.Register("DoneImageSource", typeof(ImageSource), typeof(StepProgressBarItem), new PropertyMetadata(null));



        [Bindable(true), Description("获取或者设置该节点的就绪图片")]
        public ImageSource UndoneImageSource
        {
            get { return (ImageSource)GetValue(UndoneImageSourceProperty); }
            set { SetValue(UndoneImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UndoneImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UndoneImageSourceProperty =
            DependencyProperty.Register("UndoneImageSource", typeof(ImageSource), typeof(StepProgressBarItem), new PropertyMetadata(null));






        public double ImageWidth
        {
            get { return (double)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(StepProgressBarItem), new PropertyMetadata(20.0));



        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(StepProgressBarItem), new PropertyMetadata(20.0));










        [Bindable(true), Description("获取或者设置该节点是否为最后一个步骤节点")]
        public bool IsLastItem
        {
            get { return (bool)GetValue(IsLastItemProperty); }
            set { SetValue(IsLastItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsLastItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLastItemProperty =
            DependencyProperty.Register("IsLastItem", typeof(bool), typeof(StepProgressBarItem), new PropertyMetadata(true));



    }
}
