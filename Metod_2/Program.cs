Console.WriteLine("Введите расстояние");
int distance = int.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость первого друга");
int firstFriendSpeed = int.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга");
int secondFriendSpeed =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость собаки");
int dogSpeed = int.Parse(Console.ReadLine());
int friends = 2;
int count = 0;
int time = 0;

if (distance <= 0) 
    {
    Console.WriteLine("Собака не побежит");
    } 
else
    {while (distance>10)
    {
        if(friends == 1)
        {
           time = distance/(firstFriendSpeed + dogSpeed);
           friends = 2; 
        }
        else
        { time = distance/(secondFriendSpeed + dogSpeed);
           friends = 1; 
        }
        distance = distance - (firstFriendSpeed+secondFriendSpeed)*time;
        count++;
    }
    Console.WriteLine("Собака пробежит "+ count+" раз");
    }