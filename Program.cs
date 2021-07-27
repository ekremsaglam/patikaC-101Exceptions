using System;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Write a number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number that you entered is : " + number);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Error : " + exception.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }


            try
            {
                //int a = int.Parse(null);
                //int b = int.Parse("test");
                int c = int.Parse("-20000000000000000");
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine("You entered empty value.");
                Console.WriteLine(exception);
            }

            catch (FormatException exception)
            {
                
                Console.WriteLine("Value type is not suitable.\n" + exception);
            }
            catch(OverflowException  exception)
            {
                Console.WriteLine("Girdiğiniz değer çok büyük veya çok küçük.");
                Console.WriteLine(exception);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }




            
        }
    }
}
