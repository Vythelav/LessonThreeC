using System;
using System.Linq;

    internal class Program
    {
    static void Main(string[] args)
    {
        //1 


        //Console.Write("Введите число: ");
        //int a = Convert.ToInt32(Console.ReadLine());

        //if(a > 0)
        //{
        //    Console.WriteLine("Чмсло больше нуля");
        //}else if(a < 0)
        //{
        //    Console.WriteLine("Число меньше нуля");
        //}else 
        //{
        //    Console.WriteLine("Число равно нулю");
        //}

        //2


        //Console.Write("Введите год: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        //{
        //    Console.WriteLine($"Год {year} - високосный");
        //}
        //else
        //{
        //    Console.WriteLine($"Год {year} - не високосный");
        //}


        //3


        //Console.Write("Введите символ: ");
        //char symvol = Convert.ToChar(Console.ReadLine());
        //string al = "аиыоюеуАИЫОЮЕУ";
        //if (char.IsLetter(symvol))
        //{
        //    if (al.Contains(symvol))
        //    {
        //        Console.WriteLine($"{symvol} - гласная буква");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{symvol} - согласная буква");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Введенный символ не является буквой.");
        //}


        //4


        //Console.Write("Введите первое число: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введите второе число: ");
        //int num2 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введите третье число: ");
        //int num3 = Convert.ToInt32(Console.ReadLine());

        //if (num1 <= num2 && num1 <= num3)
        //{
        //    Console.WriteLine($"Наименьшее число: {num1}");
        //}
        //else if (num2 <= num1 && num2 <= num3)
        //{
        //    Console.WriteLine($"Наименьшее число: {num2}");
        //}
        //else
        //{
        //    Console.WriteLine($"Наименьшее число: {num3}");
        //}


        //5


        //Console.Write("Введите год: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //if (year % 100 == 0)
        //{
        //    Console.WriteLine($"{year} - вековой год");
        //}
        //else
        //{
        //    Console.WriteLine($"{year} - не является вековым годом");
        //}


        //6


        //Console.Write("Введите число от 10 до 20: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //if (number >= 10 && number <= 20)
        //{
        //    Console.WriteLine($"{number} принадлежит диапазону");
        //}
        //else
        //{
        //    Console.WriteLine($"{number} не принадлежит диапазону");
        //}


        //7


        //Console.Write("Введите символ: ");
        //char symbol = Convert.ToChar(Console.ReadLine());
        //if (char.IsDigit(symbol))
        //{
        //    Console.WriteLine($"{symbol} - это цифра");
        //}
        //else if (char.IsLetter(symbol))
        //{
        //    Console.WriteLine($"{symbol} - это буква");
        //}
        //else
        //{
        //    Console.WriteLine($"{symbol} - это специальный символ");
        //}


        //8


        //Console.Write("Введите название месяца: ");
        //string month = Console.ReadLine().ToLower();

        //switch (month)
        //{
        //    case "декабрь":
        //    case "январь":
        //    case "февраль":
        //        Console.WriteLine("Это зимний месяц");
        //        break;
        //    case "март":
        //    case "апрель":
        //    case "май":
        //        Console.WriteLine("Это весенний месяц");
        //        break;
        //    case "июнь":
        //    case "июль":
        //    case "август":
        //        Console.WriteLine("Это летний месяц");
        //        break;
        //    case "сентябрь":
        //    case "октябрь":
        //    case "ноябрь":
        //        Console.WriteLine("Это осенний месяц");
        //        break;
        //    default:
        //        Console.WriteLine("Такого месяца не существует или введено некорректное значение");
        //        break;
        //}


        //9


        //Console.Write("Введите год: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //int century = year / 100;

        //if (century == 19)
        //{
        //    Console.WriteLine($"{year} год принадлежит XX веку");
        //}
        //else if (century == 20)
        //{
        //    Console.WriteLine($"{year} год принадлежит XXI веку");
        //}
        //else
        //{
        //    Console.WriteLine("Год не принадлежит ни к XX, ни к XXI веку");
        //}


        //10


        //Console.Write("Введите число: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //if (number % 2 == 0)
        //{
        //    Console.WriteLine($"{number} - четное число");
        //}
        //else
        //{
        //    Console.WriteLine($"{number} - нечетное число");
        //}


        //11


        //Console.Write("Введите символ: ");
        //char symbol = Convert.ToChar(Console.ReadLine());
        //if (char.IsLower(symbol))
        //{
        //    Console.WriteLine($"{symbol} - строчная буква");
        //}
        //else if (char.IsUpper(symbol))
        //{
        //    Console.WriteLine($"{symbol} - заглавная буква");
        //}
        //else
        //{
        //    Console.WriteLine($"{symbol} - не является буквой");
        //}


        //12


        //Console.Write("Введите номер месяца (от 1 до 12): ");
        //int month = Convert.ToInt32(Console.ReadLine());

        //int quarter = (month - 1) / 3 + 1;

        //switch (quarter)
        //{
        //    case 1:
        //        Console.WriteLine($"Месяц {month} принадлежит первому кварталу");
        //        break;
        //    case 2:
        //        Console.WriteLine($"Месяц {month} принадлежит второму кварталу");
        //        break;
        //    case 3:
        //        Console.WriteLine($"Месяц {month} принадлежит третьему кварталу");
        //        break;
        //    case 4:
        //        Console.WriteLine($"Месяц {month} принадлежит четвертому кварталу");
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        break;
        //}


        //13


        //Console.Write("Введите номер месяца (от 1 до 12): ");
        //int month = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введите год: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //int daysInMonth;

        //switch (month)
        //{
        //    case 1:
        //    case 3:
        //    case 5:
        //    case 7:
        //    case 8:
        //    case 10:
        //    case 12:
        //        daysInMonth = 31;
        //        break;
        //    case 4:
        //    case 6:
        //    case 9:
        //    case 11:
        //        daysInMonth = 30;
        //        break;
        //    case 2:
        //        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        //        {
        //            daysInMonth = 29;
        //        }
        //        else
        //        {
        //            daysInMonth = 28;
        //        }
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        return;
        //}

        //Console.WriteLine($"В {month} месяце {year} года {daysInMonth} дней.");


        //14


        //Console.Write("Введите номер месяца (от 1 до 12): ");
        //int month = Convert.ToInt32(Console.ReadLine());


        //string monthName;

        //switch (month)
        //{
        //    case 1:
        //        monthName = "Январь";
        //        break;
        //    case 2:
        //        monthName = "Февраль";
        //        break;
        //    case 3:
        //        monthName = "Март";
        //        break;
        //    case 4:
        //        monthName = "Апрель";
        //        break;
        //    case 5:
        //        monthName = "Май";
        //        break;
        //    case 6:
        //        monthName = "Июнь";
        //        break;
        //    case 7:
        //        monthName = "Июль";
        //        break;
        //    case 8:
        //        monthName = "Август";
        //        break;
        //    case 9:
        //        monthName = "Сентябрь";
        //        break;
        //    case 10:
        //        monthName = "Октябрь";
        //        break;
        //    case 11:
        //        monthName = "Ноябрь";
        //        break;
        //    case 12:
        //        monthName = "Декабрь";
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        return;
        //}

        //Console.WriteLine($"Месяц {monthName}");


        //15

        //Console.Write("Введите номер месяца (от 1 до 12): ");
        //int month = Convert.ToInt32(Console.ReadLine());
        //string season;

        //switch (month)
        //{
        //    case 12:
        //    case 1:
        //    case 2:
        //        season = "Зима";
        //        break;
        //    case 3:
        //    case 4:
        //    case 5:
        //        season = "Весна";
        //        break;
        //    case 6:
        //    case 7:
        //    case 8:
        //        season = "Лето";
        //        break;
        //    case 9:
        //    case 10:
        //    case 11:
        //        season = "Осень";
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        return;
        //}

        //Console.WriteLine($"Месяц относится к сезону: {season}");


        //16


        //Console.Write("Введите номер дня недели (от 1 до 7): ");
        //int dayNumber = Convert.ToInt32(Console.ReadLine());

        //string dayName;

        //switch (dayNumber)
        //{
        //    case 1:
        //        dayName = "Понедельник";
        //        break;
        //    case 2:
        //        dayName = "Вторник";
        //        break;
        //    case 3:
        //        dayName = "Среда";
        //        break;
        //    case 4:
        //        dayName = "Четверг";
        //        break;
        //    case 5:
        //        dayName = "Пятница";
        //        break;
        //    case 6:
        //        dayName = "Суббота";
        //        break;
        //    case 7:
        //        dayName = "Воскресенье";
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер дня недели");
        //        return;
        //}

        //Console.WriteLine($"День недели {dayName}");


        //17


        //Console.WriteLine("Введите дату (день, месяц, год):");
        //Console.Write("День: ");
        //int day = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Месяц: ");
        //int month = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Год: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //DateTime date = new DateTime(year, month, day);
        //DayOfWeek dayOfWeek = date.DayOfWeek;
        //string dayName;

        //switch (dayOfWeek)
        //{
        //    case DayOfWeek.Monday:
        //        dayName = "Понедельник";
        //        break;
        //    case DayOfWeek.Tuesday:
        //        dayName = "Вторник";
        //        break;
        //    case DayOfWeek.Wednesday:
        //        dayName = "Среда";
        //        break;
        //    case DayOfWeek.Thursday:
        //        dayName = "Четверг";
        //        break;
        //    case DayOfWeek.Friday:
        //        dayName = "Пятница";
        //        break;
        //    case DayOfWeek.Saturday:
        //        dayName = "Суббота";
        //        break;
        //    case DayOfWeek.Sunday:
        //        dayName = "Воскресенье";
        //        break;
        //    default:
        //        dayName = "Некорректный день недели";
        //        break;
        //}

        //Console.WriteLine($"День недели {dayName}");


        //18


        //Console.Write("Введите номер месяца (1-12): ");
        //int month = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Введите год: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //int daysInMonth;

        //if (month < 1 || month > 12)
        //{
        //    Console.WriteLine("Некорректный номер месяца");
        //    return;
        //}

        //switch (month)
        //{
        //    case 1:
        //    case 3:
        //    case 5:
        //    case 7:
        //    case 8:
        //    case 10:
        //    case 12:
        //        daysInMonth = 31;
        //        break;
        //    case 4:
        //    case 6:
        //    case 9:
        //    case 11:
        //        daysInMonth = 30;
        //        break;
        //    case 2:
        //        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        //        {
        //            daysInMonth = 29;
        //        }
        //        else
        //        {
        //            daysInMonth = 28;
        //        }
        //        break;
        //    default:
        //        daysInMonth = -1; 
        //        break;
        //}

        //Console.WriteLine($"В {year} году в {month} месяце {daysInMonth} дней.");


        //19


        //Console.Write("Введите время суток (0-23): ");
        //int time = Convert.ToInt32(Console.ReadLine());

        //string timeOfDay;

        //if (time < 0 || time > 23)
        //{
        //    Console.WriteLine("Некорректное время суток");
        //    return;
        //}

        //if (time >= 6 && time < 12)
        //{
        //    timeOfDay = "утро";
        //}
        //else if (time >= 12 && time < 18)
        //{
        //    timeOfDay = "день";
        //}
        //else if (time >= 18 && time < 24)
        //{
        //    timeOfDay = "вечер";
        //}
        //else
        //{
        //    timeOfDay = "ночь";
        //}
        //switch (timeOfDay)
        //{
        //    case "утро":
        //        Console.WriteLine("утро");
        //        break;
        //    case "день":
        //        Console.WriteLine("день");
        //        break;
        //    case "вечер":
        //        Console.WriteLine("вечер");
        //        break;
        //    case "ночь":
        //        Console.WriteLine("ночь");
        //        break;
        //    default:
        //        Console.WriteLine("Не удалось определить время суток");
        //        break;
        //}


        //20


        //Console.Write("Введите номер года: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //if (year % 100 == 0)
        //{
        //    switch (year / 100)
        //    {
        //        case 1:
        //            Console.WriteLine($"{year} - это 1-й век");
        //            break;
        //        case 2:
        //            Console.WriteLine($"{year} - это 2-й век");
        //            break;
        //        default:
        //            Console.WriteLine($"{year} - это {year / 100}-й век");
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine($"{year} - это не вековой год");
        //}
    }
}

