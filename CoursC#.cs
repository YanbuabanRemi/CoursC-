------------------------------------------------------------------- Raccourcie ---------------------------------------------------------------------- 

Commenter = Ctrl + K + C  
Décommenter = Ctrl + K + U  
Alt + Entrer

------------------------------------------------------------------- Code ----------------------------------------------------------------------
------------------------------------------------------------------- 1 - Variables ----------------------------------------------------------------------
Declaration des variable 
        Variable de type valeur
            short, int, long => Entier
            int a = 10;
            int b = a + 5;
            Float, double, decimal
            float f = 20.4F;
            decimal d = 20.4M;
        bool
            bool test = false;
        char
            char c = 'A';
        string 
            string nom = "Abadi";

        Operation 
            Addition +
            string prenom = "Ihab";
            string nomComplet = nom + prenom;
        Opérateur logique
            ET => &&
            OU => ||
            Négation => !
            bool test2 = true;
        Opérateur de comparaison
            Egalité ==
            superieur ou égal >=
            Inferieur ou égél <=

------------------------------------------------------------------- 2 - Struture conditionnelle ----------------------------------------------------------------------


        If & else
            int a = 10;
            if(a >= 20)
            {
               Console.WriteLine("a est superieur à 20");
            }
            else if( a > 10 && a < 20)
            {
               Console.WriteLine("a est inferieur à 20 et supérieur à 10");
            }
            else
            {
               Console.WriteLine("a est inferieur ou égale à 10");
            }
            
            if (a >= 20)
               Console.WriteLine("a est superieur à 20");
            else if (a > 10 && a < 20)
               Console.WriteLine("a est inferieur à 20 et supérieur à 10");
            else
               Console.WriteLine("a est inferieur ou égale à 10");

            bool result;
            if(a > 10)
            {
               result = true;
            }
            else
            {
               result = false;
            }
            bool result = (a > 10) ? true : false;

        Switch
            int mois = 1;
            switch(mois)
            {
               case 1:
                   Console.WriteLine("Janvier");
                   break;
               case 2:
                   Console.WriteLine("Février");
                   break;
               case 3:
                   Console.WriteLine("Mars");
                   break;
               default:
                   Console.WriteLine("ce n'est pas un mois");
                   break;
            }

            switch(mois)
            {
               case int n  when (n >= 1 && n <= 3):
                   Console.WriteLine("Hiver");
                   break;
               case int n when (n >= 4 && n <= 6):
                   break;
            }

------------------------------------------------------------------- 3 - Boucle ----------------------------------------------------------------------

        for
            for(int i= 1; i<= 10; i++)
            {
               Console.WriteLine(i);
            }
            for (int i = 49; i >= 0; i=i-3)
            {
               Console.WriteLine(i);
            }
            for(char c='A'; c <= 'z'; c++)
            {
               Console.WriteLine(c);
            }

        while
            int i = 10;
            while( i >0)
            {
               Console.WriteLine(i);
               i--;
            }

        do while
            do
            {
               Console.WriteLine(i);
               i++;
            } while (i < 10);

        tableau c#
            int[] tab = new int[10];
            tab[3] = 100;
            tab[5] = 200;
            int[] tab = new int[] { 1, 3, 5 };
            for(int i = 0; i < tab.Length; i++)
            {
               Console.WriteLine(tab[i]);
            }
            foreach(int i in tab)
            {
               Console.WriteLine(i);
            }

------------------------------------------------------------------- 4 - Console ----------------------------------------------------------------------

Console.Write() = Ecrit à la suite
Console.WriteLine() = Ecrit et revient à la ligne
Console.ReadLine() = Lit la ligne 

// Affecte a la variable nom ce qu'on va entrer dans la console
Console.Write("Merci de saisir votre nom : ");
string nom = Console.ReadLine();

------------------------------------------------------------------- Programmation orienté objet ----------------------------------------------------------------------

------------------------------------------------------------------- 1 - Encapsulation ---------------------------------------------------------------------- 

// Définition : L’encapsulation signifie qu’un groupe de propriétés, méthodes et autres membres corrélés est traité comme une unité ou un objet unique.


----------------- Les Class ------------------

// Chaque classe peut avoir différents membres de classe : 
// - des propriétés qui décrivent les données de classe
// - des méthodes qui définissent le comportement de classe 
// - des événements qui permettent la communication entre les différents objets et classes.

// Création de class :
Voiture v1 = new Voiture();
v1.couleur = "rouge";
v1.model = "Ford";
v1.km = 20000;

Voiture v1 = new Voiture("rouge", "ford");



------------------Les attributs et propriétés

// Les attributs et les propriétés et les champs sont des informations contenues dans un objet. Les champs sont similaires aux variables, car ils peuvent être lus ou définis directement.
// Les attributs et les propriétés peuvent être en public ou private

public string couleur;
public string model;
public int km;
private bool roule;

// La méthode get set permet d'accéder au contenu de l'attribut
// Alt + enter sur la propriété

//attribut
private int idClient;
//propriété
public int IdClient { get => idClient; set => idClient = value; }

-------------------Les méthodes

public void Rouler()
    {
        Console.WriteLine("Je roule " + model);
    }

// Les méthodes peuvent prendre un ou plusieurs paramètres

public void SetCouleur(string c)
        {
           couleur = c;
        }
public void SetCouleur(string c, string m)
        {
           couleur = c;
           model = m;
        }

----------------------Les constructeurs

public Voiture()
        {
            Km = 1000;
        }

// On peut creer un constructeur à partir d'un constructeur déjà existant

public Voiture(string toto) : this()
        {
            Couleur = toto;
        }
// this() fera reférance au constructeur Voiture() car this() ne contient aucune propriété

public Voiture(string c, string m) : this(c)
        {
            Model = m;
        }
// this(c) fera reférance au constructeur Voiture(string toto) car il this(c) contient une seul propriété (c) comme dans le constructeur Voiture(string toto)
// Le constructeur Voiture(string c, string m) construira la class d'abord par 
// - le constructeur Voiture() puis
// - le constructeur Voiture(string toto) puis
// - le constructeur public Voiture(string c, string m)
------------------------------------------------------------------- 2 - Héritage ---------------------------------------------------------------------- 




------------------------------------------------------------------- 3 - Polymorphisme ---------------------------------------------------------------------- 