void PrintThirdDigit(int number)
{
  
  Console.Write(number);
  string Str=Convert.ToString(number);
  if (Str.Length>2)
        Console.WriteLine($" -> {Str[2]}"); 
  else 
        Console.WriteLine(" !! There is no third digit");      
}

PrintThirdDigit(new Random().Next(1, 10000));
PrintThirdDigit(89);
PrintThirdDigit(456);
PrintThirdDigit(7);
PrintThirdDigit(4569);

