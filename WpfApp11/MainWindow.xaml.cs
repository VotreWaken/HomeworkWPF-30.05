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
using System.Xml.Linq;

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Controller
        Controller controller_;
        public MainWindow()
        {
            InitializeComponent();
            controller_ = new Controller();
        }
        // Button Find Click
        private void BtnFindClick(object sender, RoutedEventArgs e)
        {
            LBSavedData.Items.Clear();
            var items = controller_.FindPerson(TBFind.Text);
            foreach (var item in items)
            {
                LBSavedData.Items.Add(item);
            }
        }
        // Button Save Click
        private void BtnSaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                controller_.AddPerson(TBName.Text, int.Parse(TBAge.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Correct Input Data");
            }
        }
        // Button Show Click
        private void BtnShowlick(object sender, RoutedEventArgs e)
        {
            Print();
        }
        // Print 
        void Print()
        {
            LBSavedData.Items.Clear();
            foreach (var item in controller_.GetAllPerson())
            {
                LBSavedData.Items.Add(item);
            }
        }

        private void ContextMenuShowClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = LBSavedData.SelectedItem;
                MessageBox.Show(a.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Not Selected Object");
            }
        }

        private void ContextMenuClearClick(object sender, RoutedEventArgs e)
        {
            LBSavedData.Items.Clear();
        }

        private void ContextMenuDeleteSelectedClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = LBSavedData.SelectedItem;
                controller_.DeletePerson((Model.Person)a);
                Print();
            }
            catch (Exception)
            {
                MessageBox.Show("Not Selected Object");
            }
        }
    }
}
