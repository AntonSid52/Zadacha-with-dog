int distance = 10000;
int firstFriendSpeed = 1, secondFriendSpeed = 2;
int dogSpeed = 5;
int friends = 2;
int count = 0;
int time = 0;

if (distance > 10) 
{
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
    } else {
Console.WriteLine("Собака пробежит один раз");}