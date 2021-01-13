using System;
using System.Collections.Generic;
class ConcreteEnumerator : Enumerator
{
    public List<object> _Container;

    int position = -1;

    public ConcreteEnumerator(List<object> list)
    {
        _Container = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _Container.Count);
    }

    public void Reset()
    {
        position = -1;
    }

    object Enumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public object Current
    {
        get
        {
            try
            {
                return _Container[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
