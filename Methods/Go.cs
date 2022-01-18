using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_project.Methods
{
    public class Go
    {
        public void ImtahanBali(decimal bal)
        {
            Console.WriteLine("Giris balinizi daxil edin:");
            string girisBali = Console.ReadLine();

            

            Console.WriteLine("Imtahandan topladiginiz bali daxil edin");

            string imtahanBali = Console.ReadLine();


            decimal umumiBal = Convert.ToInt32(girisBali) + Convert.ToInt32(imtahanBali);


            decimal eksikBal = 51 - Convert.ToInt32(umumiBal);

            if (Convert.ToInt32(umumiBal) < 51 && Convert.ToInt32(girisBali) > 0)
            {
                Console.WriteLine("Siz " + eksikBal + " balla kesildiniz");

            }
            else 
            {
                //Console.WriteLine("Siz kecdiniz");
                if (51 <= Convert.ToInt32(umumiBal) && Convert.ToInt32(umumiBal) <= 61)
                {
                    Console.WriteLine("Siz E aldiniz");
                }
                else if (61 <= Convert.ToInt32(umumiBal) && Convert.ToInt32(umumiBal) <= 71)
                {
                    Console.WriteLine("Siz D aldiniz");
                }
                else if (71 <= Convert.ToInt32(umumiBal) && Convert.ToInt32(umumiBal) <= 81)
                {
                    Console.WriteLine("Siz C aldiniz");
                }
                else if (81 <= Convert.ToInt32(umumiBal) && Convert.ToInt32(umumiBal) <= 91)
                {
                    Console.WriteLine("Siz B aldiniz");
                }
                else
                {
                    Console.WriteLine("Siz A aldiniz");
                }
            }
        }

    }
}
