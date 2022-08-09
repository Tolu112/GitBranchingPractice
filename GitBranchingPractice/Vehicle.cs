﻿using System;
namespace GitBranchingPractice
{
    public class Vehicle
    {
        //public Vehicle()
        //{
        //}
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public int Year { get; set; }

        //Method - virtual gives the inheriters an option to override the method
        public virtual void Go()
        {
            Console.WriteLine($"{Name} is going");
        }
    }
}

