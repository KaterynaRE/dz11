using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace dz11
{
	internal class Program
	{

		static bool IsPrime(int number)
		{
			if (number <= 1)
			{
				return false;
			}

			for (int i = 2; i * i <= number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}

			return true;
		}

		static bool IsFibonacci(int number)
		{
			int a = 0, b = 1;
			while (b < number)
			{
				int temp = a;
				a = b;
				b = temp + b;
			}

			return b == number;
		}

		static void Main(string[] args)
		{
			//			Завдання 1:
			//Додаток генерує 100 цілих чисел. Збережіть в один файл усі
			//прості числа, в інший файл усі числа Фібоначчі. Статистику роботи
			//додатку виведіть на екран.

			//List<int> primeNumbers = new List<int>();
			//List<int> fibonacciNumbers = new List<int>();

			//int countFib = 0;
			//int countPrime = 0;

			//const int size = 30;
			//int[] arr = new int[size];
			//Random random = new Random();
			//for (int i = 0; i < size; i++)
			//{
			//	arr[i] = random.Next(40);
			//}
			//Array.Sort(arr);

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + " ");
			//}

			//foreach (int num in arr)
			//{
			//	bool isPrime = IsPrime(num);
			//	if (isPrime)
			//	{
			//		primeNumbers.Add(num);
			//		countPrime++;
			//	}

			//	bool isFibonacci = IsFibonacci(num);
			//	if (isFibonacci)
			//	{
			//		fibonacciNumbers.Add(num);
			//		countFib++;
			//	}
			//}

			//using (StreamWriter swPrime = new StreamWriter("zav1IsPrime.txt", false))
			//{
			//	foreach (int prime in primeNumbers)
			//	{
			//		swPrime.WriteLine(prime);
			//	}
			//}

			//using (StreamWriter swFib = new StreamWriter("zav1Fibonacci.txt", false))
			//{
			//	foreach (int fib in fibonacciNumbers)
			//	{
			//		swFib.WriteLine(fib);
			//	}
			//}

			//Console.WriteLine($"\nCount numbers is Fibonacci: {countFib}");
			//Console.WriteLine($"\nCount numbers is prime: {countPrime}");


			//			Завдання 2:
			//Користувач вводить з клавіатури слово для пошуку у файлі і слово для заміни.
			//Додаток має змінити усі входження шуканого слова на слово для заміни.
			////Статистику роботи додатку виведіть на екран.


			//using (StreamWriter sw2 = new StreamWriter("zav2.txt", false))
			//{
			//	sw2.WriteLine("The user enters a word from the keyboard to search in the file and word to replace." +
			//		" The application must replace all occurrences of the search term word by word for replacement.");
			//}

			//string line;
			//using (StreamReader st2 = new StreamReader("zav2.txt"))
			//{
			//	line = st2.ReadToEnd();
			//	Console.WriteLine(line);
			//}

			//Console.WriteLine("Enter word for find: ");
			//string wordUserSerch = Console.ReadLine();

			//Console.WriteLine("Enter word for replacement: ");
			//string wordUserReplace = Console.ReadLine();

			//int countReplace = 0;

			//line = line.Replace(wordUserSerch, wordUserReplace);

			//using (StreamWriter sw2 = new StreamWriter("zav2.txt", false))
			//{
			//	sw2.WriteLine(line);
			//}

			//using (StreamReader st2 = new StreamReader("zav2.txt"))
			//{
			//	line = st2.ReadToEnd();
			//	string[] words = line.ToLower().Split(new char[] { ' ', '.', ',' });

			//	foreach (string w in words)
			//	{
			//		if (w == wordUserReplace.ToLower())
			//		{
			//			countReplace++;
			//		}
			//	}
			//}
			//Console.WriteLine($"Count replace word: {countReplace}");


			//			Завдання 3:
			//Створіть додаток «Модератор». Користувач вводить шлях до файлу з текстом і до файлу зі словами для модерації.
			//За підсумками роботи додатка, всі слова для модерації у початковому файлі мають бути замінені на "*".
			//Наприклад, файл зі словами для модерації:
			//car telephone
			//Файл з текстом:
			//test best rest car
			//man telephone
			//Результат:
			//test best rest***
			//man * ********


			//using (StreamWriter sw = new StreamWriter("zav3Text.txt", false))
			//{
			//	sw.WriteLine("test best rest car man telephone");
			//}
			//using (StreamWriter sw = new StreamWriter("zav3moderatia.txt", false))
			//{
			//	sw.WriteLine("car telephone");
			//}

			//Console.WriteLine("Enter path to file txt: ");
			//string pathTxt = Console.ReadLine();

			//Console.WriteLine("Enter path to file moderation: ");
			//string pathModerat = Console.ReadLine();

			//string lineText;
			//Console.WriteLine("\nText before moderation: \n");
			//using (StreamReader stT = new StreamReader(pathTxt))
			//{
			//	lineText = stT.ReadToEnd();
			//	Console.WriteLine(lineText);
			//}

			//Console.WriteLine("Words for replace: \n");
			//string lineModerat;
			//using (StreamReader stM = new StreamReader(pathModerat))
			//{
			//	lineModerat = stM.ReadToEnd();
			//	Console.WriteLine(lineModerat);
			//}

			//string[] wordsToReplace = lineModerat.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //відкидає порожні ел після розділення

			//foreach (string word in wordsToReplace)
			//{
			//	string replaceString = new string('*', word.Length);
			//	lineText = lineText.Replace(word, replaceString);
			//}

			//using (StreamWriter sw = new StreamWriter("zav3Text.txt", false))
			//{
			//	sw.WriteLine(lineText);
			//}

			//Console.WriteLine("Text after moderation: \n");
			//using (StreamReader stT = new StreamReader("zav3Text.txt"))
			//{
			//	lineText = stT.ReadToEnd();
			//	Console.WriteLine(lineText);
			//}


			//			Завдання 4:
			//Користувач вводить шлях до файлу.Додаток має перевернути
			//вміст файлу і утворити новий файл.


			//using (StreamWriter sw = new StreamWriter("zav4.txt", false))
			//{
			//	sw.WriteLine("test best rest car man telephone");
			//}

			//using (StreamReader st = new StreamReader("zav4.txt"))
			//{
			//	string line = st.ReadToEnd();
			//	Console.WriteLine(line);
			//}

			//Console.WriteLine("\nEnter path to file txt: \n");
			//string pathTxt = Console.ReadLine();

			//if (File.Exists(pathTxt))
			//{
			//	string lineRev;
			//	using (StreamReader stR = new StreamReader(pathTxt))
			//	{
			//		lineRev = stR.ReadToEnd();
			//	}

			//	string[] lineRev1 = lineRev.Split(new[] { ' ' });
			//	for (int i = 0; i < lineRev1.Length; i++)
			//	{
			//		char[] lineRevNew1 = lineRev1[i].ToCharArray();
			//		Array.Reverse(lineRevNew1);
			//		lineRev1[i] = new string(lineRevNew1);
			//	}

			//	string lineRevNew = string.Join(" ", lineRev1);

			//	using (StreamWriter swNew = new StreamWriter("zav4New.txt", false))
			//	{
			//		swNew.WriteLine(lineRevNew);
			//	}

			//	Console.WriteLine("\nText in file reverse: \n");
			//	using (StreamReader stNew = new StreamReader("zav4New.txt"))
			//	{
			//		string lineNewRev = stNew.ReadToEnd();
			//		Console.WriteLine(lineNewRev);
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("File not found.");
			//}



			//			Завдання 5:
			//Файл містить 100000 цілих чисел. Додаток має проаналізувати файл і відобразити статистику по ньому:
			//1.Кількість додатних чисел.
			//2.Кількість від'ємних чисел.
			//3.Кількість двозначних чисел.
			//4.Кількість п'ятизначних чисел.
			//Крім того, додаток має створити файли з цими числами(додатні,
			//від'ємні і т. д.)

			const int size = 250;
			int[] arr = new int[size];
			Random random = new Random();

			for (int i = 0; i < size; i++)
			{
				arr[i] = random.Next(-50, 1000);
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();

			using (StreamWriter sw = new StreamWriter("zav5.txt", false))
			{
				for (int i = 0; i < size; i++)
				{
					sw.WriteLine(arr[i]);
				}
			}

			int countPositive = 0;
			int countnegative = 0;
			int countTwoDigit = 0;
			int countFiveDigit = 0;

			using (StreamWriter positive = new StreamWriter("zav5Poz.txt", false))
			using (StreamWriter negative = new StreamWriter("zav5negat.txt", false))
			using (StreamWriter twoDigit = new StreamWriter("zav5twoDigit.txt", false))
			using (StreamWriter fiveDigit = new StreamWriter("zav5FiveDigit.txt", false))
			{
				for (int i = 0; i < size; i++)
				{
					if (arr[i] > 0)
					{
						countPositive++;
						positive.WriteLine(arr[i]);
					}
					else if (arr[i] < 0)
					{
						countnegative++;
						negative.WriteLine(arr[i]);
					}
					if (arr[i] > 10 && arr[i] < 99)
					{
						countTwoDigit++;
						twoDigit.WriteLine(arr[i]);
					}
					if (arr[i] > 9999 && arr[i] < 99999)
					{
						countFiveDigit++;
						fiveDigit.WriteLine(arr[i]);
					}
				}
			}
			Console.WriteLine($"Count positive digit: {countPositive}\n");
			Console.WriteLine($"Count negative digit: {countnegative}\n");
			Console.WriteLine($"Count two-digit: {countTwoDigit}\n");
			Console.WriteLine($"Count five-digit: {countFiveDigit}\n");

		}
	}
}
