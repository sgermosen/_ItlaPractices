using MyFirstChamba;

Console.WriteLine("Hello, World!");

var obj1 = new CommunityMember();
obj1.Id = 1;
obj1.Name = "Un nombre";

Console.WriteLine(obj1.Name);

var obj2 = new CommunityMemberPublic();
obj2.Id = 1;
obj2.Name = "Un nombre 2";
obj2.Age = 25;

Console.WriteLine(obj1.Name);

Console.ReadKey();
