using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle carl = new vehicle (); // this is not possible as parent class is abstract: to increase security
            Corsa cars2 = new Corsa();

            Console.ReadLine();

        } 
    }
    abstract class Vehicle
    {
        public int wheels = 4;
    }

    class Corsa : Vehicle 
    {
        public int sparewheels = 1;
    }
        }
   