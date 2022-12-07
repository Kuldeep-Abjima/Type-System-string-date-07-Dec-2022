using System;
namespace dec072022{
    public class DateTimeWithCharDefine
    {
      static void Main(String[] args)
        {
            Console.WriteLine("enter the charcter");
            char c = Convert.ToChar(Console.ReadLine());
            
            bool isWhiteSpace = char.IsWhiteSpace(c);
            bool isDigit = char.IsDigit(c);
            bool isPunctuation = char.IsPunctuation(c);
            bool isNum = char.IsNumber(c);
            bool isLetter = char.IsLetter(c);
            bool issym = char.IsSymbol(c);
            Console.WriteLine($"bool is digit : {isDigit},\n punctuation : {isPunctuation},\n whitespace : {isWhiteSpace},\n num :{isNum},\n letter : {isLetter}, \n Symbol : {issym}");
            DateTime hireDate = new DateTime(2022, 12, 07, 14, 28, 0);
            DateTime joinDate = hireDate.AddDays(16);
            DateTime todayDate = DateTime.Now;
            Console.WriteLine($"Hire Date and Time is : {hireDate} \n joining date: {joinDate} \n todayDate : {todayDate}");
            DateTime startWork = DateTime.Now;
            TimeSpan workTime = new TimeSpan(09, 00, 00);
            DateTime endWork = startWork.Add(workTime);
            Console.WriteLine(startWork.ToLongDateString());
            Console.WriteLine(endWork.ToLongTimeString());


        }
        
    }

    }