// See https://aka.ms/new-console-template for more information

//String Manipulation
string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog." };

//concatenates the words into a single string
var phrase = string.Concat(words);
System.Console.WriteLine(phrase);

//joins the words into a single string
var phrase2 = string.Join("",words);
System.Console.WriteLine(phrase2);


//LOOPS 
//loop - int arithmetic 
int[] numberArray = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};

int[] squareNumbers = new int[numberArray.Length];

for (var counter=0; counter < numberArray.Length; counter++)
    {
    squareNumbers[counter]=(numberArray[counter] * numberArray[counter]);
    }

//Select(LINQ) - int arithmetic

int[] squareNumbers2 = numberArray.Select(number => number*number).ToArray<int>();

//Filter 

int[] evenNumbers = new int[numberArray.Length ];
//loop method 
for (var counter=0; counter < numberArray.Length; counter++){
    if (numberArray[counter] %2 == 0){
        evenNumbers[counter]=(numberArray[counter]);
    }
}

//filter method
int[] evenNumbers2 = numberArray.Where(number => number%2==0).ToArray<int>();

// Accumulation  

//for version
var sum = 0;
for (var counter=0; counter < numberArray.Length; counter++){
     sum += numberArray[counter];
}
Console.WriteLine(sum);

//Aggregate (LINQ) method
var sum2 = numberArray.Aggregate((a,b) => a+b);
Console.WriteLine(sum2);

//structs

//lambda expressions