using System;
class MainClass
{
    public static void Main(string[] args)
    {
		/*
				//(string name, int age) anketa;
				(string name, int age) = ("Yosef", 74);
				Console.WriteLine("Ваше имя: {0}", name);
				Console.WriteLine("Ваш возраст: {0}", age);
				Console.Write("Введите имя: ");
				name = Console.ReadLine();
				Console.Write("Введите возраст с цифрами: ");
				age = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ваше имя: {0}", name);
				Console.WriteLine("Ваш возраст: {0}", age);
		Console.ReadKey();
*/

		(string Name, string SurName, string Login, double Age, int LoginCount, bool Pet, string[] FavColors) User;
		User.FavColors = new string[3];
		for (int i = 0; i < 3; i++)
		{
			Console.WriteLine("Введите ваше имя:");
			User.Name = Console.ReadLine();
			Console.WriteLine("Введите вашу фамилию:");
			User.SurName = Console.ReadLine();
			Console.WriteLine("Введите ваш возраст цифрами:");
			User.Age = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите Ваш пароль:");
			User.Login = Console.ReadLine();
			User.LoginCount = User.Login.Count();
			Console.WriteLine("Есть ли у Вас животное? Введите да или нет:");
			string Pets = Console.ReadLine();
			switch (Pets)
			{
				case "да":
				case "yes":
				case "Yes":
				case "Да":
					User.Pet = true;
					break;
				case "нет":
				case "no":
				case "No":
				case "Нет":
					User.Pet = false;
					break;
				default:
					User.Pet = false;
					break;
			}
			Console.WriteLine("Введите ваш любимый цвет 1:");
			User.FavColors[0] = Console.ReadLine();
			Console.WriteLine("Введите ваш любимый цвет 2:");
			User.FavColors[1] = Console.ReadLine();
			Console.WriteLine("Введите ваш любимый цвет 3:");
			User.FavColors[2] = Console.ReadLine();

			Console.WriteLine("Ваше имя: {0}", User.Name);
			Console.WriteLine("Ваша фамилия: {0}", User.Age);
			Console.WriteLine("Есть ли у Вас питомец ответ: {0}", User.Pet);
			Console.WriteLine("Количество символов в Вашем пароле: {0}", User.LoginCount);
			Console.WriteLine("Ваш пароль: {0}", User.Login);
			Console.WriteLine("Ваш любимый цвет номер 1: {0}", User.FavColors[0]);
			Console.WriteLine("Ваш любимый цвет номер 2: {0}", User.FavColors[1]);
			Console.WriteLine("Ваш любимый цвет номер 3: {0}", User.FavColors[2]);
		}



		Console.ReadKey();

	}
}
