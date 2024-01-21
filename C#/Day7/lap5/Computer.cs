using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lap5
{
	public class Computer : Product
	{
        public string Ram { get; set; }
        public double Tax { get; } = 0.1;

        public override void Input()
        {
            base.Input();

                while (true)
                {
                    Console.Write("Enter Computer RAM (....GB): ");
                    try
                    {
                        Ram = Console.ReadLine();

                        if (!Regex.IsMatch(Ram, "^[0-9]{1,2}+GB$^"))
                        {
                            throw new Exception("Invalid RAM format. Please use a format like '8GB'.");
                        }

                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

        }


        public float GetPrice()
        {
            return (float)(Price * (1 + Tax));
        }


        public override string ToString()
        {
            return "Name: "+Name+ ", Price: "+GetPrice+", Ram: "+Ram;
        }
    }
}

