public class Aquarium
{
    private List<Poisson> listPoisson;
    private List<Algue> listAlgue;
    public Aquarium()
    {
        listPoisson = new List<Poisson>();
        listAlgue = new List<Algue>();
    }
   
    public void remove_algue() 
    { 
        listAlgue.RemoveAt(0);
    }

    public int getNbListAlgue()
    {
        return listAlgue.Count;
    }
    public void remove_poisson(Poisson poisson)
    {
        listPoisson.Remove(poisson);
    }

    public void add_poisson(Poisson poisson)
    {
        listPoisson.Add(poisson);
    }

    public void add_algue()
    {
        Algue algue1 = new Algue();
        listAlgue.Add(algue1);
    }

    public void affiche() 
    {
        Console.WriteLine("Il y a " + listPoisson.Count + " poissons dans cet aquarium.");
        Console.WriteLine("Il y a " + listAlgue.Count + " algues dans cet aquarium.");
    }
    public void affiche_contenu()
    {
        if (listAlgue.Count == 0 && listPoisson.Count == 0) Console.WriteLine("L'aquarium est vide !");

        else if (listAlgue.Count != 0 && listPoisson.Count != 0)
        {
            foreach (Poisson poisson in listPoisson) poisson.affiche();
        }
    }

    public bool is_in_aquarium(Poisson poisson)
    {
        if (listPoisson.Contains(poisson)) return true;
        return false;
    }

    public void tourne()
    {
        while (listPoisson.Count != 1)
        {
            int nb = 0;
            while (listPoisson.Count > nb)
            {
                int nb_poisson = listPoisson.Count;
                Random rand = new Random();
                int alea = rand.Next(0, nb_poisson);
                if (nb == alea)
                {
                    while (nb == alea)
                    {
                        int new_alea = rand.Next(0, nb_poisson);
                        if (new_alea != alea)
                        {
                            listPoisson[nb].mange(this, listPoisson[new_alea]);
                            break;
                        }
                    }
                }
                else
                {
                    listPoisson[nb].mange(this, listPoisson[alea]);
                }
                if (listPoisson.Count == nb) break; 
                nb++;
            }
            affiche();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }
}