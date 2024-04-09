
class TrashStation
{
    List<Waste> wastes = new List<Waste>();

    public TrashStation() { }
    public TrashStation(List<Waste> wastes)
    {
        this.wastes = wastes;
    }

    public void AddWaste(Waste waste)
    {
        wastes.Add(waste);
    }

    public TrashStation OrderBySize()
    {
        return new TrashStation(wastes.OrderBy(waste => waste.Size).ToList());
    }

    public TrashStation SortBySize(double minsize)
    {
        return new TrashStation(wastes.Where(waste => waste.Size > minsize).ToList());
    }

    public TrashStation OrderByType()
    {
        return new TrashStation(wastes.OrderBy(waste => waste.Type).ToList());
    }

    public void Print()
    {
        foreach (Waste waste in wastes)
        {
            Console.WriteLine(waste.ToString());
        }
    }
}

