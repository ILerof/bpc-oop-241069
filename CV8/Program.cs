namespace CV08
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathWrite = @"D:\241069\BPC-OOP\bpc-oop-241069\CV8\writerTeploty.txt";
            string pathRead = @"D:\241069\BPC-OOP\bpc-oop-241069\CV8\readerTeploty.txt";

            ArchivTeplot teploty = new ArchivTeplot();

            teploty.Load(pathRead);
            teploty.TiskTeplot();
            teploty.TiskPrumernychTeplot();
            teploty.TiskPrumernychMesicnichTeplot();

            teploty.Kalibrace(-0.1);
            teploty.Vyhledej(2020);

            teploty.Save(pathWrite);
        }
    }
}