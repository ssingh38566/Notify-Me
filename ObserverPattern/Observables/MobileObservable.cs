namespace NotifyMe.Observables
{
    using System;
    using System.Collections.Generic;
    using NotifyMe.Observers;

    public class MobileObservable : INotifyObservable
    {
        List<INotificationAlertObserver> Observers;
        int StockCount = 0;

        public MobileObservable()
        {
            this.Observers = new List<INotificationAlertObserver>();
        }

        public void Add(INotificationAlertObserver obj)
        {
            this.Observers.Add(obj);
        }

        public void Remove(INotificationAlertObserver obj)
        {
            this.Observers.Remove(obj);
        }

        public void UpdateData()
        {
            this.StockCount = 10;
            this.Notify();
        }

        public void Notify()
        {
            foreach (var observer in this.Observers)
            {
                observer.Update();
            }
        }
    }
}
