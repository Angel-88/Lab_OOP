using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace lab3
{
    class HairDressingSalonsXmlWriter
    {
        public static void WriteTo(string path, XmlWriterSettings writeSettings,
            IEnumerable<HairDressingSalon> hairDressingSalons)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (var writer = XmlWriter.Create(fs, writeSettings))
                {
                    try
                    {
                        writer.WriteStartElement("HairDressingSalons");
                        foreach (var salon in hairDressingSalons)
                        {
                            writer.WriteStartElement("HairDressingSalon");
                            salon.WriteXml(writer);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Не вдалося оновити файл з раніше збереженими перукарнями." +
                            $"\nДеталі помилки:\n{ex.Message}");
                    }
                }
            }
        }
    }
}