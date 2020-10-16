using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Kunde
{
    class Program
    {
        //Abstract class til at share ID og counter med de andre classs
        abstract class Ordernum
        {
            public static int ID { get; set; }

            public static int m_Counter = 0;


        }

        class Vare : Ordernum
        {

            public string Navn { get; set; }
            public int Pris { get; set; }
            public int Amount { get; set; }

            //Counter til ID
            public Vare()
            {
                ID = System.Threading.Interlocked.Increment(ref m_Counter);

            }

        }

         class kunde : Ordernum
        {
            public string Navn { get; set; }
            public string Adresse { get; set; }


            public kunde(string navn, string adresse)
            {
            Navn = navn;
           Adresse = adresse;

            }


        }



            static void Main(string[] args)
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
                Console.WriteLine("|             4.   Sum af priserne               |");
                Console.WriteLine("|             5.    Fjerne vare                  |");
                Console.WriteLine("|                                                |");
                Console.WriteLine("==================================================");



                //list1.Add(new kunde(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine()));





                string menu = Console.ReadLine();


                switch (menu)
                {


                    case "1":
                        Console.Clear();
                        Console.WriteLine("Kunder(Navn og Adresse)");

                        kunde.Add(new kunde(Console.ReadLine(), Console.ReadLine()));



                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Vare(Vare Navn og pris)");

                        vare.Add(new Vare() { Navn = Console.ReadLine(), Pris = int.Parse(Console.ReadLine()) });


                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "3":



                        foreach (var item in vare)
                        {
                            Console.WriteLine("ID:" + Ordernum.ID + "    " + "Navn:" + item.Navn + "    " + "Pris:" + item.Pris);

                        }

                        foreach (var item in kunde)
                        {
                            Console.WriteLine("ID:" + Ordernum.ID + "    " + "Kunde navn:" + item.Navn + "    " + "Adresse:" + item.Adresse);

                        }

                        Console.ReadLine();
                        Console.Clear();


                        break;
                    case "4":

                        int sum = 0;
                        foreach (var Pris in vare)
                        {  
                        }
                        Console.WriteLine(sum);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Write("Skriv et ID på den item og person du gerne ville fjerne.");

                        var hello = int.Parse(Console.ReadLine());
                        vare.RemoveAll(l => Ordernum.ID == hello);
                        if (hello == int)
                        {

                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;

                }


            }

        }


            static public void OpretKunde()
            {

                List<kunde> list1 = new List<kunde>();

                //list1.Add(new kunde(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine()));
                Console.Clear();


                foreach (var liste in list1)
                {


                    Console.WriteLine(liste.Navn);
                    Console.WriteLine(liste.Adresse);


                }

            }


        }
    }

   
    
            
       
    

