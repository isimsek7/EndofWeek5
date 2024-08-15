using System;
using EndOfWeek5;
try
{
    List<Araba> arabalar = new List<Araba>();
    bool looper = true;
    while(looper)
    {
        Console.Write("Bir araba uretmek istiyor musunuz ? (e/h)= ");
        string uInput = Console.ReadLine();
        if(uInput.ToLower()=="h")
        {
            Console.WriteLine("Program sonlandirildi.");
            foreach(Araba newAraba in arabalar)
            {
                Console.WriteLine("Seri numarasi= {0}, Marka= {1}", newAraba.SeriNumarasi,newAraba.Marka);
            }
            
            looper = false;
        }
        if (uInput.ToLower() == "e")
        {
            {
                Console.WriteLine("Araciniz olusturuluyor, lutfen bilgileri giriniz.");
                Araba newAraba = new Araba();
                Console.Write("Seri no= ");
                newAraba.SeriNumarasi = Console.ReadLine();
                Console.Write("Marka= ");
                newAraba.Marka = Console.ReadLine();
                Console.Write("Renk= ");              
                newAraba.Renk = Console.ReadLine();
            Rewind:
                try
                {
                    Console.Write("Kapi sayisi= ");
                    newAraba.KapiSayisi = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Gecersiz bir kapi sayisi girisi. Lutfen islemi yeniden gerceklestiriniz.");
                    goto Rewind;
                }
                Console.WriteLine(newAraba.UretimTarihi);
                arabalar.Add(newAraba);
                    
            }
        }
    }
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
