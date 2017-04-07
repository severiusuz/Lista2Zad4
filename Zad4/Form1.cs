using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zad4.Model;

namespace Zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stworzButton_Click(object sender, EventArgs e)
        {

            String name = nameTextBox.Text.ToString();
            String surname = surnameTextBox.Text.ToString();
            String phoneNumber = phoneNumberTextBox.Text.ToString();
            String address = addressTextBox.Text.ToString();
            if (name.Equals("") || surname.Equals("") || phoneNumber.Equals("") || address.Equals(""))
            {
                MessageBox.Show("Nie dawaj szczyszczonych danych","Szczyszczone Dane WARNING!");
            } else
            {
                PersonalData person = new PersonalData(address, phoneNumber, name, surname);
                personListBox.Items.Add(person);
                szczyscNaAmen();
            }
        }

        private void szczyscButton_Click(object sender, EventArgs e)
        {
            szczyscNaAmen();
        }

        private void szczyscNaAmen()
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
        }

        private void spreparujButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = personListBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                PersonalData ps = (PersonalData)personListBox.SelectedItem;
                ps.name = nameTextBox.Text;
                ps.surname = surnameTextBox.Text;
                ps.address = addressTextBox.Text;
                ps.phoneNumber = phoneNumberTextBox.Text;
                personListBox.Items[selectedIndex] = ps;
            }
        }

        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = personListBox.SelectedIndex;
            if (selectedIndex >= 0) { 
                PersonalData ps = (PersonalData)personListBox.SelectedItem;
                nameTextBox.Text = ps.name;
                surnameTextBox.Text = ps.surname;
                phoneNumberTextBox.Text = ps.phoneNumber;
                addressTextBox.Text = ps.address;
            }
        }

        private void skasujButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = personListBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                personListBox.Items.RemoveAt(selectedIndex);
                szczyscNaAmen();
            }
        }
    }
}
