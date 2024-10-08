using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        //Свойство для градусов
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value;
            }
        }
        //Свойство для минут
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value >= 0)
                {
                    if (value > 60)
                    {
                        Gradus += value / 60;
                        min = value % 60;
                    }
                    else
                    {
                        min = value;
                    }
                }
                else
                {
                    isCorrect = false;
                }
            }
        }
        //Свойство для секунд
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value >= 0)
                {
                    if (value > 60)
                    {
                        Gradus += value / 60;
                        sec = value % 60;
                    }
                    else
                    {
                        sec = value;
                    }
                }
                else
                {
                    isCorrect = false;
                }
            }
        }
        //конструктор
        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        //метод для перевода угла в радианы
        public double ToRadians()
        {
            return (Math.PI * (gradus + min / 60.0 + sec / 3600.0)) / 180;
        }
    }
}
