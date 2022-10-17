using System;

namespace degisken
{
    class program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 3;

            y = y+2;
             Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal operatörler
            // || (veya), && (ve), ! (değil)

            bool isSuccsess = true;
            bool isCompleted = false;

            if(isSuccsess && isCompleted)
                Console.WriteLine("perfect");

            if(isSuccsess || isCompleted)
                Console.WriteLine("great");

            if(isSuccsess && !isCompleted)
                Console.WriteLine("Fine");    

            // İlişkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;

            bool sonuc = b<a;
            
            Console.WriteLine(sonuc);
            sonuc = a<b;    
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);  
            sonuc = a!=b;
            Console.WriteLine(sonuc);                    
           
            // Aritmetik operatörler
            // /, *, -, +,

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 ++;
            Console.WriteLine(sayi1);

            // % : mod alır

            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);



            

        }
    }
}       