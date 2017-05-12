using System;
using System.Collections;
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
        private FileManager _fileManager;
        private const string FileName = "zad4.txt";

        public Form1()
        {
            InitializeComponent();
            _fileManager = new FileManager();
        }

        private void stworzButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text.ToString();
            var surname = surnameTextBox.Text.ToString();
            var phoneNumber = phoneNumberTextBox.Text.ToString();
            var address = addressTextBox.Text.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)
                || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Nie dawaj szczyszczonych danych", "Szczyszczone Dane WARNING!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var person = new PersonalData(address, phoneNumber, name, surname);
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
                ps.Name = nameTextBox.Text;
                ps.Surname = surnameTextBox.Text;
                ps.Address = addressTextBox.Text;
                ps.PhoneNumber = phoneNumberTextBox.Text;
                personListBox.Items[selectedIndex] = ps;
            }
        }

        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = personListBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                PersonalData ps = (PersonalData)personListBox.SelectedItem;
                nameTextBox.Text = ps.Name;
                surnameTextBox.Text = ps.Surname;
                phoneNumberTextBox.Text = ps.PhoneNumber;
                addressTextBox.Text = ps.Address;
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

        private void Save_MouseClick(object sender, MouseEventArgs e)
        {
            var list = new List<PersonalData>();
            foreach (var person in personListBox.Items)
                list.Add((PersonalData)person);

            _fileManager.SaveToFile(list, FileName);
        }

        private void Load_MouseClick(object sender, MouseEventArgs e)
        {
            personListBox.DataSource = _fileManager.LoadFromFile(FileName);
        }
    }
}
