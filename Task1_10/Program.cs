void PrintSecondDigit(int number)
{
  Console.Write(number);
  number = Math.Abs(number);
  if ( number >99 & number <1000)
  {  
     int n=(number/10)%10;
     Console.WriteLine($" -> {n}");
  } 
  else 
     Console.WriteLine(" Not a 3-digital number");    
}

PrintSecondDigit(new Random().Next(100, 1000));
PrintSecondDigit(9756);
PrintSecondDigit(76);
PrintSecondDigit(-789);