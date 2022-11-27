string[] sourceArray = new string[7] {
                                    "to",
                                    "the",
                                    "love",
                                    "category",
                                    "task",
                                    "in",
                                    "out"
};

// найду количество слов меньше 3 символов
int LetsFind(string[] array){
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3) quantity++;
    }
    return quantity;
};

//test
Console.WriteLine($"количество элементов в исходном масииве => {LetsFind(sourceArray)}");