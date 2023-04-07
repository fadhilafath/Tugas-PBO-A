using System;

namespace LaptopApp{
    class Program{
        static void Main(string[] args){
            Vga vga1 = new Nvidia();
            Processor proc1 = new Corei5();
            Laptop laptop1 = new Vivobook(vga1, proc1);

            Vga vga2 = new AMDvga();
            Processor proc2 = new Ryzen();
            Laptop laptop2 = new IdeaPad(vga2, proc2);

            Vga vga3 = new AMDvga();
            Processor proc3 = new Corei7();
            Predator predator = new Predator(vga3, proc3);

            laptop1.LaptopDinyalakan();
            laptop1.LaptopDimatikan();
            // laptop1.Ngoding();

            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            laptop2.PrintSpek();

            predator.LaptopDinyalakan();
            predator.BermainGame();
            predator.LaptopDimatikan();

            ACER acer = new Predator(vga3, proc3);
            // acer.BermainGame();
        }
    }
}

class Vga{
    public string merk;

    public Vga(string merk){
        this.merk = merk;
    }
}

class Nvidia : Vga{
    public Nvidia() : base("Nvidia"){
    }
}

class AMDvga : Vga{
    public AMDvga() : base("AMD"){
    }
}

class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
    }
}

class Corei3 : Intel
{
    public Corei3() : base("Core i3")
    {
    }
}

class Corei5 : Intel
{
    public Corei5() : base("Core i5")
    {
    }
}

class Corei7 : Intel
{
    public Corei7() : base("Core i7")
    {
    }
}

class AMDpcc : Processor
{
    public AMDpcc(string tipe) : base("AMD", tipe)
    {
    }
}

class Ryzen : AMDpcc
{
    public Ryzen() : base("RAYZEN")
    {
    }
}

class Athlon : AMDpcc
{
    public Athlon() : base("ATHLON")
    {
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop {0} {1} menyala", merk, tipe);
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop {0} {1} mati", merk, tipe);
    }

    public void PrintSpek()
    {
        Console.WriteLine("Spesifikasi {0} {1}:", merk, tipe);
        Console.WriteLine($"VGA -> {vga.merk}");
        Console.WriteLine($"Processor -> {processor.merk}, tipe {processor.tipe}");
    }
}

class ASUS : Laptop{
    public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor){
    }
}

class ROG : ASUS{
    public ROG(Vga vga, Processor processor) : base("ROG", vga, processor){
    }
}

class Vivobook : ASUS{
    public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor){
    }

    public void Ngoding(){
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor){
    }
}

class Swift : ACER
{
    public Swift(Vga vga, Processor processor) : base("Swift", vga, processor){
    }
}

class Predator : ACER
{
    public Predator(Vga vga, Processor processor) : base("Predator", vga, processor){
    }

    public void BermainGame()
    {
        Console.WriteLine("Laptop {0} {1} sedang memainkan game", merk, tipe);
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor){
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor){
    }
}

class Legion : Lenovo
{
    public Legion(Vga vga, Processor processor) : base("Legion", vga, processor){
    }
}