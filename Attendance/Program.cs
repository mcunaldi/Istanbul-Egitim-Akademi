// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> students = new List<string>() { "Taner", "Ahmet", "Mehmet" };
List<bool> isThere = new List<bool>(students.Count);


for (int i = 0; i < students.Count; i++)
{
    isThere.Add(false);
}

Console.WriteLine("Hi, this is my studens!");
Console.WriteLine("Tell me who is in class?");

for (int i = 0; i < students.Count; i++)
{
    Console.WriteLine($"{i + 1}. {students[i]}");
}


while (true)
{
    string result = Console.ReadLine();
    int studentsNumber = 0;

    bool isConvertSuccess = int.TryParse(result, out studentsNumber);

    if (isConvertSuccess == false)
    {
        Console.WriteLine("Student not found.");
    }

    else if (isConvertSuccess == true && studentsNumber == 0)
    {
        {
            if (!isThere[0])
            {
                string studentName = students[0];
                Console.WriteLine($"{studentName} is now in class.");
                isThere.Add(true);
                isThere[0] = true;
                Console.WriteLine("Who else is in class?");
            }
            else
            {
                Console.WriteLine($"{students[0]} is already marked as in class.");

            }

        }

    }

    else if (isConvertSuccess == true && studentsNumber == 1)
    {
        {
            if (!isThere[1])
            {
                string studentName = students[1];
                Console.WriteLine($"{studentName} is now in class.");
                isThere.Add(true);
                isThere[1] = true;
                Console.WriteLine("Who else is in class?");
            }
            else
            {
                Console.WriteLine($"{students[0]} is already marked as in class.");
            }

        }
    }

    else if (isConvertSuccess == true && studentsNumber == 2)
    {
        {
            if (!isThere[2])
            {
                string studentName = students[2];
                Console.WriteLine($"{studentName} is now in class.");
                isThere.Add(true);
                isThere[2] = true;
            }
            else
            {
                Console.WriteLine($"{students[0]} is already marked as in class.");
            }

            bool allInClass = isThere.TrueForAll(x => x == true);

            if (allInClass)

            {
                Console.WriteLine("All students are in class. Closing the application.");
            }

        }
    }

    else
    {
        Console.WriteLine("Student is not found.");
    }

}










