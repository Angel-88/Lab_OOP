using System;
using System.Globalization;
using System.Windows.Forms;

namespace lab3
{
    public partial class HairDressingSalonForm : Form
    {
        public HairDressingSalon HairDressingSalon { get; }

        public HairDressingSalonForm()
        {
            InitializeComponent();
            editBtn.Enabled = haircutsListBox.SelectedIndices.Count == 1;
            HairDressingSalon = new HairDressingSalon();
        }

        public HairDressingSalonForm(HairDressingSalon hairDressingSalon)
        {
            InitializeComponent();
            HairDressingSalon = hairDressingSalon;
            editBtn.Enabled = haircutsListBox.SelectedIndices.Count == 1;
            FillFormWithExistingProps();
        }
        
        private void FillFormWithExistingProps()
        {
            salonNumberBox.Text = HairDressingSalon.SalonNumber.ToString();
            dateTimePicker1.Value = DateTime.Today;
            servicePriceTextBox.Text = HairDressingSalon.AdditionalServicesPrice.ToString(CultureInfo.InvariantCulture);
            foreach (var haircut in HairDressingSalon.FinishedHaircuts)
            {
                haircutsListBox.Items.Add(haircut);
            }
        }

        private void hairdressersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editBtn.Enabled = haircutsListBox.SelectedIndices.Count == 1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var haircutForm = new HaircutForm();
            if (haircutForm.ShowDialog() != DialogResult.OK) return;
            var newHaircut = haircutForm.Haircut;
            HairDressingSalon.FinishedHaircuts.Add(newHaircut);
            haircutsListBox.Items.Add(newHaircut.ToString());
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var selectedIndex = haircutsListBox.SelectedIndex;
            var haircutForm = new HaircutForm(HairDressingSalon.FinishedHaircuts[selectedIndex]);
            if (haircutForm.ShowDialog() != DialogResult.OK) return;
            HairDressingSalon.FinishedHaircuts[selectedIndex] = haircutForm.Haircut;
            haircutsListBox.Items[selectedIndex] = HairDressingSalon.FinishedHaircuts[selectedIndex].ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void HairDressingSalonForm_FormClosing(object sender, FormClosingEventArgs e)
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
            HairDressingSalon.SalonNumber = int.Parse(salonNumberBox.Text);
            HairDressingSalon.CurrentDate = dateTimePicker1.Value;
            HairDressingSalon.AdditionalServicesPrice = int.Parse(servicePriceTextBox.Text);
        }
    }
}