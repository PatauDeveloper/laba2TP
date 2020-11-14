/*
* Лабораторная работа № 2
* Абстрактные сущности и связи между ними
* Задание 2
* Выполнил студент гр. 525i Мельник В.О.
*/

namespace laba2NAME
{
    public class Harvester
    {
        /// <summary>
        /// бренд
        /// </summary>
        private readonly string brand;
        /// <summary>
        /// модель
        /// </summary>
        private readonly string model;
        /// <summary>
        /// режим, в котором аботает прибор
        /// </summary>
        private mode mode;
        /// <summary>
        /// состояние комбайна
        /// </summary>
        private bool harvesterSate = false;
        /// <summary>
        /// серийный номер
        /// </summary>
        private static int serialNumber = -1;

        private mode menuItem = mode.blender;

        /// <summary>
        /// конструктор, который вставляет none
        /// </summary>
        public Harvester()
        {
            this.brand = "Noname";
            this.model = "Unknown";
            serialNumber++;
        }

        /// <summary>
        /// конструктор, который вставляет бренд
        /// </summary>
        public Harvester(string brand)
        {
            this.brand = brand;
            serialNumber++;
        }

        /// <summary>
        /// конструктор, который вставляет бренд, модель
        /// </summary>
        public Harvester(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            serialNumber++;
        }


        /// <summary>
        /// конструктор, который вставляет бренд, модель и режим работы
        /// </summary>
        public Harvester(string brand, string model, int menuItem)
        {
            this.brand = brand;
            this.model = model;
            switch (menuItem)
            {
                case 0: this.menuItem = mode.slicing; break;
                case 1: this.menuItem = mode.blender; break;
                case 2: this.menuItem = mode.crushing; break;
                case 3: this.menuItem = mode.grind; break;
            }
            serialNumber++;
        }

        /// <summary>
        /// вывод параметров
        /// </summary>
        public string Print()
        {
            return "Current item of menu: " + this.menuItem + "\nBrand: " + this.brand + "\nModel: " + this.model + "\nState(ON or OFF): " + this.harvesterSate.ToString() + "\nSerial number: " + serialNumber + "\n";

        }
        /// <summary>
        /// установка статуса
        /// </summary>
        public void setState(bool state)
        {
            this.harvesterSate = state;
        }

        /// <summary>
        /// изменение статуса вкл или выкл
        /// </summary>
        public void setHarvesterState(bool harvesterState)
        {
            this.harvesterSate = harvesterState;
        }




        /// <summary>
        /// возврат модели
        /// </summary>
        public string getModel()
        {
            return this.model;
        }

        /// <summary>
        /// возврат бренда
        /// </summary>
        public string getBrand()
        {
            return this.brand;
        }

        /// <summary>
        /// статус(вкл или выкл)
        /// </summary>
        public bool isHarvesterState()
        {
            return this.harvesterSate;
        }

    }
}
