using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace lab3
{
    public class HairDressingSalon : IXmlSerializable
    {
        private int salonNumber;
        private DateTime currentDate = DateTime.Now;
        private static decimal additionalServicesPrice;

        public int SalonNumber
        {
            get => salonNumber;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Номер перукарні не може бути менше 1");
                }

                salonNumber = value;
            }
        }

        public DateTime CurrentDate
        {
            get => currentDate;
            set => currentDate = value;
        }

        public static decimal AdditionalServicesPrice
        {
            get => additionalServicesPrice;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ціна додаткових послугах не може бути менше 0");
                }

                additionalServicesPrice = value;
            }
        }

        public IList<Haircut> FinishedHaircuts { get; } = new List<Haircut>();

        public override string ToString()
        {
            return
                $"Номер перукарні : {salonNumber}, дата: {currentDate}, ціна дод. послуг: {additionalServicesPrice}," +
                $" завершені зачіски: {FinishedHaircuts}";
        }

        public string ToShortString()
        {
            var todayIncomeSum = 0m;
            foreach (var haircut in FinishedHaircuts)
            {
                if (haircut.MadeAt.Date != DateTime.Today.Date) continue;
                todayIncomeSum += haircut.Price;
                if (haircut.UseAdditionalServices)
                {
                    todayIncomeSum += AdditionalServicesPrice;
                }
            }

            return $"Номер перукарні : {salonNumber}, дата: {currentDate}, сумарна вартість виконаних" +
                   $" за день робіт: {todayIncomeSum}";
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
                    if (reader.Name.Equals("SalonNumber"))
                    {
                        SalonNumber = reader.ReadElementContentAsInt();
                    }

                    if (reader.Name.Equals("CurrentDate"))
                    {
                        currentDate = DateTime.Parse(reader.ReadElementContentAsString());
                    }

                    if (reader.Name.Equals("AdditionalServicesPrice"))
                    {
                        AdditionalServicesPrice = reader.ReadElementContentAsDecimal();
                    }

                    if (reader.Name.Equals("FinishedHaircuts"))
                    {
                        if (reader.IsEmptyElement) return;
                        while (reader.Read())
                        {
                            if (reader.IsStartElement() && reader.Name.Equals("Haircut"))
                            {
                                var haircut = new Haircut();
                                try
                                {
                                    haircut.ReadXml(reader);
                                    FinishedHaircuts.Add(haircut);
                                }
                                catch (ArgumentException)
                                {
                                }
                            }

                            if (reader.Name.Equals("FinishedHaircuts")) break;
                        }
                    }
                }

                if (reader.Name.Equals("HairDressingSalon")) break;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("SalonNumber", salonNumber.ToString());
            writer.WriteElementString("CurrentDate", currentDate.ToString(CultureInfo.InvariantCulture));
            writer.WriteElementString("AdditionalServicesPrice",
                additionalServicesPrice.ToString(CultureInfo.InvariantCulture));
            writer.WriteStartElement("FinishedHaircuts");
            foreach (var haircut in FinishedHaircuts)
            {
                writer.WriteStartElement("Haircut");
                haircut.WriteXml(writer);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}