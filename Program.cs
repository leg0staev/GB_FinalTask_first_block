string[] sourceArray = new string[7] {
                                    "to",
                                    "the",
                                    "love",
                                    "category",
                                    "task",
                                    "in",
                                    "out"
};
int wordsQuantity = LetsFindQuantity(sourceArray);
//test
Console.WriteLine($"количество элементов в исходном масииве => {wordsQuantity}");

// найду количество слов меньше 3 символов
int LetsFindQuantity(string[] array){
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3) quantity++;
    }
    return quantity;
};

//выберу все слова, которые удовлетворяют условию в новый массив
string[] LetsFindWords(string[] array, int newArrayLength){
    string[] resultArray = new string[newArrayLength];
    for (int i = 0; i < array.Length; i++){
        int newIndex = 0;
        if (array[i].Length <= 3) resultArray[newIndex] = array[i];
        newIndex++;
    }
    return resultArray;
}

//метод вывода массива в консоль
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}, ");
    }
};

