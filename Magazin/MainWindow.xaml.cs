using Extensie;
using System;
using System.Collections.Generic;
using System.Data;
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


namespace Magazin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { //using Extensie;
        ActionState action = ActionState.Nothing;
        Model1 ctx = new Model1();
        CollectionViewSource customerVSource;
        private CollectionViewSource clientiVSource;
        CollectionViewSource clienticomenziVSource;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource comenziViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("comenziViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // comenziViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource produseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("produseViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // produseViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource clientiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientiViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // clientiViewSource.Source = [generic data source]
        }
        enum ActionState
        {
            New,
            Edit,
            Delete,
            Nothing
        }

        private void idclientTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //using System.Data.Entity;
            clientiVSource =
           ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientiViewSource")));
 //clientiVSource.Source = ctx.Clienti.Local;
            //ctx.Clienti.Load();
        }

        private void btnAdauga_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.New;
            MessageBox.Show("Adaugat cu succes!");
        }

        private void btnModifica_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.Edit;
            MessageBox.Show("Modificat cu succes!");
        }

        private void btnSterge_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.Delete;
            MessageBox.Show("Sters cu succes!");

        }
        private void SaveCustomers()
        {
            Clienti customer = null;
            if (action == ActionState.New)
            {
                try
                {

                    customer = new Clienti()
                    {
                        Nume = numeTextBox.Text.Trim(),
                        Prenume = prenumeTextBox.Text.Trim()
                    };

                  //ctx.Clienti.Add(customer);
                    clientiVSource.View.Refresh();

                    ctx.SaveChanges();
                }
                //using System.Data;
                catch (DataException ex)
                {
                    MessageBox.Show("Salvat cu succes!");
                }
            }
            else
if (action == ActionState.Edit)
            {
                try
                {
                    customer = (Clienti)clientiDataGrid.SelectedItem;
                    customer.Nume = numeTextBox.Text.Trim();
                    customer.Prenume = prenumeTextBox.Text.Trim();

                    ctx.SaveChanges();
                }
                catch (DataException)
                {
                    MessageBox.Show("Modificari salvate!");
                }
            }
            else if (action == ActionState.Delete)
            {
                try
                {
                    customer = (Clienti)clientiDataGrid.SelectedItem;
                 // ctx.Clienti.Remove(customer);
                    ctx.SaveChanges();
                }
                catch (DataException)
                {
                    MessageBox.Show("Sters");
                }
                customerVSource.View.Refresh();
            }

        }

        private void btnIesire_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show("Aplicatie inchisa!");

        }

        private void btnSalvare_Click(object sender, RoutedEventArgs e)
        {
            TabItem ti = tbCtrlAutoLot.SelectedItem as TabItem;

            switch (ti.Header)
            {
                case "Clienti":
                 // SaveClienti();
                    break;
                case "Produse":
                 // SaveProduse();
                    break;
                    MessageBox.Show("Salvat");
                
            }
        }
    }
}

    


        
    

