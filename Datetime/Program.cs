using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            // DateTime: Data fixa
            // TimeSpan: Intervalo de tempo 
            // ISO 8601 => ("2000-08015T13:05:58Z")

            DateTime datetime = new DateTime (2025, 01, 10, 17, 23, 40); // Monta uma data e horário (Ano, Mês, Dia, Hora, Min, Seg)
            DateTime now = DateTime.Now; // Data e horário da máquina local (01/01/2025 12:00:00)
            DateTime today = DateTime.Today; // Data da máquina local (01/01/2025)
            DateTime utc = DateTime.UtcNow; // Data e horário em Greenwich 
            DateTime parse = DateTime.Parse("10/01/2000 13:05:58"); // Formata para datetime 
            DateTime parse_exact = DateTime.ParseExact("20-10-2000", "dd-MM-yyyy",CultureInfo.InvariantCulture); // Formata uma string em formato escrito
            DayOfWeek day_of_week = datetime.DayOfWeek; // Dia da semana;

            string longDateString = datetime.ToLongDateString(); // Mostra a data de forma formatada
            string longTimeString = datetime.ToLongTimeString();// Mostra o horário de forma formatada
            string shortDateString = datetime.ToShortDateString(); //Mostra data de forma simples 
            string tostring = datetime.ToString("dd-MM-dd HH:mm:ss"); // Formata uma string do datetime 

            string datetime_h = datetime.AddHours(2).ToLongTimeString(); // Add uma hora
            string datetime_m = datetime.AddMinutes(2).ToLongTimeString(); // Add uma min
            string datetime_s = datetime.AddSeconds(2).ToLongTimeString(); // Add uma seg

            TimeSpan dias = TimeSpan.FromDays(2.7); // Transforma em Dias 
            TimeSpan horas = TimeSpan.FromHours(32.7); // Transforma em Horas
            TimeSpan min = TimeSpan.FromMinutes(65.7); // Transforma em Minutos 
            TimeSpan seg  = TimeSpan.FromSeconds(3600.0); // Transforma em Segundos 
            
            DateTime h1 = new DateTime(2000,10,10); // Horário 1 
            DateTime h2 = new DateTime(2000,10,15); // Horário 2
            TimeSpan ts = h2.Subtract(h1); // Diferença entre dois horários 

            System.Console.WriteLine(parse);

            Console.WriteLine(new string('-',40));
        } 
    }
}