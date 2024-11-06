namespace NotifyMe.Components
{
	using System;
	public abstract class BeverageDecorator : Beverage
	{
		private Beverage _beverage;

		public BeverageDecorator(Beverage beverage)
		{
			_beverage = beverage;
		}
		public virtual string GetDesc()
		{
			return _beverage.GetDesc();
		}		
	}
}
