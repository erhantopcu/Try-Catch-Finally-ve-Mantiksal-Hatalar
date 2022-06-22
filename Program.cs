using System;

namespace Try_Catch_Finally_ve_Mantiksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
        //    try
        //    {
        //        Console.WriteLine("Bir sayı giriniz: ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
       // //    Console.WriteLine("Girmiş oldugunuz sayi:" + sayi);
        //    }
        //   
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Hata:" + ex.Message.ToString() );
        //         
        //    }
        //    finally
        //    {
        //        Console.Write("İşlem tamamlandı.");
        // //       
        // //   }

            try
            {
               // int a = int.Parse(null);
               // int a= int.Parse("test");
                int a=int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)

            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
                
            }
            catch(FormatException ex)
              {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
            
              }
              catch(OverflowException ex)
              {
                Console.WriteLine("Cok buyuk veya cok kücük deger girdiniz");
                Console.WriteLine(ex);
              }
              finally
              {
                Console.WriteLine("İşlem başarıyla tamamlandı");
              }
        }
    }
}
