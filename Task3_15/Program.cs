void IfWeekEnd(int number)
{    
    Console.Write(number);
    if (number == 6 | number == 7)
        Console.WriteLine("  Yes! It's WeekEnd!");
    else if (number>0 & number <6) 
            Console.WriteLine("  No! It's not WeekEnd!");
          else      
            Console.WriteLine(" It's not a proper number "); 
}
IfWeekEnd(3);
IfWeekEnd(1);
IfWeekEnd(6);
IfWeekEnd(7);
IfWeekEnd(-3);