using System;
using System.Collections.Generic;
public interface Enumerator
{
    public object Current { get; }
    public abstract bool MoveNext();
    public abstract void Reset();
}
