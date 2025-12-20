using System;

class PenDistribution{
	
	static void Main(){
		int numberOfPen = 14;
		int equallyDistributedPen = numberOfPen/3;
		int remainingPens = numberOfPen%3;
		
		Console.WriteLine("The Pen Per Student is " + equallyDistributedPen + " and the remaining pen not distributed is " + remainingPens);	
	}
	
}