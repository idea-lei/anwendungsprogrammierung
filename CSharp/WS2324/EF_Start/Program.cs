using EF_Start.Data;
using EF_Start.Models;

using (var db = new AppDbContext())
{

}

//for(int i = 0; i < 100_000_000; i++)
//{
//    using var db = new AppDbContext();
//}

Parallel.For(0, 100_000_000_000, i =>
{
     var db = new AppDbContext();
});


//var s1 = new Student { Name = "Bill", Description = "Bill Gates" };
//var s2 = new Student { Name = "Steve", Description = "Steve Jobs" };

//db.Students.Add(s1);
//db.Students.Add(s2);
//db.SaveChanges();

//{
//    int i = 1;
//}


//var students = db.Students
//    //.Where(s=> s.Name.Contains("Bill"))
//    .ToList();

//foreach (var s in students)
//{
//    Console.WriteLine(s.Name);
//}


//var s = db.Students.Find(1);