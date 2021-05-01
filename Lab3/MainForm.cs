using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace lab3
{
    public partial class MainForm : Form
    {
        private static readonly string StoragePath = Path.Combine(Directory.GetCurrentDirectory(), "storage.xml");

        private IDictionary<string, HairDressingSalon> hairDressingSalons = new Dictionary<string, HairDressingSalon>();

        public MainForm()
        {
            InitializeComponent();
            editBtn.Enabled = salonsListBox.SelectedIndices.Count == 1;
        }

        private void salonsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editBtn.Enabled = salonsListBox.SelectedIndices.Count == 1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var salonForm = new HairDressingSalonForm();
            if (salonForm.ShowDialog() != DialogResult.OK) return;
            var newSalon = salonForm.HairDressingSalon;
            hairDressingSalons.Add(newSalon.ToShortString(), newSalon);
            salonsListBox.Items.Add(newSalon.ToShortString());
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var selectedIndex = salonsListBox.SelectedIndex;
            var id = salonsListBox.SelectedItem.ToString();
            hairDressingSalons.TryGetValue(id, out var selectedSalon);
            if (selectedSalon == null) return;
            var hairDressingSalonForm = new HairDressingSalonForm(selectedSalon);
            if (hairDressingSalonForm.ShowDialog() != DialogResult.OK) return;
            hairDressingSalons.Remove(id);
            var updatedSalon = hairDressingSalonForm.HairDressingSalon;
            hairDressingSalons.Add(updatedSalon.ToShortString(), updatedSalon);
            salonsListBox.Items[selectedIndex] = updatedSalon.ToShortString();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var writeSettings = new XmlWriterSettings
            {
                Indent = true,
                NewLineOnAttributes = true,
                OmitXmlDeclaration = false,
                ConformanceLevel = ConformanceLevel.Auto
            };
            HairDressingSalonsXmlWriter.WriteTo(StoragePath, writeSettings, hairDressingSalons.Values.ToList());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var salons = HairDressingSalonsXmlReader.ReadFrom(StoragePath);
            foreach (var salon in salons)
            {
                hairDressingSalons.Add(salon.ToShortString(), salon);
                salonsListBox.Items.Add(salon.ToShortString());
            }
        }
    }
}