string[] sourceArray = new string[7] {
                                    "I",
                                    "category",
                                    "love",
                                    "genetic",
                                    "c#",
                                    "outside",
                                    "included"                                    
};



//string[] sourceArray = GetSourceArray("Введите слова для анализа через пробел: ");
int numberOfCharacters = GetNumber("Введите максимальное количество символов в слове: ");

int wordsQuantity = LetsFindQuantity(sourceArray, numberOfCharacters);
string[] ResultArray = LetsFindWords(sourceArray, wordsQuantity, numberOfCharacters);
//проверка
Console.WriteLine($"количество элементов в исходном масииве => {wordsQuantity}");


//результат работы
PrintArray(ResultArray);

// найду количество слов меньше 3 символов
int LetsFindQuantity(string[] array, int maxLength){
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=maxLength) quantity++;
    }
    return quantity;
}

//выберу все слова, которые удовлетворяют условию в новый массив
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

// метод вывода массива в консоль
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//запрос на ввод слов от пользователя
string[] GetSourceArray(string systemMessage){
    Console.Write(systemMessage);

    string userInput = Console.ReadLine() ?? string.Empty;
    string[] sourceArray = userInput.Split(" ");
    return sourceArray;
}

//запрос на ввод числа у пользователя
int GetNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}