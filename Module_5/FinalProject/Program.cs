using System.Reflection.Emit;

namespace FinalProject
{
    internal class Program
    {
        //Метод ввода всех данных
       
        static (string name, string surName, int age, bool hasPets, string[] petsNames, string[] favColors) DataIn()
        {
            (string name, string surName, int age, bool hasPets, string[] petsNames, string[] favColors) user=("","",0,true,null,null);
            //Имя
            Console.Write("Введите Ваше Имя: ");
            user.name = Console.ReadLine();
           
                //Фамилия
            Console.Write("Введите Вашу Фамилию: ");
            user.surName = Console.ReadLine();
                //Возраст
                Label1:
            Console.Write("Введите Ваш возраст: ");
            bool checkAge=int.TryParse(Console.ReadLine(), out user.age);
            if (checkAge==false)
            {
                goto Label1;
            }
            if (user.age <= 0)
            {
                goto Label1;
            }
                
                //Наличие питомца
                Label4:
            Console.Write("Имеется домашнее животное (да/нет): ");
            string hasPetQuestion=Console.ReadLine();
            if (hasPetQuestion=="да")
            {
                int petsCount;
                user.hasPets = true;
            Label2:
                Console.Write("Кол-во питомцев: ");
                bool checkPets = int.TryParse(Console.ReadLine(),out petsCount);
                if (checkPets)
                {
                    if (petsCount <= 0)
                    {
                        goto Label2;
                    }
                    user.petsNames = new string[petsCount];
                    for (int i = 0; i < user.petsNames.Length; i++)
                    {
                    Console.Write($"Имя питомца №{i+1}: ");
                    user.petsNames[i] = Console.ReadLine();
                    }
                }
                else
                {  
                    goto Label2;
                }   
            }
            else if (hasPetQuestion == "нет")
            {
                user.hasPets =false;
                Console.WriteLine("Нет домашних животных");
            }
            else
            {
                goto Label4;
            }
            
                
                //Любимые цвета
                Label3:
            Console.Write("Введите кол-во любимых цветов: ");
            int countColors;
            bool checkColors = int.TryParse(Console.ReadLine(), out countColors);
            if(checkColors==false)
            {     
                goto Label3;
            }
            if (countColors > 0)
            {
                user.favColors = new string[countColors];
                for (int i = 0; i < user.favColors.Length; i++)
                {
                    Console.Write($"Цвет №{i + 1}: ");
                    user.favColors[i] = Console.ReadLine();
                }
            }
            else if (countColors==0)
            {
                Console.WriteLine("Нет любимых цветов...");
            }
            else
            {
                goto Label3;
            }
            return user;
        }
        //Метод вывода всех данных
        static void ShowUser((string name, string surName, int age, bool hasPets, string[]petsNames, string[]favColors)user)
        {   
            Console.WriteLine("*************************************************************\n");
            Console.WriteLine($"Полное имя: {user.surName} {user.name}\nВозраст: {user.age}");
            string hasPetAnswer;
            if (user.hasPets == true)
            {
                hasPetAnswer = "да";
            }
            else
            {
                hasPetAnswer = "нет";
            }
            Console.WriteLine($"Наличие домашних животных: {hasPetAnswer}");
            if (user.hasPets==true)
            {
                Console.Write($"{user.petsNames.Length} домашних животных: ");
                for (int i=0;i<user.petsNames.Length;i++)
                {
                    Console.Write($"{user.petsNames[i]} ");
                }
            }
            if (user.favColors==null)
            {
                Console.WriteLine("\nНет любимых цветов");
            }
            else
            {
                Console.Write("\nЛюбимые цвета: ");
                for(int i = 0; i < user.favColors.Length; i++)
                {
                    Console.Write($"{user.favColors[i]} ");
                }
            }
            Console.WriteLine("\n*************************************************************");
        }

        static void Main(string[] args)
        {
            
            var User = DataIn();
            Console.ReadKey();
            Console.Clear();

            ShowUser(User);

            Console.ReadKey();
        }

        
    }
}
