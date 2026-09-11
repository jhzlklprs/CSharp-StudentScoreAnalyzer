//1. Show all scores
// 2. Show passing scores
// 3. Show failed scores
// 4. Show highest score
// 5. Show lowest score
// 6. Show average
// 7. Count passing students
// 8. Find a specific score
// 9. Sort scores
// 10. Exit




List<int> scores = new List<int>
    {
        95, 72, 88, 60, 45, 91, 78, 83, 55, 100
    };

bool keepRunning = true;

do
{


    Menu();


    static void Menu()
    {
        Console.WriteLine("Welcome to Student Score Analyzer!\n");
        Console.WriteLine("=========MENU========");
        Console.WriteLine("1. Show all scores");
        Console.WriteLine("2. Show passing scores");
        Console.WriteLine("3. Show failed scores");
        Console.WriteLine("4. Show highest score");
        Console.WriteLine("5. Show lowest score");
        Console.WriteLine("6. Show average");
        Console.WriteLine("7. Count passing students");
        Console.WriteLine("8. Find a specific score");
        Console.WriteLine("9. Sort scores");
        Console.WriteLine("10. Exit");
        Console.Write("\nChoose an option (1-10): ");
    }


    string choice = Console.ReadLine();

    if (choice == "10")
    {
        Console.WriteLine("\nThank you for using the Student Score Analyzer!");
        keepRunning = false;
        break;
    }
    if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7" && choice != "8" && choice != "9" && choice != "10")
    {
        Console.WriteLine("\nInvalid option. Press any key to try again...");
        Console.ReadKey();
        continue;
    }

    Console.WriteLine("\n----------------------------");

    switch (choice)
    {
        case "1":
            Console.WriteLine("=====All scores=====");
            GetAllScores();
            Console.WriteLine("====================");
            break;

        case "2":
            Console.WriteLine("=====Passing scores=====");
            GetPassingScores();
            Console.WriteLine("========================");
            break;

        case "3":
            Console.WriteLine("=====Failed scores=====");
            GetFailedScores();
            Console.WriteLine("========================");
            break;

        case "4":
            Console.WriteLine("=====Highest score=====");
            GetHighestScore();
            Console.WriteLine("========================");
            break;

        case "5":
            Console.WriteLine("=====Lowest score=====");
            GetLowestScore();
            Console.WriteLine("========================");
            break;

        case "6":
            Console.WriteLine("=====Show Average=====");
            GetAverage();
            Console.WriteLine("======================");
            break;

        case "7":
            Console.WriteLine("=====Passed Students=====");
            GetCountPassed();
            Console.WriteLine("=========================");
            break;

        case "8":
            Console.WriteLine("=====Find Score =====");
            FindSpecificScore();
            Console.WriteLine("=====================");
            break;

        case "9":
            Console.WriteLine("=====Sort Score =====");
            SortScores();
            Console.WriteLine("=====================");
            break;

        case "10":
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }



    void GetAllScores()
    {
        foreach (int s in scores)
        {
            Console.WriteLine(s);
        }
    }

    void GetPassingScores()
    {
        var passingScores = scores.Where(s => s >= 75);

        foreach (var p in passingScores)
        {
            Console.WriteLine(p);
        }
    }

    void GetFailedScores()
    {
        var failedScores = scores.Where(s => s < 75);

        foreach (var f in failedScores)
        {
            Console.WriteLine(f);
        }
    }

    void GetHighestScore()
    {
        var highestScore = scores.Max();

        Console.WriteLine(highestScore);
    }

    void GetLowestScore()
    {
        var lowestScore = scores.Min();

        Console.WriteLine(lowestScore);
    }

    void GetAverage()
    {
        var getAverage = scores.Average();

        Console.WriteLine(getAverage);
    }

    void GetCountPassed()
    {
        var passed = scores.Count(s => s >= 75);

        Console.WriteLine(passed);
    }

    void FindSpecificScore()
    {
        Console.WriteLine("Enter score to find: ");
        int find = int.Parse(Console.ReadLine());

        var isFound = scores.Any(n => n == find);

        if (isFound)
        {
            Console.WriteLine("Score found.");
        }
        else
        {
            Console.WriteLine("Score not found.");
        }

    }

    void SortScores()
        {
            var sortScore = scores.OrderBy(n => n);

            foreach (var s in sortScore)
        {
            Console.WriteLine(s);
        }
            
        }

} while (!keepRunning);






