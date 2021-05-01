using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab3
{
    public partial class HaircutForm : Form
    {
        public Haircut Haircut { get; }

        public HaircutForm()
        {
            InitializeComponent();
            Haircut = new Haircut();
            FillClientComboBox();
            editBtn.Enabled = false;
        }

        public HaircutForm(Haircut haircut)
        {
            InitializeComponent();
            Haircut = haircut;
            FillClientComboBox();
            FillFormWithExistingProps();
            addBtn.Enabled = false;
        }

        private void FillFormWithExistingProps()
        {
            nameTextBox.Text = Haircut.Name;
            priceTextBox.Text = Haircut.Price.ToString();
            hairdresserRichTextBox.Text = Haircut.Hairdresser.ToString();
            dateTimePicker1.Value = Haircut.MadeAt;
            additionalServicescheckBox.Checked = Haircut.UseAdditionalServices;
        }

        private void FillClientComboBox()
        {
            var clients = (Client[]) Enum.GetValues(typeof(Client));
            foreach (var c in clients)
            {
                clientComboBox.Items.Add(c);
            }
            clientComboBox.SelectedIndex = (int) Haircut.Client;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            var hairdresserForm = new HairdresserForm();
            if (hairdresserForm.ShowDialog() != DialogResult.OK) return;
            Haircut.Hairdresser = hairdresserForm.Hairdresser;
            hairdresserRichTextBox.Text = Haircut.Hairdresser.ToString();
            addBtn.Enabled = false;
            editBtn.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var hairdresserForm = new HairdresserForm(Haircut.Hairdresser);
            if (hairdresserForm.ShowDialog() != DialogResult.OK) return;
            Haircut.Hairdresser = hairdresserForm.Hairdresser;
            hairdresserRichTextBox.Text = Haircut.Hairdresser.ToString();
        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Haircut.Client = (Client) clientComboBox.SelectedIndex;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Haircut.Hairdresser is null)
                {
                    MessageBox.Show("Додайте перукаря!");
                    return;
                }
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

        private void HaircutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            if (MessageBox.Show("Чи зберігати зміни?", "Закриття форми", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                try
                {
                    SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception exception)
                {
                    e.Cancel = true;
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Зміни скасовано.");
            }
        }

        private void SaveChanges()
        {
            Haircut.Name = nameTextBox.Text;
            Haircut.Client = (Client) clientComboBox.SelectedIndex;
            Haircut.Price = int.Parse(priceTextBox.Text);
            Haircut.MadeAt = dateTimePicker1.Value;
            Haircut.UseAdditionalServices = additionalServicescheckBox.Checked;
        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            var isValidInt = int.TryParse(priceTextBox.Text, out var inputPrice);
            if (!isValidInt)
            {
                e.Cancel = true;
                MessageBox.Show("Неправильно введена ціна зачіски!");
            }
            if (inputPrice < 0)
            {
                e.Cancel = true;
                MessageBox.Show("Ціна зачіски не може бути менше 0!");
            }
        }
    }
}