// string[] sourceArray = new string[7] {
//                                     "I",
//                                     "category",
//                                     "love",
//                                     "genetic",
//                                     "c#",
//                                     "outside",
//                                     "included"                                    
// };



string[] sourceArray = GetSourceArray("Введите слова для анализа через пробел: ");

int wordsQuantity = LetsFindQuantity(sourceArray);
string[] ResultArray = LetsFindWords(sourceArray, wordsQuantity);
//test
Console.WriteLine($"количество элементов в исходном масииве => {wordsQuantity}");
PrintArray(ResultArray);

// найду количество слов меньше 3 символов
int LetsFindQuantity(string[] array){
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=4) quantity++;
    }
    return quantity;
}

//выберу все слова, которые удовлетворяют условию в новый массив
string[] LetsFindWords(string[] array, int newArrayLength){
    string[] resultArray = new string[newArrayLength];
    int newIndex = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 4){
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

//вывод запроса на ввод слов от пользователя
string[] GetSourceArray(string systemMessage){
    Console.Write(systemMessage);

    string userInput = Console.ReadLine() ?? string.Empty;
    string[] sourceArray = userInput.Split(" ");
    return sourceArray;
}