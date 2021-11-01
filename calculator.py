useAgain = True

while(useAgain):
    num1 = int(input("Enter number 1: "))
    num2 = int(input("Enter number 2: "))

    print("+ | Plus")
    print("- | Minus")
    print("* | Multiply")
    print("/ | Divide")
    option = input("Enter an option: ")

    if option == "+":
        result = num1 + num2
        print(str(num1) + "+" + str(num2) + " is: " + str(result))
    elif option == "-":
        result = num1 - num2
        print(str(num1) + "-" + str(num2) + " is: " + str(result))
    elif option == "*":
        result = num1 * num2
        print(str(num1) + "*" + str(num2) + " is: " + str(result))
    elif option == "-":
        result = num1 / num2
        print(str(num1) + "/" + str(num2) + " is: " + str(result))

    response = input("Would you like to use again? [Y/N]")

    if response == "Y":
        useAgain = True
    elif response == "N":
        useAgain = False
