using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace travelAgency
{
    public class Tourist
    {
        public readonly string TourCode;
        public string Name;
        public string Surname;
        public string StartTime;
        public string TourDuration;
        public readonly string FinishTime;
        public string TourPrise;
        public PaymentType Payment;

        public Tourist(string code, string name, string surname, string start, string duration, string finish, string prise, PaymentType payment)
        {
            TourCode = code;
            Name = name;
            Surname = surname;
            Payment = payment;
            
        }
        public override string ToString()
        {
            return $"{Name} {Surname} {TourCode}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var payment = "";
            switch (Payment)
            {
                case PaymentType.BankCard:
                    payment = "Оплата по карте";
                    break;
                case PaymentType.Cash:
                    payment = "Оплата наличными";
                    break;
                case PaymentType.CardDetails:
                    payment = "Перевод по cчету";
                    break;
            }
            Console.WriteLine($"Имя: {Name}. Фамилия: {Surname}. Код тура:{TourCode}");
        }

    }
}
