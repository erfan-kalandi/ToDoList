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
using Microsoft.AspNetCore.SignalR.Client;
using library;
using ListApiCli.Client;
using ListApiCli.Api;

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListApi api;
        Configuration config;
        HubConnection hubConnection;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            config = new Configuration() { BasePath = "http://localhost:5051" };
            api = new ListApi(config);
            hubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5051/HubConnection")
            .Build();
            hubConnection.On("RefreshUI", () => showItems());
            hubConnection.StartAsync();
            showItems();
            dataGrid.SelectionUnit = DataGridSelectionUnit.Cell;
        }

        public void showItems()
        {
            var items = api.ListGet();
            dataGrid.ItemsSource = items;

        }
        public void Add(object Sender, RoutedEventArgs args)
        {
            if (ItemName.Text == null || ItemDetails.Text == null || dp1.SelectedDate == null)
            {
                MessageBox.Show("Please fill all field to add");
            }
            else
            {
                try
                {
                    ListApiCli.Model.ToDoItems item = new ListApiCli.Model.ToDoItems(ItemName.Text, ItemDetails.Text, dp1.SelectedDate.Value);
                    api.ListListAddItemPost(item);
                    hubConnection.SendAsync("MakeConnection");
                    showItems();
                }
                catch
                {
                    MessageBox.Show("Your Task Id already exist");
                }
            }
            ResetBox();
        }


        public void Delete(object Sender, RoutedEventArgs args)
        {
            if (ItemName.Text == string.Empty)
            {
                MessageBox.Show("Please add an Id to delete ");
            }
            else
            {
                try
                {
                    api.ListListDeleteIdiDelete(ItemName.Text);
                    hubConnection.SendAsync("MakeConnection");
                    showItems();
                }
                catch
                {
                    MessageBox.Show("Not found any task to delete ");
                }
            }

            ResetBox();
        }

        public void ResetBox()
        {
            ItemName.Text = string.Empty;
            ItemDetails.Text = string.Empty;
            dp1.SelectedDate = null;
        }
    }
}
