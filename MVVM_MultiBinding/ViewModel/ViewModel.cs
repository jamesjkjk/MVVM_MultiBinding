using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_MultiBinding.Command;


namespace MVVM_MultiBinding.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ICommand MyCommand1 { get; set; }
        public ICommand MyCommand2 { get; set; }
        public ICommand MyCommand3 { get; set; }
        public ICommand MyCommand4 { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged( string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        private double _number1;
        public double Number1
        {
            get { return _number1; }
            set { _number1 = value; OnPropertyChanged("Number1"); }
        }


        private double _number2;
        public double Number2
        {
            get { return _number2; }
            set { _number2 = value; OnPropertyChanged("Number2"); }
        }


        private double nubersum;

        public double NumberSum
        {
            get { return nubersum; }
            set { nubersum = value; OnPropertyChanged("NumberSum"); }
        }


        public ViewModel()
        {
            MyCommand1 = new RelayCommand(execute1, canexecute);
            MyCommand2 = new RelayCommand(execute2, canexecute);
            MyCommand3 = new RelayCommand(execute3, canexecute);
            MyCommand4 = new RelayCommand(execute4, canexecute);
        }


        private bool canexecute(object parameter)
        {             
           return true;
        }

        private void execute1(object parameter)
        {
            NumberSum = Number1 + Number2;
        }
        private void execute2(object parameter)
        {
            NumberSum = Number1 -Number2;
        }
        private void execute3(object parameter)
        {
            NumberSum = Number1 * Number2;
        }
        private void execute4(object parameter)
        {
            NumberSum = Number1 / Number2;
        }

    }
}
