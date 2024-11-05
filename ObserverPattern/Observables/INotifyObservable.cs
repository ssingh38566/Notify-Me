namespace NotifyMe.Observables
{
	using System;
	using NotifyMe.Observers;

	public interface INotifyObservable
	{
		public void Add(INotificationAlertObserver obj);

		public void Remove(INotificationAlertObserver obj);

		public void Notify();

		public void UpdateData();
	}
}
