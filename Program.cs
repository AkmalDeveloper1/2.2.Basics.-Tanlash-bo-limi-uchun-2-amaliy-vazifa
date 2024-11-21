//1.Time calculator-Vaqt kalkulyatori:
Console.Write("Enter the time(minute): ");
ulong timeInMin = Convert.ToUInt64(Console.ReadLine());
string timeInHour = timeInMin / 60 + ":" + timeInMin % 60;
Console.WriteLine(timeInHour);

//2.Determining the age category - Yosh toifasini aniqlash:
//1-way
Console.Write("Enter your age: ");
byte age1 = Convert.ToByte(Console.ReadLine());
if (0 <= age1 && age1 <= 12)
    Console.WriteLine("bola(child)");
else if (13 <= age1 && age1 <= 19)
    Console.WriteLine("o'smir(adolescent)");
else if (20 <= age1 && age1 <= 59)
    Console.WriteLine("kattalar(adults)");
else if (age1 == 60)
    Console.WriteLine("katta(adult)");
else
    Console.WriteLine("There is no such age !!!");
//2-way
Console.Write("Enter your age: ");
byte age2 = Convert.ToByte(Console.ReadLine());
switch (age2)
{
    case byte a when (0 <= a && a <= 12):
        Console.WriteLine("bola(child)");
        break;
    case byte a when (13 <= a && a <= 19):
        Console.WriteLine("o'smir(adolescent)");
        break;
    case byte a when (20 <= a && a <= 59):
        Console.WriteLine("kattalar(adults)");
        break;
    case 60:
        Console.WriteLine("katta(adult)");
        break;
    default:
        Console.WriteLine("There is no such age !!!");
        break;
}

//3.Calculating the average score - O'rtacha ballni hisoblash
Console.Write("Grade for Subject 1: ");
byte subject1 = Convert.ToByte(Console.ReadLine());
Console.Write("Grade for Subject 2: ");
byte subject2 = Convert.ToByte(Console.ReadLine());
Console.Write("Grade for Subject 3: ");
byte subject3 = Convert.ToByte(Console.ReadLine());
ushort averageScore = (ushort)Math.Round((double)(subject1+subject2+subject3)/3);
string result = 
80<=averageScore && averageScore<=100?"A'lo(Excellent)":
60<=averageScore && averageScore<=79?"Yaxshi(Good)":
40<=averageScore && averageScore<=59?"Qoniqarli(Satisfied)":
0<=averageScore && averageScore<=39?"Qoniqarsiz(Unsatisfactory)":
"No such rating available";
Console.WriteLine($"Average Score:{averageScore}\nResult:{result}");

//4. "Find the Number" game - "Raqamni toping" o'yini
Random random = new Random();
byte secretNum = (byte)random.Next(0, 100);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\"Tekshirish uchun: {secretNum}\" "); //Tekshirish uchun random soni 
Console.ResetColor();
byte numOfPerson;
string message;
do
{
    Console.Write("Please enter your number: ");
    numOfPerson = Convert.ToByte(Console.ReadLine());
    message = numOfPerson ==secretNum ? "you found the number" :
    numOfPerson > secretNum ? "your number is larger" :
    "your number is smaller";
    Console.WriteLine(message);
    if (numOfPerson == secretNum)
        break;
}
while (numOfPerson != secretNum);
