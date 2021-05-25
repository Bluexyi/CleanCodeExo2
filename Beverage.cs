public class Beverage
{
    private string size;
    private double costPetit = 2;
    private double costMoyen = 3;
    private double costGrand = 4;

    public Beverage(string size)
    {
        this.size = size;
    }

    public double cost()
    {
        if (size == "petit")
        {
            return costPetit;
        }
        else if (size == "moyen")
        {
            return costMoyen;
        }
        else if (size == "grand")
        {
            return costGrand;
        }

        return 0;
    }

    public string getSize()
    {
        return this.size;
    }
}