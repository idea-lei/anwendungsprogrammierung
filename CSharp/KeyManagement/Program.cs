using KeyManagement.Data;
using KeyManagement.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
context.Database.Migrate();

// Schritt 1
//var student = new Student { 
//    FirstName = "Alex",
//    LastName = "Mustermann",
//    Age = 20,
//    Adresse= new Adresse { 
//        PLZ = 47057,
//        StrasseUndHausNr = "Keetmanstr 3-9",
//        Stadt = "Duisburg"
//    }
//};

//context.Students.Add(student);
//context.SaveChanges();


// Schritt 2
//if (context.Students.FirstOrDefault() is not Student student)
//    return;

//student.Birthday = new(2000, 1, 1);

//student.Adresse.PLZ = 47058;

//context.Students.Update(student);
//context.SaveChanges();

//Console.WriteLine(student);