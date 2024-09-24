int num1;
int num2;
int result;
char type;
bool invalidType = false;

Console.WriteLine("Enter your first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Would you like to add (+), subtract (-), multiply (*), or divide (/) these two numbers?");
type = Convert.ToChar(Console.ReadLine());

switch (type)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
    default:
        invalidType = true;
        result = 0;
        break;
}

if (invalidType)
{
    Console.WriteLine("Invalid math type " + type + ".");
}
else
{
    Console.WriteLine("Your calculation is:\n" + num1 + " " + type + " " + num2 + " = " + result + ".");
}
