using System;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace lab3
{
    public class Hairdresser : IXmlSerializable
    {
        private string name;
        private string surname;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value, "^[0-9]+$"))
                {
                    throw new ArgumentException("Невірно введене ім'я перукаря!");
                }

                name = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value, "^[0-9]+$"))
                {
                    throw new ArgumentException("Невірно введене прізвище перукаря!");
                }

                surname = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(surname)}: {surname}";
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Name":
                            Name = reader.ReadElementContentAsString();
                            break;
                        case "Surname":
                            Surname = reader.ReadElementContentAsString();
                            break;
                    }
                }

                if (reader.Name.Equals("Hairdresser")) break;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Name", name);
            writer.WriteElementString("Surname", surname);
        }
    }
}