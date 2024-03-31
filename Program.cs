using System.Xml.Serialization;
using System;

class Student
{
    public string FullName { get; set; }
    public string GroupNo { get; set; }
    public double AvgPoint { get; set; }
}

class Group
{
    public string No { get; }
    public Student[] Students { get; }
    private int _studentLimit;

    public int StudentLimit
    {
        get { return _studentLimit; }
        set
        {
            if (value < 0 || value > 20)
           
            _studentLimit = value;
        }
    }

    public Group(string no, int studentLimit)
    {
        if (no.Length != 5 || !char.IsUpper(no[0]) || !char.IsUpper(no[1]) || !char.IsDigit(no[2]) || !char.IsDigit(no[3]) || !char.IsDigit(no[4]))
        

        No = no;
        StudentLimit = studentLimit;
        Students = new Student[studentLimit];
    }

    public void Telebelerielaveet(Student student)
    {
        for (int i = 0; i < Students.Length; i++)
        {
            if (Students[i] == null)
            {
                Students[i] = student;
                Console.WriteLine($"telebeleri qrupa elave et.");
                return;
            }
        }
        Console.WriteLine($"Elave ede bilmedik. Qrup doludur.");
    }
}
  
    class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Qrupun nomresini daxil et: ");
            string groupNo = Console.ReadLine();
            Console.Write("Telebe limitini daxil et: ");
            int studentLimit = int.Parse(Console.ReadLine());

            Group group = new Group(groupNo, studentLimit);

            Console.WriteLine($"Telebe limiti olan qrup yaradildi.");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Butun telebeleri goster");
                Console.WriteLine("3. Telebeleri axtar");
                Console.WriteLine("0. Proqrami bitir");

                Console.Write("secim daxil et: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Qrupatelebeelaveet(group);
                        break;
                    case 2:
                        Qrupdakibutuntelebelerebax(group);
                        break;
                    case 3:
                        Qrupdakitelebeleriaxtar(group);
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Yanlis secim.Zehmet olmasa duzgun daxil edin");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Qrupatelebeelaveet(Group group)
    {
        if (group.Students.Length <= group.StudentLimit)
        {
            Console.WriteLine($"telebe elave etmek olmur. qrup doludur");
            return;
        }

        Console.Write("telebenin adini daxil et: ");
        string fullName = Console.ReadLine();
        Console.Write("telebenin qrup nomresini daxil et :");
        string groupNo = Console.ReadLine();
        Console.Write("telebenin ortalama balini daxil et: ");
        double avgPoint = double.Parse(Console.ReadLine());

        Student newStudent = new Student
        {
            FullName = fullName,
            GroupNo = groupNo,
            AvgPoint = avgPoint
        };

        group.Telebelerielaveet(newStudent);
    }

    static void Qrupdakibutuntelebelerebax(Group group)
    {
        Console.WriteLine($"Qru {group.No}:");
        foreach (var student in group.Students)
        {
            if (student != null)
            {
                Console.WriteLine($"Ad: {student.FullName}, Qrupun nomresi: {student.GroupNo}, Ortalama bal: {student.AvgPoint}");
            }
        }
    }

    static void Qrupdakitelebeleriaxtar(Group group)
    {
        Console.Write("Axtarmaq isttediyiniz telebenin adini daxil edin: ");
        string searchName = Console.ReadLine();
        bool found = false;
        foreach (var student in group.Students)
        {
            if (student != null && student.FullName.ToLower().Contains(searchName.ToLower()))
            {
                Console.WriteLine($"Telebe tapildi: Ad: {student.FullName}, Qrupun nomresi: {student.GroupNo}, Ortalama bal: {student.AvgPoint}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Telebe tapilmadi.");
        }
    }
}












