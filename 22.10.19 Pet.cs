using System;

namespace ConsoleApp3
{
	public enum DisplayType
	{
		Short, Full
	}
	public enum PetKind
	{
		Cat, Dog
	}

	public class Pet
	{
		public PetKind Kind;
		public string Name;
		public char Sex;
		public DateTime DateOfBirth;

		public byte GetAge()
		{
			TimeSpan difference = DateTime.Now - DateOfBirth;
			return (byte)Math.Floor(difference.TotalDays / 365);
		}

		public Pet(string name, PetKind kind)
		{
			Name = name;
			Kind = kind;
		}
		
		public void Display(bool DisplayShort)
		{
			if (DisplayShort)
			{
				Console.WriteLine(ShortDescription);
			}
			else
			Console.WriteLine(Description);
		}

		public string ShortDescription
		{
			get
			{
				return $"{Name} is a {Kind}";
			}
		}

		public string Description //readonly свойство
		{
			get
			{
				return $"{Name} is a {Kind} it has {Sex} age {GetAge()}";
			}
		}

		public void UpdateDateOfBirth(DateTime dateTime)
		{
			DateOfBirth = dateTime;
		}

		public void Update(string name)
		{
			Name = name;
		}
	}
}
