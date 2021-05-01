using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab3
{
    public partial class HairdresserForm : Form
    {
        public Hairdresser Hairdresser { get; }

        public HairdresserForm()
        {
            InitializeComponent();
            Hairdresser = new Hairdresser();
        }

        public HairdresserForm(Hairdresser hairdresser)
        {
            InitializeComponent();
            this.Hairdresser = hairdresser;
            FillFormWithExistingProps();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FillFormWithExistingProps()
        {
            nameTextBox.Text = Hairdresser.Name;
            surnameTextBox.Text = Hairdresser.Surname;
        }

        private void HairdresserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            if (MessageBox.Show("Чи зберігати зміни?", "Закриття форми", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Зміни скасовано.");
            }
        }

        private void SaveChanges()
        {
            Hairdresser.Name = nameTextBox.Text;
            Hairdresser.Surname = surnameTextBox.Text;
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || Regex.IsMatch(nameTextBox.Text, "^[0-9]+$"))
            {
                e.Cancel = true;
                MessageBox.Show("Неправильно введене ім'я перукаря!");
            }
        }

        private void surnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || Regex.IsMatch(nameTextBox.Text, "^[0-9]+$"))
            {
                e.Cancel = true;
                MessageBox.Show("Неправильно введене прізвище перукаря!");
            }
        }
    }
}