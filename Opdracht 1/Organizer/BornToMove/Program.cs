﻿

using System;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace BornToMove
{
    public class Program
    {
        public static void Main()
        {
            string connectionString = "Server=localhost;Database=born2move;Uid=root;Pwd=Edu-Com17;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            Console.WriteLine("Tijd om te bewegen!");
            string answer;
            Console.WriteLine("Wil je een bewegingssuggestie of zelf een oefening kiezen? (suggestie/kiezen/nee)");
            do
            {
                answer = Console.ReadLine().Trim().ToLower();
                if (answer == "suggestie")
                {
                    suggestie suggestie = new suggestie(connection);
                    feedback feedback = new feedback();
                }
                else if (answer == "kiezen")
                {
                    chooseExercise chooseExercise = new chooseExercise(connection);
                    feedback feedback = new feedback();
                }
                else if (answer != "nee" && answer != "no")
                {
                    Console.WriteLine("Sorry, dat antwoord begrijp ik niet. Antwoord a.u.b. met suggestie, kiezen, of nee.");
                }
                else if (answer == "nee" || answer == "no")
                {
                    Console.WriteLine("Oke, tot de volgende keer en niet vergeten te bewegen!");
                }
            } while (answer != "nee" && answer != "no" && answer != "suggestie" && answer != "kiezen");
        }
    }
}