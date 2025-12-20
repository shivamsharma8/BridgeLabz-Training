using System;

class ProfitPercentage{
	
	static void Main(){
		
		int costPrice = 129;
		int sellingPrice = 191;
		
		int profit = sellingPrice - costPrice;		
		float profitpercent = (float) ((profit/costPrice)*100);
		
		Console.WriteLine("The Cost Price is INR" + costPrice + " and Selling Price is INR" + sellingPrice);
		Console.WriteLine("The Profit is INR" + profit + " and the Profit Percentage is "+ profitpercent);
		
	}
	
}