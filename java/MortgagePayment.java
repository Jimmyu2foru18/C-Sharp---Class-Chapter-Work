package mortgagePayment; // Haseeb Arshad -- Mar 12, 2024
import java.util.Scanner;
import java.text.DecimalFormat;
public class MortgagePayment
{

	public static void main(String[] args) 
	{
        Scanner key = new Scanner(System.in);
        DecimalFormat dcml= new DecimalFormat("0.00%");
        System.out.print("Enter annual intrest rate (In decimal form): ");
        double ai = key.nextDouble();
        
        System.out.print("Enter the number of years the mortgage will be held: ");
        double mY = key.nextDouble();
        
        System.out.print("Enter the ammount of mortgage being borrowed: ");
        double mb = key.nextDouble();
        
        
        double MIR = ai/12;
        double aiP = ai * 100;
        double TA = mb*ai*mY;
        double OP = TA - mb;
        double OPP = mb/OP;
        double MP = (MIR * mb)/((1 - (Math.pow((1 + MIR), (-12 * mY)))));
        double MPF= Math.round(MP*100)/100;
        
        System.out.println("");
        System.out.println("Annual Intrest Rate: " + dcml.format(aiP));
        System.out.println("Mortgage Amount: $" + mb);
        System.out.println("Monthly Payment: $" + MP);
        System.out.println("Total amount payed over life of loan: $" + TA);
        System.out.println("Over Payment: " + OP);
        System.out.println("Over Payment as percentage of loan: " + OPP);
               
	}
}
