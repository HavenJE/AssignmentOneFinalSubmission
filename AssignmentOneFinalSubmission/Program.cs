
// Assignment 1 - Task 3
// Write a program named QueenslandCompetitionApp that performs/allows the following:

// 1. Displays the number of tickets for adults, for children and for seniors and display a statement that shows a statistic of visitors attending.

// 2. If the number of adult tickets is smaller than or equal to the total of children's and senior tickets, the app should display “The
//    competition is becoming a festival for everyone!”.

// 3. If the number of children's tickets is greater than or equal to senior tickets, the app should display “The competition is attracting more
//    and more young people!”.

// 4. In other cases, the app should display “The competition should have more space for kids!”.

using System;
class QueenslandCompetitionApp
{
    static void Main()
    {
        // Assignment 1 - Task 1
        string CompoetitionMotto = "*#*#*#*#*#*# The stars shine in Queensland *#*#*#*#*#*#*";
        string Border = "*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#";
        Console.WriteLine(Border);
        Console.WriteLine(CompoetitionMotto);
        Console.WriteLine(Border);
        Console.WriteLine("\n");

        // Assignment 2 Task2
        const double AdultTicket = 20.00;
        const double ChildTicket = 10.00;
        const double SeniorTicket = 14.00;

        double AdultTicketNum;
        double ChildTicketNum;
        double SeniorTicketNum;

        double AdultTicketSum;
        double ChildTicketSum;
        double SeniorTicketSum;
        double TotalRevenue;
        double TotalVisitors;

        // User input of adult tickets 
        Console.WriteLine("Please enter the number of adult tickets sold out below: ");
        AdultTicketNum = Convert.ToInt32(Console.ReadLine());

        // User input of child tickets 
        Console.WriteLine("Please enter the number of child tickets sold out below: ");
        ChildTicketNum = Convert.ToInt32(Console.ReadLine());

        // User input of senior tickets 
        Console.WriteLine("Please enter the number of senior tickets sold out below: ");
        SeniorTicketNum = Convert.ToInt32(Console.ReadLine());

        // Calculating the sum of each ticket category 
        AdultTicketSum = AdultTicketNum * AdultTicket;
        ChildTicketSum = ChildTicketNum * ChildTicket;
        SeniorTicketSum = SeniorTicketNum * SeniorTicket;

        TotalRevenue = AdultTicketSum + ChildTicketSum + SeniorTicketSum;

        //Console.WriteLine(AdultTicketSum);
        //Console.WriteLine(ChildTicketSum);
        //Console.WriteLine(SeniorTicketSum);

        // For currency format specifier, we use => double.ToString("C3") method
        Console.WriteLine(TotalRevenue.ToString("C3"));
        Console.WriteLine("\n");

        // Task 3 
        // 1st objective
        TotalVisitors = AdultTicketNum + ChildTicketNum + SeniorTicketNum;
        Console.WriteLine("The number of adult tickets sold is ({0}), while its ({1}) for children and ({2}) for seniors. Thus, the total tickets solid is ({3}).", AdultTicketNum, ChildTicketNum, SeniorTicketNum, TotalVisitors.ToString());

        // 2ed objective
        if (AdultTicketNum <= (ChildTicketNum + SeniorTicketNum))
            Console.WriteLine("The competition is becoming a festival for everyone!");
        else if (ChildTicketNum >= SeniorTicketNum)
            Console.WriteLine("The competition is attracting more and more young people!");
        else 
            Console.WriteLine("The competition should have more space for kids!");
    }
}
