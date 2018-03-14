using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX19StreamReader
{
    class Box
    {
        //Opgave 17.1
        public int Height;
        public int Length;
        public int Width;

        //Opgave 19.2
        public Box(int height, int length, int width)
        {
            Height = height;
            Length = length;
            Width = width;
        }

        //Opgave 17.2
        public void PrintInfo()
        {
            Console.WriteLine($"Kassen har følgende mål:\nHøjde: {Height} cm\nLængde: {Length} cm\nBredde: {Width} cm\nRumfang: {Volume} cm3\nOverflade: {Surface} cm2");
        }

        //Opgave 17.3
        public int Volume { get; private set; }

        public void CalculateVolume()
        {
            Volume = Height * Length * Width;
        }

        //Opgave 17.4
        public int Surface { get; private set; }

        public void CalculateSurface()
        {
            Surface = (2 * (Height * Length)) + (2 * (Height * Width)) + (2 * (Width * Length));
        }
    }
}
