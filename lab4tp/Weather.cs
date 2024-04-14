using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab4tp
{ 
    public class Weather
    {
        public static Random rnd = new Random();
        public double temperature = 0;//температура
        public virtual string GetInfo()
        {
            return String.Format("\nТемпература: {0:0.00}", this.temperature); ;
        }
    }
    //солнечная погода
    public class Sun : Weather
    {
        public double heightAboveHorizont = 0;//высота солнца над горизонтом
        public bool breeze = false;//наличие ветера
        public override String GetInfo()
        {
            var infoStr = "Погода солнечная";
            infoStr += base.GetInfo();
            infoStr += String.Format("\nВысота солнца над горизонтом: {0:0.00}", this.heightAboveHorizont);
            infoStr += String.Format("\nНадичие ветера: {0}", breeze?"есть ветер": "нет ветра");
            return infoStr;
        }
        public static Sun Generate()
        {
            return new Sun {
                temperature = rnd.NextDouble() * 80-40, // температура от -40 до 40
                heightAboveHorizont = rnd.NextDouble() + rnd.Next() % 179, // высота солнца над горизонтом от 0 до 180
                breeze = rnd.Next() % 2 == 0 // наличие листика true или false
            };
        }
    }
    //дождливая погода

    public class Rain : Weather
    {
        public int precipitation = 0;
        public bool rainbow = false;
        public bool thunderstorm = false;
        public override string GetInfo()
        {
            var infoStr = "Дождливая погода";
            infoStr += base.GetInfo();
            infoStr += String.Format("\nВеличина осадков: {0}",this.precipitation);
            infoStr += String.Format("\nНаличие радуги: {0}",this.rainbow ? "есть радуга" : "нет радуги");
            infoStr += String.Format("\nНаличие грозы: {0}", this.thunderstorm ? "есть гроза" : "нет грозы");
            return infoStr;
        }
        public static Rain Generate()
        {
            return new Rain
            {
                temperature = 1+rnd.NextDouble() * 39, // температура от 1 до 40
                precipitation = rnd.Next() % 100, // количество ягод от 0 до 100
                rainbow = rnd.Next() % 2 == 0, // нвличие радуги true или false
                thunderstorm = rnd.Next() % 2 == 0 // нвличие грозы true или false

            };
        }
    }
    //снег
    public enum typesSnow {fine, coarse, flakes };
    public class Snow : Weather
    {
        public typesSnow type = typesSnow.fine;//тип снега
        public int heightSnowdrifts = 0;//высота сугроба
        public override string GetInfo()
        {
            var infoStr = "Снежная погода";
            infoStr += base.GetInfo();
            String ansType = (this.type == typesSnow.fine) ? "мелкий" : (this.type == typesSnow.coarse) ? "крупный" : "хлопьями";
            infoStr += String.Format("\nТип снега: {0}",ansType);
            infoStr += String.Format("\nВысота сугробов: {0}",this.heightSnowdrifts);
            return infoStr;
        }

        public static Snow Generate()
        {
            return new Snow
            {
                temperature = rnd.NextDouble() * (-40), // температура от -40 до 0
                type = (typesSnow)rnd.Next(3), //тип снега
                heightSnowdrifts = rnd.Next(2)% 200 //высота сугроба от 0 до 200
            };
        }
    }


}