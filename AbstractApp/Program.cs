using AbstractApp;

internal class Program
{
    static void Main(string[] args)
    {
        Printer epson = new Epson();
        Printer canon = new Canon();  
        Printer laserJet = new LaserJet();

        epson.JenisPrinter = "Epson";
        epson.thnRilis = 1998;

        canon.JenisPrinter = "Canon";
        canon.thnRilis = 1997;

        laserJet.JenisPrinter = "Laser Jet";
        laserJet.thnRilis = 1996;

        Console.Write("Pilih jenis printer yang akan digunakan [1...3] : ");
        int pilih = Convert.ToInt32(Console.ReadLine());

        //Pengkondisian
        if (pilih == 1)
            epson.printWord();
        else if (pilih == 2) 
            canon.printWord();
        else if(pilih == 3)
            laserJet.printWord();
        else
            Console.WriteLine("Jenis yang mau kamu pilih {0} tidak ada pada jenis printer", pilih);

    }
}