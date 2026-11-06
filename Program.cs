int totalExercises = 8;

for (int number = totalExercises; number >= 1; number--) 
{
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");


for (int room = 5; room <= 50; room += 5) 
{
    Console.WriteLine($"Кабинет {room}");
}



int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++) 
{
    for (int day = 1; day <= 5; day++) 
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("^_^");
}


int skippedTickets = 0;

for (int ticket = 1; ticket <= 30; ticket++) 
{
    if (ticket == 4 || ticket == 12 || ticket == 19) 
    {
        skippedTickets++;
        continue;
    }

    Console.WriteLine($"Первый доступный билет: {ticket}");
    Console.WriteLine($"Пропущено билетов: {skippedTickets}");
    break;
}



int n = 15;

for (int i = 1; i <= n; i += 2)
{
    Console.WriteLine(i);
}


for (int i = 100; i >= 0; i -= 10)
{
    Console.WriteLine(i);
}

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine(); // Разделитель между блоками чисел
}

for (int i = 1; i <= 50; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"Первое число, кратное 7: {i}");
        break;
    }

    if (i % 3 == 0)
    {
        continue;
    }

    Console.WriteLine(i);
}



int n = 22;
int sum = 0;

for (int i = 1; i <= n; i++)
{
    if (i % 5 == 0)
    {
        continue;
    }
    sum += i;
}

Console.WriteLine($"Сумма чисел от 1 до {n} без кратных 5 равна: {sum}");



Console.Write("Введите общее количество недель тренировок N: ");
int n = int.Parse(Console.ReadLine());

int trainingDaysCount = 0;
bool enough = false;

for (int week = 1; week <= n && !enough; week++)
{
    for (int day = 1; day <= 7; day++)
    {
        if (day == 7)
        {
            continue;
        }

        trainingDaysCount++;

        if (trainingDaysCount == 20)
        {
            enough = true;
            Console.WriteLine($"Набрано 20 тренировочных дней! Остановка на неделе {week}, день {day}.");
            break;
        }
    }
}
