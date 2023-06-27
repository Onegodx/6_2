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
//Миньков Владимир 22исп21 базовый уровень 7    14 вариант
namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private List<double> _array = new List<double>();

        public MainWindow()
        {
            InitializeComponent();

            AddButton.Click += OnAddButtonClick;
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ValueTextBox.Text, out double value))
            {
                _array.Add(value);

                if (value == 33)
                {
                    ProcessArray();
                }
            }
        }

        private void ProcessArray()
        {
            double maxValue = double.MinValue;

            foreach (double value in _array)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            ResultListBox.Items.Add($"Максимальный элемент массива: {maxValue}");
        }
    }
}
