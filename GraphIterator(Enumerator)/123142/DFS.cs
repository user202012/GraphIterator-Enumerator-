using System;
using System.Collections.Generic;
public class DFS: IAlgorithm
{
    public void Algorithm(List<object> item)
    {
        ConcreteAggregate container = new ConcreteAggregate(item);
        List<object> storage = new List<object>();
        foreach (List<object> i in container)
        {
            if (Convert.ToString(i[1].GetType()) == "System.Int32")
            {
                foreach (object j in i)
                {
                    if (!storage.Contains(j))
                    {
                        storage.Add(j);
                        Console.WriteLine(j);
                    }
                }
            }
            else
            {
                if (!storage.Contains(i[0]))
                {
                    storage.Add(i[0]);
                    Console.WriteLine(i[0]);
                }
                Algorithm((List<object>)i[1]);
            }
        }
    }
}
