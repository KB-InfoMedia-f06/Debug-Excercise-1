/* abascus
 * 
 * takes numbers until user dont want to enter more
 * sums all numbers togeheter
 * 
 */
class Program {
    public Main(string[] args) {
        bool pressedContinue = true;
        int sum = 0;


        Console.WriteLine("enter a number");
        int input = Convert.ToInt32(console.ReadLine())
        sum += input;

        while (presedContinue) {
            Console.WriteLine("add another number");
            input = Convert.ToInt32(Console,ReadLine());
            summa += input;
            Console.WriteLine("do yo want to add more numbers? [Y/N]");
            response = Console.ReadLine();
            if(response == "N") {
                pressedContinue == false;
            }
        }

        Console.WriteLine($"The total sum is: {sum}");
    }
