namespace NotifyMe.Observers
{
    using System;
    using System.Collections.Generic;
    using NotifyMe.Observables;

    public class EmailAlertObserver : INotificationAlertObserver
    {
        private string EmailId = "ssingh3856@gmail.com";
        private INotifyObservable _notifyObservable;

        public EmailAlertObserver(INotifyObservable notifyObservable)
        {
            _notifyObservable = notifyObservable;
        }

        public void Update()
        {
            this.SendMessage();
        }

        private void SendMessage()
        {
            Console.WriteLine("Product restocked");
        }
    }
}
