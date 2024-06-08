﻿namespace Observer;

internal interface ISubject
{
    void Attach(IObserver observer);

    void Detach(IObserver observer);

    void Notify();
}
