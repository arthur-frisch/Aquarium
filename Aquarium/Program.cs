using System;
using System.Threading;
using System.Collections.Generic;

class Programm
{
    public static void Main(string[] Args)
    {
        Aquarium test = new Aquarium();
        Poisson_carnivore Jade = new Poisson_carnivore("Jade", "Femelle", "Thon");
        Poisson_herbivore Arthur = new Poisson_herbivore("Arthur", "Male", "Carpe");
        Poisson_carnivore Jerem = new Poisson_carnivore("Jerem", "Male", "Mérou");
        Poisson_herbivore Lena = new Poisson_herbivore("Lena", "Femelle", "Carpe");
        Poisson_herbivore Alex = new Poisson_herbivore("Alex", "Male", "Sol");
        Poisson_herbivore Sofian = new Poisson_herbivore("Sofian", "Male", "Perche");
        test.add_poisson(Jade);
        test.add_poisson(Jerem);
        test.add_poisson(Arthur);
        test.add_poisson(Lena);
        test.add_poisson(Alex);
        test.add_poisson(Sofian);
        test.add_algue();
        test.add_algue();
        test.add_algue();
        test.add_algue();
        test.tourne();
    }
}

