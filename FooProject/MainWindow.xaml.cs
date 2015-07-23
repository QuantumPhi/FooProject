using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MahApps.Metro.Controls;

namespace FooProject
{
    public partial class MainWindow : MetroWindow
    {
        private static readonly Random r = new Random();

        private ObservableCollection<Foo> FooCollection = new ObservableCollection<Foo>(); 

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                FooCollection.Add(new Foo() { Value = r.Next() });
            }

            // NOTE: does not make difference if ItemsSource is code-behind or XAML
            // Have also tried with ViewModel
            FooGrid.ItemsSource = FooCollection;
        }
    }

    // Container class
    public class Foo
    {
        // Same error with all integer types (byte, short, int, long, etc.)
        public int Value { get; set; }
    }
}
