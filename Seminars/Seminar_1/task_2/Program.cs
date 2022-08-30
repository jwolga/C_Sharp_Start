Console.WriteLine("Input week day number");
int week_day_number = int.Parse(Console.ReadLine());
string week_day_name = null;

switch(week_day_number)
{
    case 1:
        week_day_name = "Monday";
        break;
    case 2:
        week_day_name = "Tuesday";
        break;
    case 3:
        week_day_name = "Wednesday";
        break;
    case 4:
        week_day_name = "Thursday";
        break;
    case 5:
        week_day_name = "Friday";
        break;
     case 6:
        week_day_name = "Saturday";
        break;
     case 7:
        week_day_name = "Sanday";
        break;
     default:
        Console.WriteLine($"{week_day_number} is invalid");
        return;

}

Console.WriteLine($"{week_day_number} is {week_day_name}");