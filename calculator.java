import java.util.Scanner;

public class Main {

    public static void main (String[] args) {

        Scanner scanner = new Scanner(System.in);

        //variables
        double num1;
        double num2;
        String option;
        double result;
        boolean useAgain = true;
        String response;

        while(useAgain) {
            response = "";
            result = 0;

            System.out.println("Enter number 1:");
            num1 = scanner.nextDouble();

            System.out.println("Enter number 2:");
            num2 = scanner.nextDouble();

            System.out.println("Enter an option: ");
            System.out.println("+ | Plus");
            System.out.println("- | Minus");
            System.out.println("* | Multiply");
            System.out.println("/ | Divide");

            option = scanner.next();

            switch (option) {
                case "+": result = num1 + num2;
                System.out.println(num1 + " + " + num2 + " is: " + result);
                break;
                case "-": result = num1 - num2;
                System.out.println(num1 + " - " + num2 + " is: " + result);
                break;
                case "*": result = num1 * num2;
                System.out.println(num1 + " * " + num2 + " is: " + result);
                break;
                case "/": result = num1 / num2;
                System.out.println(num1 + " / " + num2 + " is: " + result);
                break;
            }

            // when finished ask user if they would like to use again
            System.out.println("Would you like to use Again? [Y/N]");
            response = scanner.next();

            if (response.equals("Y")) {
                useAgain = true;
            }
            else if (response.equals("N")) {
                useAgain = false;
            }
        }
    }
}
