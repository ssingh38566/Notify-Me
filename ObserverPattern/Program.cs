// See https://aka.ms/new-console-template for more information
using NotifyMe.Observers;
using NotifyMe.Observables;

Console.WriteLine("Hello, World!");

INotifyObservable mobileObservable = new MobileObservable();

INotificationAlertObserver observer1 = new EmailAlertObserver(mobileObservable);
INotificationAlertObserver observer2 = new EmailAlertObserver(mobileObservable);
INotificationAlertObserver observer3 = new EmailAlertObserver(mobileObservable);

mobileObservable.Add(observer1);
mobileObservable.Add(observer2);
mobileObservable.Add(observer3);


mobileObservable.UpdateData();

Console.ReadLine();

