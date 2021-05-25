public class Formule
{
    private string typeFormule;
    private string typeMeal;
    private double costStandardAssiette = 18;
    private double costStandardSandwich = 13;
    private double costMaxAssiette = 21;
    private double costMaxSandwich = 16;


    public Formule(string typeFormule, string typeMeal)
    {
        this.typeFormule = typeFormule;
        this.typeMeal = typeMeal;
    }

    public double cost()
    {
        if (typeFormule == "standard")
        {
            if (typeMeal == "assiette")
            {
                return costStandardAssiette;
            }
            else
            {
                return costStandardSandwich;
            }
        }
        else
        {
            if (typeMeal == "assiette")
            {
                return costMaxAssiette;
            }
            else
            {
                return costMaxSandwich;
            }
        }
    }

    public string getTypeFormule()
    {
        return this.typeFormule;
    }

    public string getTypeMeal()
    {
        return this.typeMeal;
    }

}