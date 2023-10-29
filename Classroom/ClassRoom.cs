using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassRoom;
class ClassRoom {
    private Teacher teacher;
    private Student[] students = new Student[10];
    private int currentNumberOfStudents;
    private int maxStudents;

    public ClassRoom(int maxStudents) {
        this.maxStudents = maxStudents;
        students = new Student[maxStudents];
        currentNumberOfStudents = 0;
    }
    public bool AddStudent(Student student) {
        if(currentNumberOfStudents < maxStudents) {
            students[currentNumberOfStudents] = student;
            currentNumberOfStudents++;
            return true;
        }
        return false;
    }
    public bool RemoveStudent() {
        if(currentNumberOfStudents > 0) {
            currentNumberOfStudents--;
            return true;
        } else
            return false;
    }
    public void AddTeacher(Teacher teacher) {
        this.teacher = teacher;
    }
    public string GetTeacherName() {
        return teacher.name;
    }
    public Student GetStudent(int index) {
        if(index >= 0 && index < currentNumberOfStudents) {
            return students[index];
        }
        return null;
    }
    public override string ToString() {
        string classInfo = $"Teacher: {GetTeacherName()}\nStudents: ";
        foreach(var student in students) {
            if(student != null)
                classInfo += student.ToString() + ", ";
        }
        return classInfo.TrimEnd(' ', ',');
    }
}
class Student {
    private string firstName = "";
    private string lastName = "";
    private double age;
    private double average;
    public Student(string firstName, string lastName, double age, double average) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.average = average;
    }
    public override string ToString() {
        return ($"Jméno:{firstName} {lastName} Věk:{age} Průměr:{average}");
    }
}
class Teacher {
    public string name = "";
    public int age;
    public Teacher(string name, int age) {
        this.name = name;
        this.age = age;
    }
}
