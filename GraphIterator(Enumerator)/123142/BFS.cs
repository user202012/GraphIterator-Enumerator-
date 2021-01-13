using System;
using System.Collections.Generic;
public class BFS : IAlgorithm
{
    List<object> storage = new List<object>();
    public void Algorithm(List<object> item)
    {
        ConcreteAggregate container = new ConcreteAggregate(item);
        List<object> array = new List<object>();
        foreach (List<object> i in container)
        {
            if (!storage.Contains(i[0]))
            {
                storage.Add(i[0]);
                Console.WriteLine(i[0]);
            }
            if (Convert.ToString(i[1].GetType()) == "System.Int32")
            {
                storage.Add(i[1]);
                Console.WriteLine(i[1]);
            }
            else
            {
                foreach (List<object> j in (List<object>)i[1])
                {
                    array.Add(j);
                    if (!storage.Contains(j[0]))
                    {
                        storage.Add(j[0]);
                        Console.WriteLine(j[0]);
                    }
                }
            }
        }
        if (array.Count != 0)
        {
            Algorithm(array);
        }
    }
}
