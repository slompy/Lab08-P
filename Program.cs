int lessonNumber = 5;
int totalLessons = 1;

while ( lessonNumber >= totalLessons)
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}

Console.WriteLine("Пары кончились");
Console.WriteLine();

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int countGrades = 0;

while (grade != -1) {
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    countGrades++;
}
Console.WriteLine($"Было введено оценок всего: {countGrades}");
Console.WriteLine("Ввод завершён");
