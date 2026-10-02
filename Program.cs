// int lessonNumber = 5;
// int totalLessons = 1;

// while ( lessonNumber >= totalLessons)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары кончились");
// Console.WriteLine();

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int countGrades = 0;

// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     countGrades++;
// }
// Console.WriteLine($"Было введено оценок всего: {countGrades}");
// Console.WriteLine("Ввод завершён");

// int sum = 0;
// int count = 0;
// int max = 0;

// System.Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine()!);
// while (grade != -1) {
//     sum += grade;
//     count++;

//     if (count == 1 || grade > max) {
//         max = grade;
//     }

//     grade = int.Parse(System.Console.ReadLine()!);
// g
// }

// if (count > 0) {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     System.Console.WriteLine($"Наибольшее введенная оценка: {max}");
// } else {
//     System.Console.WriteLine("Оценок не было введено");
// }


// string correctPassword = "qwerty123";
// int failCount = 0;

// while (true) {
//     System.Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = System.Console.ReadLine()!;

//      if (password == correctPassword) {
//         System.Console.WriteLine("Доступ разрешён");
//         Console.WriteLine($"Неверных попыток: {failCount}");
//         break;
//      }

//      System.Console.WriteLine("Неверный пароль, попробуйте снова");
//      failCount++;
// }

// string answer;

// do {
//     System.Console.Write("Введите дату посещения (например, 01.01): ");
//     string date = System.Console.ReadLine()!;
//     System.Console.WriteLine($"Запись добавлена: {date}");

//     System.Console.Write("Добавить еще одну запись? (да/нет): ");
//     answer = System.Console.ReadLine()!;
// } while (answer == "да");

// System.Console.WriteLine("Дневник сохранён");


// // Задача Б
// Console.WriteLine();
// Console.Write("Вводите имена учеников, для завершения введите end: ");
// string names = Console.ReadLine()!;
// int countNames = 0;

// while (names != "end") {
//     Console.WriteLine($"Имя принято: {names}");
//     names = Console.ReadLine()!;
//     countNames++;
// }
// Console.WriteLine($"Было введено имён всего: {countNames}");
// Console.WriteLine("Ввод завершён");
// // Задача Г
// int correctNumber = 7;

// while (true) {
//     System.Console.WriteLine("Введите целое число: ");
//     int userNumber = int.Parse(System.Console.ReadLine()!);

//      if (userNumber == correctNumber) {
//         System.Console.WriteLine("Найдено!");
//         break;
//      }

//      System.Console.WriteLine("Неверное число, попробуйте ещё!");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// Вариант 7

int counts = 0;
int sum = 0;
System.Console.Write("Введите температуру: ");
int temps = int.Parse(System.Console.ReadLine()!);

while (counts != 7) {
    sum += temps;
    counts++;
    System.Console.Write("Введите температуру: ");
    temps = int.Parse(System.Console.ReadLine()!);
}
System.Console.WriteLine();
if (counts == 7) {
    Console.WriteLine($"Средняя температура за 7 дней: {(double)sum / counts}");
} else {
    System.Console.WriteLine("Температуры не было введено");
}



