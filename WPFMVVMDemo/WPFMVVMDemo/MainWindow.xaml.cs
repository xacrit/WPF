using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFMVVMDemo.ViewModel;

namespace WPFMVVMDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new StudentViewModel();
        }
    }
}
/*
WPF中使用MVVM可以降低UI显示与后端逻辑代码的耦合度，即更换界面时，只需要修改很少的逻辑代码就可以实现，甚至不用修改。
在WinForm开发中，我们一般会直接操作界面的元素（如：TextBox1.Text=“aaa”），这样一来，界面变化后，后端逻辑代码也需要做相应的变更。
在WPF中使用数据绑定机制，当数据变化后，数据会通知界面变更的发生，而不需要通过访问界面元素来修改值，这样在后端逻辑代码中也就不必操作或者很少操作界面的元素了。
使用MVVM，可以很好的配合WPF的数据绑定机制来实现UI与逻辑代码的分离，MVVM中的View表示界面，负责页面显示，ViewModel负责逻辑处理，包括准备绑定的数据和命令，ViewModel通过View的DataContext属性绑定至View，Model为业务模型，供ViewModel使用。
 */
