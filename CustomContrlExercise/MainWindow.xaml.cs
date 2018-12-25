using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CustomContrlExercise
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataObject() { name = "Jeong Yo Han" };
        }

        public class DataObject : INotifyPropertyChanged
        {
            private string _name;
            public string name
            {
                get { return _name; }
                set { /* break point here*/
                    _name = value;
                    onPropertyChanged("name");
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            public void onPropertyChanged(string name)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
