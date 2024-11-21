using System;

public class EventController
{
    public Action baseEvent;

    public void AddListener(Action listener) => baseEvent += listener;      //subscribing to event

    public void InvokeEvent() => baseEvent?.Invoke();                       //if base event isn't null, invoke event

    public void RemoveListener(Action listener) => baseEvent -= listener;   //unsubscribing the event
}
