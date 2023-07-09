using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pemrogramanweek12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrNim = {
                1234,
                1235,
                1235
            };

            string[] arrName = {
                "erick",
                "wely",
                "sony",
            };

            int[] arrNilai = {
                75,
                80,
                95
            };

            Console.WriteLine("No\t\t NIM\t\t NAMA\t\t NILAI");

            for (int i = 0; i < arrNim.Length; i++)
            {
                Console.WriteLine($"{i + 1}.\t\t {arrNim[i]}\t\t {arrName[i]}\t\t {arrNilai[i]}");
            }
            Console.ReadLine();
        }
    }
}