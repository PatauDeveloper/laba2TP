using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace laba2NAME
{
    public class Harvester
    {
        private readonly string brand;
        private readonly string model;
        private mode mode;
        private bool state = false;
        private static int serialNumber = -1;

        private mode menuItem = mode.blender;

        public Harvester()
        {
            this.brand = "Noname";
            this.model = "Unknown";
            serialNumber++;
        }

        public Harvester(string brand)
        {
            this.brand = brand;
            serialNumber++;
        }

        public Harvester(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            serialNumber++;
        }


        public Harvester(string brand, string model, int menuItem)
        {
            this.brand = brand;
            this.model = model;
            switch(menuItem)
            {
                case 0: this.menuItem = mode.slicing; break;
                case 1: this.menuItem = mode.blender; break;
                case 2: this.menuItem = mode.crushing; break;
                case 3: this.menuItem = mode.grind; break;
            }
            serialNumber++;
        }

        public string Print()
        {
            return "Current item of menu: " + this.menuItem + "\nBrand: " +this.brand + "\nModel: " + this.model + "\nState(ON or OFF): " + this.state.ToString() + "\nSerial number: " + serialNumber + "\n";

        }
        public void SetState(bool state)
        {
            this.state = state;
        }





        public void status()
        {
            throw new System.NotImplementedException();
        }

        public void SwitchModeNext()
        {
            mode +=1;
        }

        public void SwitchModPrev()
        {
            mode -= 1;
        }
    }
}
