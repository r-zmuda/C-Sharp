using System;

public class Rectangle
{
	//Initalize
	private float length = 1;
	private float width = 1;
	private float area;
	private float perimeter;
	
	//Properties
	public float Length {
		get
		{
			return length;
		}
		set
		{
			if (value >= 0 && value <= 20)
			{
				length = value;
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(value), value,
					$"{nameof(Length)} must be greater than 0 and less than 20.");
			}
		}
	}
	public float Width
	{
		get
		{
			return width;
		}
		set
		{
			if (value >= 0 && value <= 20)
			{
				width = value;
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(value), value,
					$"{nameof(Width)} must be greater than 0 and less than 20.");
			}
		}
	}

	public float Area
	{
		get
		{
			area = Length * Width;
			return area;
		}
		private set
		{
		}
	}

	public float Perimeter
	{
		get
		{
			perimeter = 2 * (Length + Width);
			return perimeter;
		}
		private set
		{
		}
	}
}
