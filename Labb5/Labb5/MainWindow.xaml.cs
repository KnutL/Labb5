﻿using System;
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

namespace Labb5
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
        private void ButtonSkapa_Click(object sender, RoutedEventArgs e)
        {
            /*
            user.Namn = TextBoxNamn.Text;
            user.Epost = TextBoxEpost.Text;
            */
            
            normalUsersListbox.Items.Add(new User(TextBoxNamn.Text, TextBoxEpost.Text));


            //TextBox TextBoxItem = new TextBox();
            //normalUsersListbox.Items.Add(TextBoxNamn.Text);
        }

        private void buttonTaBort_Click_1(object sender, RoutedEventArgs e)
        {

            normalUsersListbox.Items.Remove(normalUsersListbox.SelectedItem);

        }

        private void normalUsersListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonChangeToAdmin.IsEnabled = true;
            buttonTaBort.IsEnabled = true;
            if (normalUsersListbox.Items.Count == 0)
            {
                ButtonÄndra.IsEnabled = false;
                buttonTaBort.IsEnabled = false;
            }


        }
        
        private void normalUsersListbox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void buttonInfo_Click(object sender, RoutedEventArgs e)
        {

            labelUserInfo.Content = $"Namn: {user.Namn} \vEpost: {user.Epost}";
        }

        private void ButtonChangeToAdmin_Click(object sender, RoutedEventArgs e)
        {
            //AdminListBox.Items.Add(user.Namn);
            normalUsersListbox.Items.Remove(normalUsersListbox.SelectedItem);
        }

        private void ButtonChangeToUser_Click(object sender, RoutedEventArgs e)
        {
            //normalUsersListbox.Items.Add(user.Namn);
            AdminListBox.Items.Remove(AdminListBox.SelectedItem);
        }
    }
}
