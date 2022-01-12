# fibonacci-sample

## Run in your console (need netcore dotnet)

```ps
dotnet run .
```

## Code

```cs
public void PrintFibonacci(int steps)
{
    int currentNumber = 0;
    int latsNumber = 0;
    int aux = 0;
    string message = "";

    for(int i = 0; i < steps; i++)
    {
        if(i == 1)
        {
            currentNumber = 1;
            latsNumber = 0;
        }
        if(i > 1)
        {
            aux = latsNumber;
            latsNumber = currentNumber;
            currentNumber = aux + latsNumber;
        }
        message = CurrentMessage(i + 1);
        if(currentNumber > 0) Console.WriteLine(RepeatMessage(message, currentNumber));
    }
}
```
        
## Output

```ps
Fizz
Buzz
FizzFizz
BuzzBuzzBuzz
FizzFizzFizzFizzFizz
BuzzBuzzBuzzBuzzBuzzBuzzBuzzBuzz
```
