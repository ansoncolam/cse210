public class GoalManager {

    private List<Goal> _goals;
    private int _score;
    private string _level;

    public GoalManager() {
        _goals= new List<Goal>();
        _score = 0;
        _level = "Beginner";
    }

    public void Start() {
        int userInput1 = 0;
        while (userInput1 != 6) {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice1 = Console.ReadLine();
            userInput1 = int.Parse(userChoice1);
            if (userInput1 == 1) {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string userChoice2 = Console.ReadLine();
                int userInput2 = int.Parse(userChoice2);
                CreateGoal(userInput2);
            } else if (userInput1 == 2) {
                ListGoalDetails();
            } else if (userInput1 == 3) {
                SaveGoals();
            } else if (userInput1 == 4) {
                LoadGoals();
            } else if (userInput1 == 5) {
                RecordEvent();
            } else if (userInput1 == 6) {
                Console.WriteLine("Good Bye!");
                break;
            }
        }
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"Your level: {_level}");
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames() {
        int i = 1;
        foreach(Goal goal in _goals) {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i = i + 1;
        }
    }

    public void ListGoalDetails() {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach(Goal goal in _goals) {
            Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
            i = i + 1;
        }
    }

    public void CreateGoal(int goalType) {
        if (goalType == 1) {
            SimpleGoal myGoal = new SimpleGoal("", "", 0);
            Console.Write("What is the name of your goal? ");
            myGoal.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            myGoal.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of points associated with this goal? ");
            myGoal.SetPoints(int.Parse(Console.ReadLine()));
            _goals.Add(myGoal);
        } else if (goalType == 2) {
            EternalGoal myGoal = new EternalGoal("", "", 0);
            Console.Write("What is the name of your goal? ");
            myGoal.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            myGoal.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of points associated with this goal? ");
            myGoal.SetPoints(int.Parse(Console.ReadLine()));
            _goals.Add(myGoal);
        } else if (goalType == 3) {
            ChecklistGoal myGoal = new ChecklistGoal("", "", 0, 0, 0);
            Console.Write("What is the name of your goal? ");
            myGoal.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            myGoal.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of points associated with this goal? ");
            myGoal.SetPoints(int.Parse(Console.ReadLine()));
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            myGoal.SetTarget(int.Parse(Console.ReadLine()));
            Console.Write("What is the bonus for accomplishing it that many times? ");
            myGoal.SetBonus(int.Parse(Console.ReadLine()));
            _goals.Add(myGoal);
        }
    }

    public void RecordEvent() {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        _goals[goalNumber].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {_goals[goalNumber].GetPoints()} points!");
        _score = _score + _goals[goalNumber].GetPoints();
        Console.WriteLine($"You now have {_score} points.");
        if (_score >= 4000 && _level != "Expert") {
            _level = "Expert";
            Console.WriteLine($" *** Level up to {_level}! *** ");
        } else if (_score >= 3000 && _level != "Advanced") {
            _level = "Advanced";
            Console.WriteLine($" *** Level up to {_level}! *** ");
        } else if (_score >= 2000 && _level != "Intermediate") {
            _level = "Intermediate";
            Console.WriteLine($" *** Level up to {_level}! *** ");
        } else if (_score >= 1000 && _level != "Elementary") {
            _level = "Elementary";
            Console.WriteLine($" *** Level up to {_level}! *** ");
        }
    }

    public void SaveGoals() {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals() {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int i = 0;
        foreach (string line in lines) {
            string[] parts = line.Split("~|~");
            while (i == 0) {
                _score = int.Parse(parts[0]);
                i = i + 1;
            }
            if (parts[0] == "SimpleGoal") {
                SimpleGoal myGoal = new SimpleGoal("", "", 0);
                myGoal.SetName(parts[1]);
                myGoal.SetDescription(parts[2]);
                myGoal.SetPoints(int.Parse(parts[3]));
                myGoal.SetIsComplete(bool.Parse(parts[4]));
                _goals.Add(myGoal);
            } else if (parts[0] == "EternalGoal") {
                EternalGoal myGoal = new EternalGoal("", "", 0);
                myGoal.SetName(parts[1]);
                myGoal.SetDescription(parts[2]);
                myGoal.SetPoints(int.Parse(parts[3]));
                _goals.Add(myGoal);
            } else if (parts[0] == "ChecklistGoal") {
                ChecklistGoal myGoal = new ChecklistGoal("", "", 0, 0, 0);
                myGoal.SetName(parts[1]);
                myGoal.SetDescription(parts[2]);
                myGoal.SetPoints(int.Parse(parts[3]));
                myGoal.SetBonus(int.Parse(parts[4]));
                myGoal.SetTarget(int.Parse(parts[5]));
                myGoal.SetAmountCompleted(int.Parse(parts[6]));
                _goals.Add(myGoal);
            }    
        }
    }

}
