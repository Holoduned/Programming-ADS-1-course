using System;
using System.ComponentModel.DataAnnotations;

/*namespace Programming.Programming.Домашние__2_семестр.Homework_25_04_2022;

class Programm
{
    static void Main(string[] args)
    {
        var notVisited = new List<Meet>();
        //notVisited.Add(new Meet(1, new DateTime(2015,3,3, 10, 0, 0), new DateTime(2015,3,3, 11, 10, 0)));
        //notVisited.Add(new Meet(2, new DateTime(2015,3,3, 11, 20, 0), new DateTime(2015,3,3, 14, 0, 0)));
        //notVisited.Add(new Meet(3, new DateTime(2015,3,3, 10, 30, 0), new DateTime(2015,3,3, 11, 30, 0)));
        notVisited.Add(new Meet(1, new DateTime(2015,3,3, 18, 30, 0), new DateTime(2015,3,3, 20, 0, 0)));
        notVisited.Add(new Meet(1, new DateTime(2015,3,3, 18, 30, 0), new DateTime(2015,3,3, 20, 0, 0)));
        notVisited.Add(new Meet(2, new DateTime(2015,3,3, 8, 0, 0), new DateTime(2015,3,3, 11, 30, 0)));
        notVisited.Add(new Meet(3, new DateTime(2015,3,3, 10, 0, 0), new DateTime(2015,3,3, 11, 00, 0)));
        notVisited.Add(new Meet(4, new DateTime(2015,3,3, 15, 30, 0), new DateTime(2015,3,3, 19, 0, 0)));
        notVisited.Add(new Meet(5, new DateTime(2015,3,3, 11, 40, 0), new DateTime(2015,3,3, 13, 30, 0)));
        notVisited.Add(new Meet(6, new DateTime(2015,3,3, 14, 00, 0), new DateTime(2015,3,3, 16, 00, 0)));
        notVisited = notVisited.OrderBy(x => x.meetingTime).ToList();

        List<Meet> visited = new();
        visited.Add(notVisited[0]);
        notVisited.Remove(notVisited[0]);

        while (notVisited.Count != 0)
        {
            var count = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < visited.Count; j++)
                {
                    if (visited[j].start < notVisited[i].start && visited[j].end <= notVisited[i].start ||
                        (visited[j].start > notVisited[i].start && visited[j].start >= notVisited[i].end))
                    {
                        count++;
                    }
                }
            }
            if (count == visited.Count) {visited.Add(notVisited[0]);}

            notVisited.Remove(notVisited[0]);
        }

        foreach (var meet in visited)
        {
            Console.WriteLine(meet.Name);
        }
    }
    
}

class Meet
{
    public int Name;
    public DateTime start;
    public DateTime end;
    public TimeSpan meetingTime;

    public Meet(int n, DateTime s, DateTime e)
    {
        Name = n;
        start = s;
        end = e;
        meetingTime = e - s;
    }
}*/