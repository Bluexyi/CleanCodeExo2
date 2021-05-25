public class Dessert
{
    private string type;
    private double costNormal = 2;
    private double costSpecial = 4;

    public Dessert(string type)
    {
        this.type = type;
    }

    public double cost()
    {
        if (type == "normal")
        {
            return costNormal;
        }
        else if (type == "special")
        {
            return costSpecial;
        }

        return 0;
    }

    public string getType()
    {
        return this.type;
    }
}