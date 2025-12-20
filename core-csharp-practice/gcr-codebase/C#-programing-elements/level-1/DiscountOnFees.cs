using System;

class DiscountOnFees{

	static void Main(){
		
		int fee = 125000;
		int discountPercent = 10;
		int discount = fee/discountPercent;
		int discountedFee = fee - discount;
		Console.WriteLine("The discount amount is INR" + discount +" and the final discounted fee is INR" + discountedFee);
		
	}

}