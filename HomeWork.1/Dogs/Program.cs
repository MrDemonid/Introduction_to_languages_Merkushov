double dist = 10000.0;
double firstFriendSpeed = 1.0;
double secondFriendSpeed = 2.0;
double dogSpeed = 5.0;

double time;
double friendSpeed;

int count = 0;                      // количество пробежек собаки
int curFriend = 1;                  // где в данный момент находится собака (0 - первый друг, 1 - второй друг)

while (dist > 10.0)
{
    if (curFriend == 1)
    {
        friendSpeed = firstFriendSpeed;
    } else {
        friendSpeed = secondFriendSpeed;
    }
    time = dist / (friendSpeed + dogSpeed);
    curFriend ^= 1;
    dist -= (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.WriteLine("Собака пробежит: " + count + " раз.");
