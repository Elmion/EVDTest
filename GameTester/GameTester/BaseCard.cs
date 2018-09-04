using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Configuration;
using System.Reflection;
using System.Collections;

namespace GameTester
{
    class CardBase
    {
        public static readonly CardBase Instance = new CardBase();
        public ImageFile ImageBase;
        public List<Card> Cards;
        private CardBase()
        {
            ImageBase = new ImageFile();
            Cards = new List<Card>();

            if (!File.Exists(ConfigurationManager.AppSettings["XMLCardBasePath"])) return;

            XmlDocument doc = new XmlDocument();
            
            doc.Load(ConfigurationManager.AppSettings["XMLCardBasePath"]); 
            foreach (XmlNode XMLCardDescription in doc.GetElementsByTagName("Card"))
            {
                Card card = new Card();

                card.Header = XMLCardDescription.SelectSingleNode("Header").InnerText;
                card.Description = XMLCardDescription.SelectSingleNode("Description").InnerText;
                card.uid =  Guid.Parse(XMLCardDescription.SelectSingleNode("uid").InnerText);

                card.ImageRef = Guid.Parse(XMLCardDescription.SelectSingleNode("Image").InnerText);

                //Заполняем эффекты
                card.effects = new List<ParametredAction>();
                foreach (XmlNode EffectXML in XMLCardDescription.SelectSingleNode("Effects").ChildNodes)
                {
                    XmlNode EffectParamsNode = EffectXML.SelectSingleNode("Parameters");
                    List<object> Params = new List<object>();
                    for (int i = 0; i < EffectParamsNode.ChildNodes.Count; i++)
                    {
                        Params.Add(EffectParamsNode.ChildNodes[i].InnerText);
                    }
                    string EffectName = EffectXML.SelectSingleNode("Name").InnerText;
                    string MethodName = EffectXML.SelectSingleNode("MethodName").InnerText;

                    ParameterInfo[] info = typeof(Effect).GetMethod(MethodName).GetParameters();
                    ArrayList ReadyParams = new ArrayList();
                    for (int j = 0; j < info.Length; j++)
                    {

                        if (!info[j].ParameterType.IsEnum)
                            ReadyParams.Add(Convert.ChangeType(Params[j], info[j].ParameterType));
                        else
                            ReadyParams.Add(Enum.Parse(info[j].ParameterType, (string)Params[j]));
                        
                    }
                          
                    ParametredAction pa = new ParametredAction(typeof(Effect).GetMethod(MethodName), ReadyParams.ToArray(), typeof(Effect));
                    pa.Name = EffectName;
                    card.effects.Add(pa);
                }

                //Заполняем доступы
                card.accesses = new List<ParametredAction>();
                foreach (XmlNode AccessXML in XMLCardDescription.SelectSingleNode("Accesses").ChildNodes)
                {
                    XmlNode AccessParamsNode = AccessXML.SelectSingleNode("Parameters");
                    List<object> Params = new List<object>();
                    for (int i = 0; i < AccessParamsNode.ChildNodes.Count; i++)
                    {
                        Params.Add(AccessParamsNode.ChildNodes[i].InnerText);
                    }
                    string AccessName = AccessXML.SelectSingleNode("Name").InnerText;
                    string MethodName = AccessXML.SelectSingleNode("MethodName").InnerText;

                    ParameterInfo[] info = typeof(Access).GetMethod(MethodName).GetParameters();
                    ArrayList ReadyParams = new ArrayList();
                    for (int j = 0; j < info.Length; j++)
                    {

                        if (!info[j].ParameterType.IsEnum)
                            ReadyParams.Add(Convert.ChangeType(Params[j], info[j].ParameterType));
                        else
                            ReadyParams.Add(Enum.Parse(info[j].ParameterType, (string)Params[j]));

                    }
                    ParametredAction pa = new ParametredAction(typeof(Access).GetMethod(MethodName), ReadyParams.ToArray(), typeof(Access));
                    pa.Name = AccessName;
                    card.accesses.Add(pa);
                }
                Cards.Add(card);
            }
        }
        public Guid AddNewCardToBase(Card card,Image cardView)
        {
            card.uid = Guid.NewGuid();
            ImageItem item = ImageBase.AddImage(cardView, card.Header, card.Description);
            card.ImageRef = item.uid;
            Cards.Add(card);
            return card.uid;
        }
        public Guid AddNewCardToBase(Card card)
        {
            card.uid = Guid.NewGuid();
            Cards.Add(card);
            return card.uid;
        }
        public Dictionary<Guid,String> GetCardsList()
        {
            Dictionary<Guid, string> OUT = new Dictionary<Guid, string>();
            Cards.ForEach(x => OUT.Add(x.uid, x.Header));
            return OUT;
        }
        public Card GetCard(Guid guid)
        {
            int index = Cards.FindIndex(x => x.uid == guid);
            if(index != -1)
                    return Cards[index];
            return null;
        }
        public ImageItem AddImageToBase(Image im,string name,string description)
        {
           return ImageBase.AddImage(im, name, description);
        }
        public Image GetImage(Guid uid)
        {
           return ImageBase.GetImage(uid);
        }
        public void SaveLibrary()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");
 
            foreach (Card card in Cards)
            {
                var CardRoot = doc.CreateElement("Card");
                var Header = doc.CreateElement("Header"); Header.InnerText = card.Header;
                var uid = doc.CreateElement("uid"); uid.InnerText = card.uid.ToString();
                var Description = doc.CreateElement("Description"); Description.InnerText = card.Description;
                var Image = doc.CreateElement("Image"); Image.InnerText = card.ImageRef.ToString();

                var EffectBlock = doc.CreateElement("Effects");
                foreach (ParametredAction effect in card.effects)
                {
                    var currentEffect = doc.CreateElement("Effect");
                    var EffectName = doc.CreateElement("Name"); EffectName.InnerText = effect.Name;
                    var MethodName = doc.CreateElement("MethodName"); MethodName.InnerText = effect.link.Name;
                    var Parameters = doc.CreateElement("Parameters");
                    EffectBlock.AppendChild(currentEffect);
                    currentEffect.AppendChild(EffectName);
                    currentEffect.AppendChild(MethodName);
                    currentEffect.AppendChild(Parameters);

                    for (int i = 0; i < effect.Params.Count; i++)
                    {
                        var param = doc.CreateElement("Param"); param.InnerText = (String)Convert.ChangeType(effect.Params[i],typeof(string));
                        Parameters.AppendChild(param);
                    }

                }

                var AccessBlock = doc.CreateElement("Accesses");
                foreach (ParametredAction access in card.accesses)
                {
                    var currentAccess = doc.CreateElement("Access");
                    var AccessName = doc.CreateElement("Name"); AccessName.InnerText = access.Name;
                    var MethodName = doc.CreateElement("MethodName"); MethodName.InnerText = access.link.Name;
                    var Parameters = doc.CreateElement("Parameters");
                    AccessBlock.AppendChild(currentAccess);
                    currentAccess.AppendChild(AccessName);
                    currentAccess.AppendChild(MethodName);
                    currentAccess.AppendChild(Parameters);

                    for (int i = 0; i < access.Params.Count; i++)
                    {
                        var param = doc.CreateElement("Param"); param.InnerText = (String)Convert.ChangeType(access.Params[i], typeof(string));
                        Parameters.AppendChild(param);
                    }

                }

                CardRoot.AppendChild(uid);
                CardRoot.AppendChild(Header);
                CardRoot.AppendChild(Description);
                CardRoot.AppendChild(Image);
                CardRoot.AppendChild(EffectBlock);
                CardRoot.AppendChild(AccessBlock);

                root.AppendChild(CardRoot);
            }
            doc.AppendChild(root);
            doc.Save(ConfigurationManager.AppSettings["XMLCardBasePath"]);
            ImageBase.ReBuild();
        }
    }
    public class ImageFile
    {
        private string pathImageBase = ConfigurationManager.AppSettings["pathImageBase"];
        private string pathImageBaseDescription = ConfigurationManager.AppSettings["pathImageBaseDescription"];
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
        public void ReBuild()
        {
            List<Guid> LifedItems = Images.Select(x => x.uid)
                                         .Intersect(CardBase.Instance.Cards.Select(x => x.ImageRef)).ToList();
            Dictionary<Guid, Image> dic = new Dictionary<Guid, Image>();
            Images.Where(x => LifedItems.Contains(x.uid)).ToList().ForEach(x => dic.Add(x.uid, GetImage(x.uid)));

            File.Delete(pathImageBase);
            File.Delete(pathImageBaseDescription);
            List<ImageItem> toDel = Images.Where(x => !LifedItems.Contains(x.uid)).ToList();
            foreach (var del in toDel) Images.Remove(del);

            FileStream fs = new FileStream(pathImageBase, FileMode.Append);
            foreach (ImageItem im in Images)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    dic[im.uid].Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] arrayImage = ms.ToArray();
                    im.FilePosition = fs.Length;
                    im.LengthFile = ms.Length;
                    fs.Write(arrayImage, 0, arrayImage.Length);

                }
            }
           fs.Close();
            SaveLibrary();
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
