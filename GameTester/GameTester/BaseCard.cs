﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Configuration;

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

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(new StreamReader(ConfigurationManager.AppSettings["XMLCardBasePath"]).ReadToEnd());
            foreach (XmlNode XMLCardDescription in doc.GetElementsByTagName("Card"))
            {
                Card card = new Card();

                card.Header = XMLCardDescription.SelectSingleNode("Header").InnerText;
                card.Description = XMLCardDescription.SelectSingleNode("Description").InnerText;

                card.ImageRef = Guid.Parse(XMLCardDescription.SelectSingleNode("Image").InnerText);

                //Заполняем эффекты
                card.effects = new List<Effect>();
                foreach (XmlNode EffectXML in XMLCardDescription.SelectSingleNode("Effects").ChildNodes)
                {
                    XmlNode EffectParamsNode = EffectXML.SelectSingleNode("Parameters");
                    List<object> Params = new List<object>();
                    for (int i = 0; i < EffectParamsNode.ChildNodes.Count; i++)
                    {
                        Params.Add(EffectParamsNode.ChildNodes[i].InnerText);
                    }
                    string MethodName = EffectXML.SelectSingleNode("Name").InnerText;
                    card.effects.Add(new Effect(MethodName, Params));
                }
                Cards.Add(card);
            }
        }
        public Guid AddNewCardToBase(Card card,Image cardView)
        {
            card.uid = Guid.NewGuid();
            ImageItem item = ImageBase.AddImage(cardView, card.Header, card.Description);
            card.ImageRef = item.uid;
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
        public ImageItem AddCardsToBase(Image im,string name,string description)
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


            doc.LoadXml(new StreamReader(ConfigurationManager.AppSettings["XMLCardBasePath"]).ReadToEnd());
            foreach (Card card in Cards)
            {
                var Header = doc.CreateElement("Header"); Header.InnerText = card.Header;
                var Description = doc.CreateElement("Description"); Description.InnerText = card.Description;
                var Image = doc.CreateElement("Image"); Image.InnerText = card.ImageRef.ToString();


                var EffectBlock = doc.CreateElement("Effects");

                foreach (Effect effect in card.effects)
                {
                    var currentEffect = doc.CreateElement("Effect");
                    var EffectName = doc.CreateElement("Name"); EffectName.InnerText = effect.effectMethod.Method.Name;
                    var Parameters = doc.CreateElement("Parameters");
                    EffectBlock.AppendChild(currentEffect);
                    currentEffect.AppendChild(EffectName);
                    currentEffect.AppendChild(Parameters);

                    IncomingTypesAttribute attr = (IncomingTypesAttribute)typeof(Effect).GetMethod(effect.effectMethod.Method.Name).GetCustomAttributes(typeof(IncomingTypesAttribute), false)[0];
                    for (int i = 0; i < effect.Params.Count; i++)
                    {
                        MethodInfo castMethod = this.GetType().GetMethod("Cast").MakeGenericMethod(t);
                        object castedObject = castMethod.Invoke(null, new object[] { obj });

                        var param = doc.CreateElement("Param"); param.InnerText =((attr.types[i]) effect.Params[i]);
                        

                        EffectBlock.
                    }
                    for(Type item in attr.types)
                    {

                    }
                }
                //Заполняем эффекты
                card.effects = new List<Effect>();
                foreach (XmlNode EffectXML in XMLCardDescription.SelectSingleNode("Effects").ChildNodes)
                {
                    XmlNode EffectParamsNode = EffectXML.SelectSingleNode("Parameters");
                    List<object> Params = new List<object>();
                    for (int i = 0; i < EffectParamsNode.ChildNodes.Count; i++)
                    {
                        Params.Add(EffectParamsNode.ChildNodes[i].InnerText);
                    }
                    string MethodName = EffectXML.SelectSingleNode("Name").InnerText;
                    card.effects.Add(new Effect(MethodName, Params));
                }
                Cards.Add(card);
            }
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