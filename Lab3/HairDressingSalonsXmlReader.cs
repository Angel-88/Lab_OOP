using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace lab3
{
    class HairDressingSalonsXmlReader
    {
        public static IEnumerable<HairDressingSalon> ReadFrom(string path)
        {
            if (!File.Exists(path)) File.Create(path).Close();
            var hairDressingSalons = new List<HairDressingSalon>();
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = XmlReader.Create(fs))
                    {
                        if (reader.EOF) return hairDressingSalons;
                        reader.Read();
                        if (reader.IsEmptyElement) return hairDressingSalons;
                        while (reader.Read())
                        {
                            if (reader.IsStartElement() && reader.Name.Equals("HairDressingSalon"))
                            {
                                var salon = new HairDressingSalon();
                                salon.ReadXml(reader);
                                hairDressingSalons.Add(salon);
                            }
                            if (reader.Name.Equals("HairDressingSalons")) break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    $"Не вдалося знайти файл з раніше збереженими перукарнями.\nДеталі помилки: {ex.Message}");
            }
            return hairDressingSalons;
        }
    }
}