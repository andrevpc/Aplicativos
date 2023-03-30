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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            addItem();
        }

        private void OnKey_Down(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                addItem();

            }
        }

        private void addItem()
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
                MessageBox.Show("Inserido com sucesso");
            }
            else if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Clear();
                MessageBox.Show("Espaço vazio");
            }
            else
            {
                txtName.Clear();
                MessageBox.Show("Nome existente");
            }
        }

        private void OnKey_Down_List(object sender, KeyEventArgs e)
        {
            if(lstNames.SelectedItem != null)
            {
                if(e.Key == Key.Delete)
                {
                    lstNames.Items.Remove(lstNames.SelectedItem);
                    MessageBox.Show("Excluido");
                }
                else if (e.Key == Key.E)
                {
                    Microsoft.VisualBasic.Interaction.InputBox("Editar", "Editar", $"{lstNames.SelectedItem}");
                    lstNames.Items.Remove(lstNames.SelectedItem);
                }
            }
        }
    }
}
