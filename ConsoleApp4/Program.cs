using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Vehiculo
    {
        private string color;
        private double motor;

        public double color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }


        public string Motor
        {
            get
            {
                return Motor;
            }
            set
            {
                Vehiculo = value;
            }
        }
        public Vehiculo()
        {
            color = "rojo";
            Motor = 2.3;
        }
        public Vehiculo(string color, double motor)
        {
            this.color = color;
            this.Motor = Motor;
        }

        public override string ToString()
        {
            return base.ToString() + "--> color:" + "motor" + motor;
        }





