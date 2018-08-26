using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Drawing;

namespace GameTester
{
    class BaseCard
    {
        public static readonly BaseCard Instance = new BaseCard();
        public ImageFile ImageBase;

        private BaseCard()
        {
            ImageBase = new ImageFile();
        }
        public Dictionary<Guid,String> GetListCardsFormBase()
        {
            throw new NotImplementedException();
        }
        public Card GetCard(Guid guid)
        {
            throw new NotImplementedException();
        }
        void UploadBaseChanging()
        {

        }
        void ApplyChanging()
        {

        }
        void AddCardsToBase(string XMLEffectPath)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(new StreamReader(XMLEffectPath).ReadToEnd());
            //foreach (XmlNode XMLCardDescription in doc.GetElementsByTagName("Card"))
            //{
            //    Card card = new Card();

            //    card.Header = XMLCardDescription.SelectSingleNode("Header").InnerText;
            //    card.Description = XMLCardDescription.SelectSingleNode("Description").InnerText;
            //    card.ImageRef = GetImage(XMLCardDescription.SelectSingleNode("Image").InnerText);

            //    //Заполняем эффекты
            //    card.effects = new List<Effect>();
            //    foreach (XmlNode EffectXML in XMLCardDescription.SelectSingleNode("Effects").ChildNodes)
            //    {
            //        XmlNode EffectParamsNode = EffectXML.SelectSingleNode("Parameters");
            //        List<object> Params = new List<object>();
            //        for (int i = 0; i < EffectParamsNode.ChildNodes.Count; i++)
            //        {
            //            Params.Add(EffectParamsNode.ChildNodes[i].InnerText);
            //        }
            //        string MethodName = EffectXML.SelectSingleNode("Name").InnerText;
            //        card.effects.Add(new Effect(MethodName, Params));
            //    }
            //    Decka.Add(card);
            //}
        }
        //private static Guid GetImage(string path)
        //{
        //    Image image = null;
        //    Guid guid = Guid.NewGuid();
        //    try
        //    {
        //        using (FileStream fs = new FileStream(path, FileMode.Open))
        //        {
        //            image = Image.FromStream(fs);
        //            fs.Close();
        //        }
        //    }
        //    catch
        //    {
        //        image = Properties.Resources.NoImage;
        //    }
        //    finally
        //    {
        //        ImagesStorage.Add(guid, image);
        //    }
        //    return guid;
        //}
    }
    public class ImageFile
    {
        private string pathImageBase = @"E:\MyProject\Temp\imagedata.db";
        private string pathImageBaseDescription = @"E:\MyProject\Temp\imagedatadesc.xml";
        private List<ImageItem> Images;
        public ImageFile()
        {
            Images = new List<ImageItem>();

            XmlDocument doc = new XmlDocument();
            if (!File.Exists(pathImageBaseDescription)) return;
            doc.Load(pathImageBaseDescription);
            foreach( XmlNode XMLImageDescription in doc.GetElementsByTagName("Image"))
            {
                ImageItem item = new ImageItem
                { 
                  uid =  Guid.Parse(XMLImageDescription.SelectSingleNode("UID").InnerText),
                  Name =  XMLImageDescription.SelectSingleNode("Name").InnerText,
                  Description =  XMLImageDescription.SelectSingleNode("Description").InnerText,
                  FilePosition =  long.Parse(XMLImageDescription.SelectSingleNode("FilePosition").InnerText),
                  LengthFile = long.Parse(XMLImageDescription.SelectSingleNode("LengthFile").InnerText)
                };
                Images.Add(item);
            }
        }
        /// <summary>
        /// Добавляет к библиотеке Images изображение и возвращает его библиотченое описание
        /// </summary>
        /// <param name="image"></param>
        /// <param name="Name"></param>
        /// <param name="Description"></param>
        /// <returns></returns>
        public ImageItem AddImage(Image image, string Name, string Description)
        {
            ImageItem OUT = new ImageItem();

            FileStream fs = new FileStream(pathImageBase, FileMode.Append);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] arrayImage = ms.ToArray();

                OUT.uid = Guid.NewGuid();
                OUT.Name = Name;
                OUT.Description = Description;
                OUT.FilePosition = fs.Length;
                OUT.LengthFile = ms.Length;
                fs.Write(arrayImage, 0, arrayImage.Length);
                fs.Close();
            }
            Images.Add(OUT);
            return OUT;
        }
        /// <summary>
        /// Отдаёт изображение по guid
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Image GetImage(Guid guid)
        {
            Image OUT;
            int index = Images.FindIndex(x => x.uid == guid);
            if(index != -1)
            {
                OUT = GetImage(Images[index].FilePosition, Images[index].LengthFile);
            }
            else
            {
                OUT = Properties.Resources.NoImage;
            }
            return OUT;
        }
        private Image GetImage(long pos, long length)
        {
            Image OUT;
            FileStream fs = new FileStream(pathImageBase, FileMode.OpenOrCreate);
            fs.Position = pos;
            byte[] buffArr = new byte[length];
            fs.Read(buffArr, 0, (int)length);
            using (MemoryStream ms = new MemoryStream(buffArr))
            {
                OUT = Image.FromStream(ms);
            }
            fs.Close();
            return OUT;
        }
        public void SaveLibrary()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Root");

            foreach (var item in Images)
            {
                var image = doc.CreateElement("Image");
                var uid = doc.CreateElement("UID"); uid.InnerText = item.uid.ToString();
                var name = doc.CreateElement("Name"); name.InnerText = item.Name;
                var Description = doc.CreateElement("Description"); Description.InnerText = item.Description.ToString();
                var FilePosition = doc.CreateElement("FilePosition"); FilePosition.InnerText = item.FilePosition.ToString();
                var LengthFile = doc.CreateElement("LengthFile"); LengthFile.InnerText = item.LengthFile.ToString();

                image.AppendChild(uid);
                image.AppendChild(name);
                image.AppendChild(Description);
                image.AppendChild(FilePosition);
                image.AppendChild(LengthFile);

                root.AppendChild(image);
            }

            doc.AppendChild(root);

            using (FileStream fs = new FileStream(pathImageBaseDescription, FileMode.Create))
            {
                doc.Save(fs);
                fs.Close();
            } 
        }
        ~ImageFile()
        {
            SaveLibrary();
        }
    }
    public class ImageItem
    {
       public Guid uid;
       public string Name;
       public string Description;
       public long FilePosition;
       public long LengthFile;
    }
}
