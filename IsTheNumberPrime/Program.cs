//Is the number prime

//ALGORITHM

//1.1 Start.
//1.2 The user is prompted to enter a number.
//1.3 Counter = 2.
//1.4 If the number is 2 the number is prime, go to step 1.7.
//1.5 If number % counter = 0 then the number is not prime to the screen, go to step 1.6.
//1.6 Counter = counter + 1 if counter < number go to step 1.5.
//1.7 Finish it.
//1.8 Start.
//1.9 The user is prompted to enter a number.
//2   counter value is incremented up to number starting from 2
//2.1 If the remainder of the number divided by the counter is 0, the number is not prime.
//2.3 number is prime if the remainder is not 0 after dividing the number by any value of the counter.
//2.4 The prime state of the number is printed on the screen.


//Sayı asal mı

//ALGORİTMA

//1.1 Başla.
//1.2 Kullanıcıdan bir sayı girmesi istenir.
//1.3 Sayaç = 2.
//1.4 Eğer sayı 2 ise sayı asaldır, adım 1.7'ye git.
//1.5 Sayı % sayaç = 0 ise ekrana sayı asal değil, adım 1.6'ya gidin.
//1.6 Sayaç = sayaç + 1 eğer sayaç < sayi ise adım 1.5'e git.
//1.7 Bitir.
//1.8 Basla .
//1.9 Kullanıcıdan bir sayı istenir ve kullanıcı sayıyı girer .
//2   sayaç değeri 2 den başlayarak sayıya kadar arttırılır.
//2.1 eğer sayının sayaca bölümünden kalan 0 ise sayı asal değildir.
//2.3 eğer sayının sayacın hiç bir değerine bölümünden kalan 0 değisle sayı asaldır.
//2.4 sayının asallık durumu ekrana yazdırılır.



Console.Write("Enter a positive number (0 for output): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number != 0) //Another Method => if (number == 0)
{
    do
    {
        if (number == 1)
            Console.WriteLine("The number entered is not prime.");
        else
        {
            bool prime = true; // flag 
            for (int counter = 2; counter < number; counter++)
            {
                if (number % counter == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Number entered is prime.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The number entered is not prime.");
                Console.ResetColor();
            }
        }
        Console.Write("\nEnter a positive number (0 for output): ");
        number = Convert.ToInt32(Console.ReadLine());
    } while (number != 0);
}