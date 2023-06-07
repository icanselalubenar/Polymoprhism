using System;
namespace Polymorphism_Tugas
{
    public class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("No Printer Detected.");
        }
        public virtual void Print()
        {
            Console.WriteLine("Please select again.");
        }
    }
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printering...");
        }
    }
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printering...");
        }
    }
    public class LasetJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LasetJet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LasetJet printer printering...");
        }
    }
}

