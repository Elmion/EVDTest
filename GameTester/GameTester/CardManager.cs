using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GameTester
{
    class CardManager
    {
       public  static List<Card> Decka = new List<Card>();

        public static void LoadCards(string XMLEffectPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(new StreamReader(XMLEffectPath).ReadToEnd());
            foreach (XmlNode XMLCardDescription in doc.GetElementsByTagName("Card"))
            {
                Card card = new Card();

                card.Header = XMLCardDescription.SelectSingleNode("Header").InnerText;
                card.Description = XMLCardDescription.SelectSingleNode("Description").InnerText;
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
                Decka.Add(card);
            }
        }
    }
}
