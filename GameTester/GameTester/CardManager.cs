using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Reflection;
using System.Collections;

namespace GameTester
{
    class CardManager
    {
       public static List<Card> Decka = new List<Card>();
       public static Dictionary<Guid, Image> ImagesStorage = new Dictionary<Guid, Image>();

        public static void LoadCards(string XMLEffectPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(new StreamReader(XMLEffectPath).ReadToEnd());
            foreach (XmlNode XMLCardDescription in doc.GetElementsByTagName("Card"))
            {
                Card card = new Card();

                card.Header = XMLCardDescription.SelectSingleNode("Header").InnerText;
                card.Description = XMLCardDescription.SelectSingleNode("Description").InnerText;
                card.ImageRef = GetImage(XMLCardDescription.SelectSingleNode("Image").InnerText);

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
                    string MethodName = EffectXML.SelectSingleNode("Name").InnerText;

                    ParameterInfo[] info = typeof(Effect).GetMethod(MethodName).GetParameters();
                    ArrayList ReadyParams = new ArrayList();
                    for (int j = 0; j < info.Length; j++)
                        ReadyParams.Add(Convert.ChangeType(Params[j], info[j].ParameterType));

                    card.effects.Add(new ParametredAction(typeof(Effect).GetMethod(MethodName), ReadyParams.ToArray(), typeof(Effect)));
                }
                Decka.Add(card);
            }
        }
        public static Card[] CreateNewRandomCards(Random rnd,int numCards)
        {
            Card[] cards = new Card[numCards];

            for (int i = 0; i < numCards; i++)
            {
                cards[i] = (Card)Decka[rnd.Next(Decka.Count)].Clone();
            }
            return cards;
        }
        private static Guid GetImage(string path)
        {
            Image image = null;
            Guid guid = Guid.NewGuid();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    image = Image.FromStream(fs);
                    fs.Close();
                }
            }
            catch
            {
                image = Properties.Resources.NoImage;
            }
            finally
            {
                ImagesStorage.Add(guid, image);
            }
            return guid;
        }
    }
}
