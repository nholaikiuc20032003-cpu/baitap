public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Student()
    {
    }

    public Student(string id, string name, int age, string address)
    {
        Id = id;
        Name = name;
        Age = age;
        Address = address;
    }
}
using System;
using System.Collections.Generic;

public class StudentDAO
{
    // Thêm sinh viên
    public void Add(Student student)
    {
    }

    // Sửa sinh viên
    public void Edit(Student student)
    {
    }

    // Xóa sinh viên theo ID
    public void Delete(string id)
    {
    }

    // Lấy tất cả sinh viên
    public List<Student> getAlls()
    {
        return new List<Student>();
    }

    // Lấy sinh viên theo ID
    public Student getById(string id)
    {
        return null;
    }

    // Lấy sinh viên theo tên
    public List<Student> getByName(string name)
    {
        return new List<Student>();
    }
}

