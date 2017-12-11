using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMDemo.Model;

namespace WPFMVVMDemo.ViewModel
{
    public class StudentViewModel
    {
        public DelegateCommand ShowCommand { get; set; }
        public StudentModel Student { get; set; }
        public StudentViewModel()
        {
            Student = new StudentModel();
            ShowCommand = new DelegateCommand();
            ShowCommand.ExecuteCommand = new Action<object>(ShowStudentData);
        }
        private void ShowStudentData(object obj)
        {
            Student.StudentId = 1;
            Student.StudentName = "tiana";
            Student.StudentAge = 20;
            Student.StudentEmail = "8644003248@qq.com";
            Student.StudentSex = "大帅哥";
        }

    }

    public class DelegateCommand : ICommand
    {
        public Action<object> ExecuteCommand = null;
        public Func<object, bool> CanExecuteCommand = null;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteCommand != null)
            {
                return this.CanExecuteCommand(parameter);
            }
            else
            {
                return true;
            }
        }

        public void Execute(object parameter)
        {
            if (this.ExecuteCommand != null)
            {
                this.ExecuteCommand(parameter);
            }
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
        /*
         *代码中，除了定义StudentViewModel类外，还定义了DelegateCommand类，该类实现了ICommand接口。
ICommand接口中的Execute（）方法用于命令的执行，CanExecute（）方法用于指示当前命令在目标元素上是否可用，当这种可用性发生改变时便会触发接口中的CanExecuteChanged事件。
我们可以将实现了ICommand接口的命令DelegateCommand赋值给Button（命令源）的Command属性（只有实现了ICommandSource接口的元素才拥有该属性），这样Button便与命令进行了绑定。
         */
    }
}
