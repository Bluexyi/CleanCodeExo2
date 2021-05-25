public class Meal
{
    private string type;
    private double costAssiette = 15;
    private double costSandwich = 10;

    public Meal(string type)
    {
        this.type = type;
    }

    public double cost()
    {
        if (type == "assiette")
        {
            return costAssiette;
        }
        else
        {
            return costSandwich;
        }
    }

    public string getType()
    {
        return this.type;
    }
}
