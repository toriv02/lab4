using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab4tp
{ 
    public class Fruit
    {
        public static Random rnd = new Random();
        public int Ripeness = 0;//спелость
        public virtual string GetInfo()
        {
            return String.Format("\nСпелость: {0}", this.Ripeness); ;
        }
    }
    public class Mandarin : Fruit
    {
        public int SliceCount = 0;//количество долек
        public bool WithLeaf = false;//наличие листика
        public override String GetInfo()
        {
            var infoStr = "I'm just alone mandarin in this evil world";
            infoStr += base.GetInfo();
            infoStr += String.Format("\nЧисло долек: {0}",this.SliceCount);
            infoStr += String.Format("\nНадичие листика: {0}",this.WithLeaf);
            return infoStr;
        }
        public static Mandarin Generate()
        {
            return new Mandarin {
                Ripeness = rnd.Next() % 100, // спелость от 0 до 100
                SliceCount = 5 + rnd.Next() % 20, // количество долек от 5 до 25
                WithLeaf = rnd.Next() % 2 == 0 // наличие листика true или false
            };
        }
    }
    // виды винограда
    public enum GrapesType { black, green };
    // собственно сам виноград
    public class Grapes : Fruit
    {
        public int BerriesNumber = 0;
        public GrapesType type = GrapesType.black;
        public override string GetInfo()
        {
            var infoStr = "Just grapes";
            infoStr += base.GetInfo();
            infoStr += String.Format("\nЧисло ягод: {0}",this.BerriesNumber);
            infoStr += String.Format("\nТип винограда: {0}",this.type);
            return infoStr;
        }
        public static Grapes Generate()
        {
            return new Grapes
            {
                Ripeness = rnd.Next() % 100, // спелость от 0 до 100
                BerriesNumber = 25 + rnd.Next() % 75, // количество ягод от 25 до 100
                type = (GrapesType)rnd.Next(2) // тип винограда
            };
        }
    }
    //арбуз
    public class Watermelon : Fruit
    {
        public int BonesNumber = 0;//количество косточек
        public bool HasStight = false;//наличие полосок
        public override string GetInfo()
        {
            var infoStr = "Just mellon, joke. It's watermellon";
            infoStr += base.GetInfo();
            infoStr += String.Format("\nКоличество косточек: {0}",this.BonesNumber);
            infoStr += String.Format("\nНаличие полосок: {0}",this.HasStight);
            return infoStr;
        }

        public static Watermelon Generate()
        {
            return new Watermelon
            {
                Ripeness = rnd.Next() % 100, // спелость от 0 до 100
                BonesNumber = 250 + rnd.Next(250), // количество ягод от 250 до 500
                HasStight = rnd.Next(2) == 0 // начличие полосок
            };
        }
    }


}