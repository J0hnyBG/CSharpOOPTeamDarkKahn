﻿using ConsoleApplication2.Models.People;
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
using System.Windows.Shapes;

namespace WPFGUI
{
    /// <summary>
    /// Interaction logic for PatientGetGUI.xaml
    /// </summary>
    public partial class PatientGetGUI : Window
    {
        Patient currentSelection;
        public PatientGetGUI()
        {
            InitializeComponent();
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = GUIData.patients;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comoBox = sender as ComboBox;
            currentSelection = (Patient)comboBox.SelectedItem;
            textBox.Text = currentSelection.ContactInfo.FirstName;
            textBox1.Text = currentSelection.ContactInfo.MiddleName;
            textBox2.Text = currentSelection.ContactInfo.LastName;
            textBox3.Text = currentSelection.ContactInfo.Email;
            textBox4.Text = currentSelection.ContactInfo.PhoneNumber;
            textBox5.Text = currentSelection.Pid;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
