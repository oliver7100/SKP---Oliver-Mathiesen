
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

// Interface 1 
interface GFG1
{
    void languages();
}






abstract class Ordernum
{

    public static int ID { get; set; }

}
class Vare : Ordernum
{
    private static int m_Counter = 0;

    public string Navn { get; set; }
    public int Pris { get; set; }

    public Vare()
    {
        ID = System.Threading.Interlocked.Increment(ref m_Counter);

    }

}

public class kunde
{

    public string Navn { get; set; }
    public string Adresse { get; set; }


}

// Parent class 1 
class Geeks1 : GFG1
{


    public void languages()
    {
        List<kunde> parts = new List<kunde>();

        parts.Add(new kunde() { Adresse = "DWAD", Navn = "WDWD" });


        Console.WriteLine("Kunde:");
        foreach (var elements in parts)
        {
            Console.WriteLine("Navn:" + elements.Navn + "    " + "Adresse:" + elements.Adresse);
        }

    }

    // Interface 2 
    interface GFG2
    {
        void courses();
    }

    // Parent class 2 
    class Geeks2 : GFG2
    {
        public void courses()
        {
            List<Vare> parts = new List<Vare>();
            parts.Add(new Vare() { Navn = "hey", Pris = 300 });

            Console.WriteLine("Vare:");
            foreach (var elements in parts)
            {
                Console.WriteLine("ID:" + elements.ID + "    " + "Navn:" + elements.Navn + "    " + "Pris:" + elements.Pris);
            }
        }
        interface GFG3
        {
            void create();
        }

        class Geeks3 : GFG3
        {
            public void create()
            {
                List<kunde> parts = new List<kunde>();
                parts.Add(new kunde() { Navn = Console.ReadLine(), Adresse = Console.ReadLine() });

            }
        }

        // Child class 
        class GeeksforGeeks : GFG1, GFG2, GFG3
        {

            // Creating objects of Geeks1 and Geeks2 class 
            Geeks1 obj1 = new Geeks1();
            Geeks2 obj2 = new Geeks2();
            Geeks3 obj3 = new Geeks3();
            public void languages()
            {
                obj1.languages();
            }

            public void courses()
            {
                obj2.courses();
            }

            public void create()
            {
                obj3.create();
            }
        }

        // Driver Class 
        public class GFG
        {

            // Main method 
            static public void Main()
            {

                bool Menu = true;

                List<Vare> vare = new List<Vare>();
                List<kunde> kunde = new List<kunde>();


                while (Menu)
                {
                    Console.WriteLine("==================================================");
                    Console.WriteLine("|                                                |");
                    Console.WriteLine("|             1. Registrering af Kunder          |");
                    Console.WriteLine("|             2. Registrering af Vare            |");
                    Console.WriteLine("|             3. Display Vare og Pris            |");
                    Console.WriteLine("|             3.   Sum af priserne               |");
                    Console.WriteLine("|                                                |");
                    Console.WriteLine("==================================================");



                    //list1.Add(new kunde(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine()));





                    string menu = Console.ReadLine();
                    GeeksforGeeks obj = new GeeksforGeeks();


                    switch (menu)
                    {


                        case "1":

                            obj.create();

                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case "2":


                            break;
                        case "3":
                            // Creating object of GeeksforGeeks class 
                            obj.languages();
                            obj.courses();

                            Console.ReadLine();
                            Console.Clear();


                            break;
                        case "4":

                            int sum = 0;
                            foreach (var Pris in vare)
                            {
                                sum += (vare.Select(i => i.Pris).Sum());

                            }
                            Console.WriteLine(sum);
                            Console.ReadLine();
                            Console.Clear();
                            break;

                    }
                }


            }
        }
    }
}