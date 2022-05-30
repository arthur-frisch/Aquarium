public class Poisson
{

	protected string name;
	protected string sexe;
	public Poisson(string _name, string _sexe)
	{
		name = _name;
		sexe = _sexe;
	}
	public virtual void affiche()
    {
		Console.WriteLine("Nom : " + name + " | Sexe : " + sexe);
    }


	public virtual void mange(Aquarium aquarium, Poisson poisson)
    {
		Console.WriteLine("Il mange");
    }
	
	public string getName()
    {
		return name;
    }
}

public class Poisson_herbivore : Poisson
{
	private string race;
	public Poisson_herbivore(string name, string sexe, string _race) : base(name, sexe)
    {
		race = _race;
    }

	public override void affiche()
    {
		Console.WriteLine("Nom : " + name + " | Sexe : " + sexe + " | race : " + race + " | Régime : herbivore");
	}

	public override void mange(Aquarium aquarium, Poisson poisson)
    {
		if (aquarium.getNbListAlgue() > 0)
		{
			Console.WriteLine(this.getName() + " a mangé une algue !");
			aquarium.remove_algue();
		}
		else Console.WriteLine(this.getName() + " n'a pas put manger d'algue !");
    }
	
}

public class Poisson_carnivore : Poisson
{
	private string race;
	public Poisson_carnivore(string name, string sexe, string _race) : base(name, sexe)
	{
		race = _race;
	}

	public override void affiche()
	{
		Console.WriteLine("Nom : " + name + " | Sexe : " + sexe + " | race : " + race + " | Régime : carnivore");
	}

	public override void mange(Aquarium aquarium, Poisson poisson)
    {
		if (this == poisson)
        {
			Console.WriteLine(this.getName() + " a essayé de se manger !");
        }

		else if (aquarium.is_in_aquarium(poisson))
        {
			Console.WriteLine(this.getName() + " mange " + poisson.getName());
			aquarium.remove_poisson(poisson);
        }
		else
        {
			Console.WriteLine("Erreur !");
        }
    }
	
}