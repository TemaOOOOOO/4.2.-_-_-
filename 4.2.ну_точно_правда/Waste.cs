public class Waste
{
	public double Size { get; set; }
	public string Type { get; set; }

	public Waste(double size, string type)
	{
		Size = size;
		Type = type;
	}

	public override string ToString()
	{
		return $"Type: {Type}, Size: {Size}";
	}
}

public class Plastic : Waste
{
	public Plastic(double size) : base(size, "plastic") { }
}

public class Metal : Waste
{
	public Metal(double size) : base(size, "metal") { }
}

public class Paper : Waste
{
	public Paper(double size) : base(size, "paper") { }
}

public class Glass : Waste
{
	public Glass(double size) : base(size, "glass") { }
}

public class Organic : Waste
{
	public Organic(double size) : base(size, "organic") { }
}
