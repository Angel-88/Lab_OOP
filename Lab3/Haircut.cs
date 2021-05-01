using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace lab3
{
    public class Haircut : IXmlSerializable
    {
        private string name = string.Empty;
        private Client client = Client.Man;
        private Hairdresser hairdresser;
        private int price;
        private bool useAdditionalServices;
        private DateTime madeAt = DateTime.Now;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value, "^[0-9]+$"))
                {
                    throw new ArgumentException("Невірно введена назва зачіски!");
                }

                name = value;
            }
        }

        public Client Client
        {
            get => client;
            set => client = value;
        }

        public Hairdresser Hairdresser
        {
            get => hairdresser;
            set { hairdresser = value ?? throw new ArgumentNullException("Відсутній перукар для зачіски!"); }
        }

        public int Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ціна не може бути менше 0!");
                }

                price = value;
            }
        }

        public bool UseAdditionalServices
        {
            get => useAdditionalServices;
            set => useAdditionalServices = value;
        }

        public DateTime MadeAt
        {
            get => madeAt;
            set
            {
                if (value > DateTime.Today.AddDays(1.0))
                {
                    throw new ArgumentException(
                        $"Зачіска не може бути зроблена пізніше ніж {DateTime.Today.ToShortDateString()}!");
                }

                madeAt = value;
            }
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
                        case "Client":
                            Enum.TryParse(reader.ReadElementContentAsString(), out client);
                            break;
                        case "Hairdresser":
                            hairdresser = new Hairdresser();
                            hairdresser.ReadXml(reader);
                            break;
                        case "Price":
                            Price = int.Parse(reader.ReadElementContentAsString());
                            break;
                        case "UseAdditionalServices":
                            UseAdditionalServices = bool.Parse(reader.ReadElementContentAsString());
                            break;
                        case "MadeAt":
                            MadeAt = DateTime.Parse(reader.ReadElementContentAsString());
                            break;
                    }
                }

                if (reader.Name.Equals("Haircut")) break;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Name", name);
            writer.WriteElementString("Client", client.ToString());
            writer.WriteStartElement("Hairdresser");
            hairdresser.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteElementString("Price", price.ToString());
            writer.WriteElementString("UseAdditionalServices", useAdditionalServices.ToString());
            writer.WriteElementString("MadeAt", madeAt.ToString(CultureInfo.InvariantCulture));
        }

        public override string ToString()
        {
            return $"Назва: {name}, клієнт: {client}, перукар: {hairdresser}, ціна: {price}, " +
                   $"потрібні додаткові послуги: {useAdditionalServices}, дата виконання: {madeAt}";
        }
    }
}