using System;
using System.Collections.Generic;
class ConcreteAggregate : Aggregate
{

    private List<object> _Container;
    public ConcreteAggregate(List<object> array)
    {
        _Container = new List<object>();
        
        foreach (var i in array)
        {
            _Container = array;
        }
    }

    Enumerator Aggregate.GetEnumerator()
    {
        return (Enumerator)GetEnumerator();
    }

    public ConcreteEnumerator GetEnumerator()
    {
        return new ConcreteEnumerator(_Container);
    }
}
