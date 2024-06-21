


//using Linq;

////Display.ShowResult(Cem, 5, 3);
////Display.ShowResult(Hasil, 5, 3);

//int Cem(int a, int b)
//{
//    return a + b;
//}

//int Hasil(int a, int b)
//{
//    return a * b;
//}

//var print =  (string message) => message;
//var print3 = (string message) =>
//{
//    Console.WriteLine(message);
//};

//var print2 =  (string message) => { return message; };

//Display.ShowResult((int a, int b) => a + b, 5, 4);
//Display.ShowResult((int a, int b) => a * b, 5, 4);
//Display.ShowResult((int a, int b) => a % b, 5, 4);



using Linq;

//List<int> numbers = new List<int>() { 23, 4, 8, 11, 6, 57, 18, 9 };
//List<int> copyList = new () { };

//foreach (int number in numbers)
//{
//    if(number > 10)
//        copyList.Add(number);
//}

//Console.WriteLine();

// select num from numbers where num > 10


// sql-e cox yaxindir
//List<int> copyList = (from num in numbers
//                      where num > 10
//                      select num).ToList();

//List<int> copyList1 = numbers.Where(x=> x > 10).ToList();

//List<Student> students = new()
//{
//    new ()
//    {
//       Id = 1,
//       Name = "A",
//       Grade = 99.9
//    },
//     new ()
//    {
//       Id = 2,
//       Name = "B",
//       Grade = 77.9
//    },
//      new ()
//    {
//       Id = 3,
//       Name = "C",
//       Grade = 66.9
//    }
//};
//Console.WriteLine("Please enter id");
//int id =Convert.ToInt32(Console.ReadLine());
//var newList =  students.Where(x=>x.Id == id);


// her ededdin countunu tapmaliyiq
//List<int> numbers2 = new() { 23, 4, 8, 4,  23, 11, 6, 57, 4, 18, 8 };
//Dictionary<int, int> newList = new Dictionary<int, int>() { };


//for (int i = 0; i < numbers2.Count; i++)
//{
//    if (newList.ContainsKey(numbers2[i]))
//    {
//        newList[numbers2[i]]++;
//    }
//    else
//    {
//        newList[numbers2[i]] = 1;
//    }
//}


//Console.WriteLine();

// select num, count(num) from numbers group by num
//var counts = numbers2
//            .GroupBy(num => num)
//            .Select(x => new
//            {
//                reqem = x,
//                sayi = x.Count()
//            })
//            .ToList();

//var res =  numbers2.ToList();

//IEnumerable<Student> students;
//IQueryable<Student> students2;

List<Student> students = new()
{
    new  ()
    {
       Id = 1,
       Name = "A",
       Grade = 99.9
    },
     new ()
    {
       Id = 2,
       Name = "B",
       Grade = 77.9
    },
      new ()
    {
       Id = 3,
       Name = "C",
       Grade = 66.9
    }
};
//List<Student> newList = new() { };

List<int> numbers2 = new() { 23, 4, 8, 4, 23, 11, 6, 57, 4, 18, 8 };
//Select
//var res =  students.Select(x=> new 
//{
//    x.Id,
//    x.Name,
//}).ToList();


//foreach (var student in res)
//{
//    Console.WriteLine($"Id : {student.Id} : Name {student.Name}");
//}

//students.Where(x=>x.Name == "A").ToList();
//students.OrderBy(x => x.Id).ToList();
//students.OrderByDescending(x => x.Name).ToList();


//var res =  students.All(x=>x.Id == 1);
//var res2 =  students.Any(x=>x.Id == 4545);
//Console.WriteLine(res);
//Console.WriteLine(res2);
//Console.WriteLine(students.Contains(students[0]));


//Console.WriteLine(numbers2.Average());
//Console.WriteLine(students.Average(x=>x.Grade));

//Console.WriteLine(numbers2.Count);
//Console.WriteLine(numbers2.Count(x => x % 2 == 0));


//Console.WriteLine(numbers2.Max(x=>x / 2 ==0));
//Console.WriteLine(numbers2.Min(x=>x / 2 ==0));
//Console.WriteLine(numbers2.MaxBy(x => x % 2 == 0));


//numbers2.Sum();

//Console.WriteLine("Please enter id");
//int id = Convert.ToInt32(Console.ReadLine());

//var res = students.FirstOrDefault(x => x.Id == id);
//if (res is null)
//    Console.WriteLine("There is no data");
//else
//    Console.WriteLine(res.Name);

//var res = numbers2.FirstOrDefault(x=> x == 100);
//Console.WriteLine(res);


//students
//    .Skip(10)
//    .OrderBy(x=>x.Name)
//    .Take(10);
