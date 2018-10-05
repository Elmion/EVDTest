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
        List<KnowledgeSource> Source;
    }
    internal class KnowledgeSource
    {

    }
    class Evelopment
    {
        TypeEvelopment type;
        int Temprature;
        float Lightness = 1.0f; //ярко
        List<EvelopmentItem> Items; //Предметы находящиеся в данной локации
    }
    internal class TypeEvelopment //типо окружения, Улица дом пещера лес и т п
    {

    }
    internal class EvelopmentItem // Предметы на сцене 
    {
        string Name;
        Dictionary<KnowledgeItem, float> RequestForAccess; //нормальный допуск по знаниям
        public bool CanTryAvoidKnowledge = false; //Можно ли попытаться без знаний.
        List<EvelopmentItem> InnerItems; //Предметы внути предмета
        CardScript script;

        Player Owner = null; //принадлежность предмета окружения, например станок может быть занят или тарелка пренадлежать каком уто игроку

        bool canUsed() { throw new NotImplementedException(); } //Можт ли предмет быть использован
        void Use() { throw new NotImplementedException(); } //нормальное использование
        void UseAvoidAccess() { throw new NotImplementedException(); } //использоване без доступа
        void AddItem(EvelopmentItem item) { throw new NotImplementedException(); }
    }
    class Inventory
    {
        Dictionary<KnowledgeItem, float> RequestForAccess;
        List<InventoryItem> Items;
        public InventoryItem GetItem(string Name, int count = 1) { throw new NotImplementedException(); }
    }
    internal class InventoryItem
    {
        string Name;
        int Amount;
        CardScript script;
        void Use() { }
    }

    internal class CardScript
    {
    }

    class Resources
    {
        int Amount;
    }
    class Social
    {
        Dictionary<Player, Relation> Relations;
    }
    internal class Relation
    {

    }
    class Player : ISaveLoad
    {
        public TimeLine time = new TimeLine();
        Social social = new Social();
        Evelopment currentLocation;
        public List<Resurce> Resurces = new List<Resurce>();
        public Inventory inventory = new Inventory();
        public Knowledge кnowledge = new Knowledge();

        public List<Card> CurrentCards = new List<Card>();

        public T CreateItem<T>(string Name, T type, int count = 1) { throw new NotImplementedException(); } //крафт
        public void UseInventoryItem() { throw new NotImplementedException(); } //используем предмет инвертаря
        public void UseEvelopmentItem() { throw new NotImplementedException(); } //Используем предмет окружения
        public void UseCard() { throw new NotImplementedException(); } //Используем какую то карту

        public void RequestCard() { throw new NotImplementedException(); } //просим новый набор карт
        public void SyncPlayer() { throw new NotImplementedException(); } // синхранизируем игрока

        bool ISaveLoad.Save()
        {
            throw new NotImplementedException();
        }

        bool ISaveLoad.Load()
        {
            throw new NotImplementedException();
        }
    }
    class Story
    {
        List<Card> StoryLine;
    }
    class Map
    {
        //на основе Вороного для более реалистичного подсчёта растояний .. визуального представления не предпологается.
    }
}
