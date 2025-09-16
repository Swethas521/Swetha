using System;
class Student{
    private int r = 34;
    public int Roll_no
    {
        get {return r;}
    }
    public static void Main(string[] args)
    {
        Student s = new Student();
        Console.WriteLine("Roll_No: " + s.Roll_no);
    }
}