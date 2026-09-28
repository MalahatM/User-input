
//uppgift 1 Area Calculator
// Circle
Console.WriteLine("Enter the radius of the circle:");
double radius = Convert.ToDouble(Console.ReadLine());

Circle circle = new Circle(radius);

Console.WriteLine($"Circle area: {circle.CalculateArea()}");


// Rectangle
Console.WriteLine("Enter the width of the rectangle:");
double width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the height of the rectangle:");
double height = Convert.ToDouble(Console.ReadLine());

Rectangle rectangle = new Rectangle(width, height);

Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");


// Square
Console.WriteLine("Enter the side of the square:");
double side = Convert.ToDouble(Console.ReadLine());

Square square = new Square(side);

Console.WriteLine($"Square area: {square.CalculateArea()}");



//uppgift 2 Bank Account
BankAccount account = new BankAccount();
Console.WriteLine("How much money do you want to deposit?");
double depositAmount = Convert.ToDouble(Console.ReadLine());
account.Balance += depositAmount;
Console.WriteLine($"Your current balance is: {account.Balance}");

//uppgift 3 AI

Console.WriteLine("Ask the AI a question:");
string question = Console.ReadLine()!;
List<string> answers = new List<string>
{
	"Yes, definitely.",
	"No, I don't think so.",
	"Maybe, it's hard to say.",
	"Absolutely!",
	"I wouldn't count on it.",
	"It's possible, but not certain."
};
Random random = new Random();
string answer = answers[random.Next(answers.Count)];
Console.WriteLine($"AI's answer: {answer}");

//uppgift 4  Miniräknaren
Console.WriteLine("Enter the first number:");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number:");
double num2 = Convert.ToDouble(Console.ReadLine());
//addition
double addition = num1 + num2;
Console.WriteLine($"Addition: {addition}");
//subtraction
double subtraction = num1 - num2;
Console.WriteLine($"Subtraction: {subtraction}");
//multiplication
double multiplication = num1 * num2;
Console.WriteLine($"Multiplication: {multiplication}");
//division
double division = num1 / num2;
Console.WriteLine($"Division: {division}");