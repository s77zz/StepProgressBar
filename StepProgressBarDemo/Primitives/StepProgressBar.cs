using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace StepProgressBarDemo.Primitives
{
    /// <summary>
    /// 步骤指引条控件
    /// </summary>
    public class StepProgressBar : ListBox
    {
        static StepProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StepProgressBar), new FrameworkPropertyMetadata(typeof(StepProgressBar)));
        }

        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            if (element is StepProgressBarItem stepItem)
            {
                var index = ItemContainerGenerator.IndexFromContainer(element);
                if (index == Items.Count - 1)
                {
                    stepItem.IsLastItem = true;
                }
                else
                {
                    stepItem.IsLastItem = false;
                }
            }
            base.PrepareContainerForItemOverride(element, item);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new StepProgressBarItem();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnItemsChanged(e);
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        if (e.NewStartingIndex == 0)//如果新添加项是放在第一位，则更改原来的第一位的属性值
                        {
                            SetIsLastItem(e.NewStartingIndex, Items.Count);
                        }

                        if (e.NewStartingIndex == Items.Count - e.NewItems.Count)//如果新添加项是放在最后一位，则更改原来的最后一位的属性值
                        {
                            SetIsLastItem(e.NewStartingIndex - 1, Items.Count);
                        }
                        break;
                    }
                case NotifyCollectionChangedAction.Remove:
                    {
                        if (e.OldStartingIndex == 0)//如果移除的是第一个，则更改更新后的第一项的属性值
                        {
                            SetIsLastItem(0, Items.Count);
                        }
                        else
                        {
                            SetIsLastItem(e.OldStartingIndex - 1, Items.Count);
                        }
                        break;
                    }
                case NotifyCollectionChangedAction.Reset:
                    {
                        for (int i = 0; i < Items.Count; i++)
                        {
                            SetIsLastItem(i, Items.Count);
                        }
                        break;
                    }
            }
        }

        private void SetIsLastItem(int index, int count)
        {
            if (index < count)
            {
                if (ItemContainerGenerator.ContainerFromIndex(index) is StepProgressBarItem stepItem)
                {
                    stepItem.IsLastItem = index == count - 1;
                }
            }
        }
    }
}
