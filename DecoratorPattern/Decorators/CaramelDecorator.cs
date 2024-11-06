namespace NotifyMe.Components
{
	using System;
	public class CaramelDecorator : BeverageDecorator
	{
		public CaramelDecorator(Beverage beverage) : base(beverage) { }	

		public override string GetDesc()
		{
			string desc = base.GetDesc();
			return desc + " with extra Caramel";
		}		
	}
}
