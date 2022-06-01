// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PlusNum ()
{
    int result = 0;

    while (true){
    string num = Console.ReadLine(); 
    if (num == ""){
    break;}
    int a = int.Parse(num);
    
    if (a > 0)
    {
        result += 1;
    }   
    }
    Console.Write($"Ввели {result} чисел больше 0 ");
}

PlusNum();
