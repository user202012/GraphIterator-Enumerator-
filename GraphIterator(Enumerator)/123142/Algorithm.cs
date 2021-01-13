using System;
using System.Collections.Generic;
public class Algorithm
{
    private IAlgorithm algoritm;

    public Algorithm(IAlgorithm algorithm)
    {
        algoritm = algorithm;
    }
    public void Start(List<object> item)
    {
        algoritm.Algorithm(item);
    }
}
