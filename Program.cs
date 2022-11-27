Console.WriteLine("Здравствуйте! введите несколько слов и я выведу только те, которые меньше заданного количества букв!");
string[] sourceArray = GetSourceArray("Введите слова для анализа через пробел: ");
int numberOfCharacters = GetNumber("Введите максимальное количество букв в слове: ");

int wordsQuantity = LetsFindQuantity(sourceArray, numberOfCharacters);
string[] ResultArray = LetsFindWords(sourceArray, wordsQuantity, numberOfCharacters);

PrintArray(ResultArray);


int LetsFindQuantity(string[] array, int maxLength){
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=maxLength) quantity++;
    }
    return quantity;
}


string[] LetsFindWords(string[] array, int newArrayLength, int maxLength){
    string[] resultArray = new string[newArrayLength];
    int newIndex = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= maxLength){
            resultArray[newIndex] = array[i];
            newIndex++;
        }
    }
    return resultArray;
}



void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


string[] GetSourceArray(string systemMessage){
    Console.Write(systemMessage);

    string userInput = Console.ReadLine() ?? string.Empty;
    string[] sourceArray = userInput.Split(" ");
    return sourceArray;
}


int GetNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}