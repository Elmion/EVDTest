using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTester.Hero.TestArchecture
{
    class Knowledge
    {
        KnowledgeItem root; 
    }
    class KnowledgeItem
    {
        string Name; //Название знания
        KnowledgeItem parent; //Предок
        List<KnowledgeItem> childs;//Другие науки и навыки происходящие из даного
        List<Charter> charters; //Части знания
        Dictionary<KnowledgeItem, float> RequestForAccess; //Минимальные требования для доступа
        float CalcAmountKnow() //Процент выучиности раздела. Нужен для пропуска в следующий раздел
        {
            throw new NotImplementedException();
        }
        bool AccessGrant()
        {
            throw new NotImplementedException();
        }
    }
    internal class Charter
    {
        string Name;//Название раздела
        bool Theoretical;//Теоретическое знание
        float ProcenteKnow; //Процент выучиности
    }
    class Evelopment
    {
        int Temprature;
        float Lightness = 1.0f; //ярко
        List<EvelopmentItem> Items; //Предметы находящиеся в данной локации
    }
    internal class EvelopmentItem
    {
        List<EvelopmentItem> InnerItems; //Предметы внути предмета
        string Name;
    }
    class Inventory
    {

    }
    class Resources
    {

    }
    class Story
    {
        
    }
}
