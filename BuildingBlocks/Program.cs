using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks.Unit_Testing_Classes;
using Pieces.Unit_Testing_Classes;
using Pieces;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Point pointZero = new Point(new List<float> { 10.0f, 20.0f, 30.5f },false);
            Point pointOne = new Point(new List<float> { 10.0f,20.0f,30.0f,40.0f,50.0f},true);
            Point pointTwo = new Point(new List<float> { 20.0f, 40.0f, 60.0f, 80.0f, 100.0f,120.0f,140.0f,160.0f }, true);
            Point pointThree = new Point(new List<float> { 100.0f, 200.0f, 300.0f, 400.0f, 500.0f, 600.0f, 700.0f, 800.0f }, true);
            Point pointFour = new Point(new List<float> { 3.0f, 6.0f, 9.0f}, true);

            //PointTester pointTester1 = new PointTester();
            PointTester pointTester2 = new PointTester(pointZero, pointOne, pointTwo, pointThree, pointFour);

            pointTester2.testUpdate();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            //pointTester2.testUpdate();

            Console.WriteLine("Building Blocks Main" );
            Console.ReadLine();
        }


        

        
    }

    
}
