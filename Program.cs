enum Menu{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPerson
}
class Program{
    static PersonList personlist;

    static void Main(string[] args){
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
        InputMenuFromKeyboard();
    }

    static void PrintMenuScreen(){
        Console.Clear();
        PrintListMenu();
    }

    static void PrintListMenu(){
        Console.WriteLine("Welcome to registration new user school application");
        Console.WriteLine("************************************************");
        Console.WriteLine("1. Registration new Student");
        Console.WriteLine("2. Registration new Teacher");
        Console.WriteLine("3. Get new Person");
        Console.WriteLine("************************************************");
    }
    static void InputMenuFromKeyboard(){
        Console.Write("Please input Menu : ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PersentMenu(menu);
    }

    static void PersentMenu(Menu menu){
        switch(menu){
            case Menu.RegisterNewStudent:
                ShowInputRegistrarionNewStudentScreen();
                break;
            case Menu.RegisterNewTeacher:
                ShowInputRegistrarionNewTeacherScreen();
                break;
            case Menu.GetListPerson:
                ShowPerson();
                break;
            default:
            break;
        }
    }

    static void PrintHeaderRegisterStudent(){
        Console.Clear();
        Console.WriteLine("Register New Student");
        Console.WriteLine("*****************");
    }
    static void ShowInputRegistrarionNewStudentScreen(){
        Console.Clear();
        PrintHeaderRegisterStudent();

        int totalStudent = TotalNewStudent();
        InputNewStudentFormKeyboard(totalStudent);
    }
    static int TotalNewStudent(){
        Console.Write("Input total new Student : ");
        return int.Parse(Console.ReadLine());
    }
    

    static void PrintHeaderRegisterTeacher(){
        Console.Clear();
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("*****************");
    }

    static void ShowInputRegistrarionNewTeacherScreen(){
        Console.Clear();
        PrintHeaderRegisterTeacher();

        int totalTeacher = TotalNewTeacher();
        InputNewStudentFormKeyboard(totalTeacher);
    }

    static int TotalNewTeacher(){
        Console.Write("Input total new Teacher : ");
        return int.Parse(Console.ReadLine());
    }    

    static void InputNewStudentFormKeyboard(int totalNewStudent){
        for(int i = 0; i < totalNewStudent; i++){
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(InputName(),InputStudentID(),InputAddress(),InputCitizenID());
            Program.personlist.AddNewPerson(student);
        }
        BackToMainMenu();
    }
        static void InputNewTeacherFormKeyboard(int totalNewTeacher){
        for(int i = 0; i < totalNewTeacher; i++){
            Console.Clear();
            PrintHeaderRegisterTeacher();

            Teacher teacher = new Teacher (InputName(),InputStudentID(),InputAddress(), InputEmployeeID());
            Program.personlist.AddNewPerson(teacher);
        }
        BackToMainMenu();
    }

    static void BackToMainMenu(){
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void ShowPerson(){
        Console.WriteLine("Show Person");
        Console.WriteLine("***********");

        Program.personlist.FetchPersonList();
    }

    static void PreparePersonListWhenProgramIsLoad(){
        Program.personlist = new PersonList();
    }
    static string InputName(){
        Console.Write("Name : ");
        return Console.ReadLine();
    }

    static string InputStudentID(){
        Console.Write("Student ID : ");
        return Console.ReadLine();
    }

    static string InputAddress(){
        Console.Write("Address : ");
        return Console.ReadLine();
    }

    static string InputCitizenID(){
        Console.Write("Citizen ID : ");
        return Console.ReadLine();
    }

    static string InputEmployeeID(){
        Console.Write("Employee ID : ");
        return Console.ReadLine();
    }
    
    }
