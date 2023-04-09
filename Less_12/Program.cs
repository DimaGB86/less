//Методы функции
 // Вид 1.

// void Methood1()
// {
//   Console.WriteLine("Автор ...");
// }
// Methood1();


// Вид 2

// void Methood2(string msg)
// {
//   Console.WriteLine(msg);
// }
// Methood2(msg: "Текст сообщения");
// пример 2
// void Methood21(string msg, int count)
// {
//   int i = 0;
//   while (i<count)
//   {
//     Console.WriteLine(msg);
//     i++;
//   }
// }
// Methood21("Текст", 4);

// Вид 3

// int Methood3()
// {
//   return DateTime.Now.Year;
// }
// int year = Methood3();
// Console.WriteLine(year);

// Вид 4

//  string Methood4(int count, string text)
//  {
//   int i = 0;
//   string result = string.Empty;
//   while(i < count)
//   {
//     result = result + text;
//     i++;
//   }
//   return result;
//  }
//  string res = Methood4(10, "Dima");
//  Console.WriteLine(res);

// Пример

string Methood4(int count, string text)
 {
  string result = string.Empty;
  for( int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
 }
 string res = Methood4(10, "привет");
 Console.WriteLine(res);

for( int i = 2; i <= 10; i++)
{
  for( int j = 2; j <= 10; j++)
  {
    Console.WriteLine($"{i} x {j} = {i*j}");
  }
  Console.WriteLine();
}