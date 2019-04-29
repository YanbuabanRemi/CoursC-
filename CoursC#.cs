------------------------------------------------------------------- Raccourcie ---------------------------------------------------------------------- 

Commenter = Ctrl + K + C  
Décommenter = Ctrl + K + U  
Complétion = Alt + Entrer
Saut a la ligne = \n
Tabulation + tiret = \t

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

// L’encapsulation signifie qu’un groupe de propriétés, méthodes et autres membres corrélés est traité comme une unité ou un objet unique.
// Il protège les données de l'objet et son fonctionnement interne


----------------- Les Class -----------------------------------------------------------------------------------------------------------

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



------------------Les attributs et propriétés----------------------------------------------------------------------------

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

-------------------Les méthodes---------------------------------------------------------------------------------------------------------

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

----------------------Les constructeurs----------------------------------------------------------------------------------

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


-----------------------------------------Les collections--------------------------------------------------------------------------------------------
------------------------------------------Tableau-------------------------------------------------------------------------

//Un tableau doit toujours être defini en fonction de sa taille, la taille du tableau est donc prédéfini des le depart
// Declare a single-dimensional array 
int[] array1 = new int[5];

// Declare and set array element values
int[] array2 = new int[] { 1, 3, 5, 7, 9 };

// Alternative syntax
int[] array3 = { 1, 2, 3, 4, 5, 6 };

// Declare a two dimensional array
int[,] multiDimensionalArray1 = new int[2, 3];

// Declare and set array element values
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Declare a jagged array
int[][] jaggedArray = new int[6][];

// Set the values of the first array in the jagged array structure
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

// Les valeurs par défaut des éléments de tableau numériques sont définies sur zéro et les éléments de référence sont définis sur Null.
// Les tableaux sont indexés sur zéro : un tableau avec n éléments est indexée de 0 à n-1.
// Les éléments de tableau peuvent être de n’importe quel type, y compris un type tableau.

---------------------------------------------Liste-----------------------------------------------------------------------------------------

List<int> maListe = new List<int>();
// Le type de la liste est prédéfini dès le départ et ne peut être modifié

pour ajouter un element dans la liste
            maListe.Add(15);
            maListe.Add(20);

modifier un element
            maListe[0] = 10;

taille de la liste
            Console.WriteLine(maListe.Count);

supprimer un element
            maListe.Remove(15);

supprimer à un index
            maListe.RemoveAt(0);

Rechercher un éléments et renvoyer son index
			maListe.IndexOf("10");

Afficher la liste
            foreach(int a in maListe)
            {
                Console.WriteLine(a);
            }

Trie les éléments de la liste            
            maListe.Sort();
            

------------------------------------------------ Class Générique-----------------------------------------------------------------------------

// Permet de construire un objet générique en fonction de la caractéristique de T.
//Les méthodes et les classes génériques combinent la réutilisabilité, la cohérence des types et l’efficacité, ce que ne peuvent pas faire leurs équivalents non génériques.

//pile.cs
public class Pile<T>
    {
        private int nbMax;
        private int index;
        public int NbMax { get => nbMax; set => nbMax = value; }
        public T[] tab;

        public Pile(int nombre)
        {
            NbMax = nombre;
            tab = new T[NbMax];
            index = 0;
        }
        public void Empiler(T element)
        {
            if(index < NbMax)
            {
                tab[index] = element;
                index++;
            }
            else
            {
                Console.WriteLine("Pile pleine");
            }
        } 
        public void Depiler()
        {
            if(index-1 >= 0)
            {
                tab[index - 1] = default(T);
                index--;
            }
        }
    }

//Programme.cs
Pile<string> pile = new Pile<string>(10);
            pile.Empiler("test");
            pile.Empiler("coucou");
            pile.Empiler("tata");
            pile.Depiler();

------------------------------------------------------------------- 2 - Héritage ---------------------------------------------------------------------- 

// Creer un objet à partir d'un moule parent. Un objet "fils" est créer à partir d'un objet père, on dit alors que l’objet fils hérite de l’objet père
// On dit également que l’objet fils est une spécialisation de l’objet père ou qu’il dérive de l’objet père.
// Un objet ne peut pas hériter de plusieurs objet, l'héritage multiple est dont interdit en C#



------------------------------------------------------------------- 3 - Polymorphisme ---------------------------------------------------------------------- .

---------------------Ad hoc ou paramétré ---------------------------------
// Polymorphisme "ad hoc" ou polymorphisme "paramétré" est le fait de pouvoir utiliser une même méthode ou toute action utilisant des paramètres différents
// C'est la capacité pour un objet de faire un même action avec différetns types d'intervenants.
// Par exemple, notre objet voiture peut rouler sur la route, rouler sur l’autoroute, rouler sur la terre si elle est équipée de pneus adéquats, rouler au fond de l’eau si elle est amphibie, etc …


----------------------Héritage-----------------------------------------
// Le polymorphisme par héritage est le fait de s'approprié une méthode ou toute action par héritage et de se l'approprié en fonciton de ses caractéristiques personnelles
// Par exemple :Tous ces mammifères sont capables de se déplacer, mais chacun va le faire d’une manière différente. 
// Ceci est donc possible grâce à la substitution qui permet de redéfinir un comportement hérité.
// Ainsi, chaque fils sera libre de réécrire son propre comportement, si celui de son père ne lui convient pas.


---------