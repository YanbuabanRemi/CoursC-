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

-------------------------------------------------------------------5 Les collections-----------------------------------------------------------
___________________________________________________________________Tableau_______________________________________________________________

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

____________________________________________________________________________Liste__________________________________________________________________

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

------------------------------------------------------------------- Programmation orienté objet ----------------------------------------------------------------------

------------------------------------------------------------------- 1 - Encapsulation ---------------------------------------------------------------------- 

// L’encapsulation signifie qu’un groupe de propriétés, méthodes et autres membres corrélés est traité comme une unité ou un objet unique.
// Il protège les données de l'objet et son fonctionnement interne


____________________________________________________________________________Les Classes ______________________________________________________________________

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



______________________________________________________________________Les attributs et propriétés__________________________________________________________________

// Les attributs, les propriétés et les champs sont des informations contenues dans un objet. Les champs sont similaires aux variables, car ils peuvent être lus ou définis directement.
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

__________________________________________________________________________________Les méthodes____________________________________________________________________

public void Rouler()
    {
        Console.WriteLine("Je roule " + model);
    }

// Les méthodes peuvent prendre un ou plusieurs paramètres

public void SetCouleur(string c)
        {
           couleur = c;
        }
public void SetCouleur1(string c, string m)
        {
           couleur = c;
           model = m;
        }

_______________________________________________________________________________Les constructeurs____________________________________________________________________

//Le constructeur est une méthode qui s'effectuera lors de la création de l'objet

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
// this(c) fera reférance au constructeur Voiture(string toto) car this(c) contient une seul propriété (c) comme dans le constructeur Voiture(string toto)
// Le constructeur Voiture(string c, string m) construira la class d'abord par 
// - le constructeur Voiture() puis
// - le constructeur Voiture(string toto) puis
// - le constructeur public Voiture(string c, string m)



            
_________________________________________________________________________ Class Générique______________________________________________________________________

// Permet de construire un objet générique en fonction de la caractéristique de T.
// Les méthodes et les classes génériques combinent la réutilisabilité, la cohérence des types et l’efficacité, ce que ne peuvent pas faire leurs équivalents non génériques.

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
// Un objet ne peut pas hériter de plusieurs objet, l'héritage multiple est dont interdit en C#, on utilise donc l'héritage en cascade
// ex : A <---hérite---- B <-----hérite------ C <-------hérite-------- D
// D hérite donc de A, B et C

// Il existe 3 niveau d'accessibilité : 
// - public : accessible a tous le monde
// - protected : accessible à l'intérieur de la classe et à ses héritiers
// - private : accessible seulement à l'intérieur de la classe
public class Voiture {}
protected class Moto {}
private class Velo {}

// abstract permet d'utiliser une classe de manière de référence mais ne peut être utiliser pour creer un objet 
// Il est donc utiliser pour creer des enfants utilisant des caractéristiques commune
public abstract class Avion {}

// sealed permet de vérrouiller la classe et permet d'interdire le création de class enfant à partir de celle-ci (interdit l'héritage)
public sealed class Helicoptere {}

// La classe fils qui hérite de la classe père héritera de son type, de ses attributs, de ses propriètés, de ses méthodes mais pas de ses constructeurs.
Avion a1 = new Avion();
Velo v1 = new Velo("VTT", 2);




------------------------------------------------------------------- 3 - Polymorphisme ---------------------------------------------------------------------- .

_____________________________________________________________________Ad hoc ou paramétré ___________________________________________________________________
// Polymorphisme "ad hoc" ou polymorphisme "paramétré" est le fait de pouvoir utiliser une même méthode ou toute action utilisant des paramètres différents
// C'est la capacité pour un objet de faire un même action avec différetns types d'intervenants.
// Par exemple, notre objet voiture peut rouler sur la route, rouler sur l’autoroute, rouler sur la terre si elle est équipée de pneus adéquats, rouler au fond de l’eau si elle est amphibie, etc …

public class VoitureVolante
	{
		// La methode Avancer permet de définir dans cet exemple la façon dont la voiture avance, dans les airs, sur terre, etc
		public void Avancer("air")
		{

		}
		//La méthode Avancer permet de définir ici de combien de km la voiture avance
		public void Avancer(50)
		{
			
		}
	}

// La méthode Avancer est donc différente car elle utilise deux paramètres différents
 
_______________________________________________________________________Héritage_____________________________________________________________________________
// Le polymorphisme par héritage est le fait de s'approprié une méthode ou toute action par héritage et de se l'approprié en fonciton de ses caractéristiques personnelles
// Par exemple :Tous ces mammifères sont capables de se déplacer, mais chacun va le faire d’une manière différente. 
// Ceci est donc possible grâce à la substitution qui permet de redéfinir un comportement hérité.
// Ainsi, chaque fils sera libre de réécrire son propre comportement, si celui de son père ne lui convient pas.

//Défini la class Personne
public  class Personne
    {
        protected string nom;
        private string prenom;

        public Personne()
        {
        }

        public Personne(string n, string p)
        {
            Nom = n;
            Prenom = p;
        }

        public virtual void Afficher()
        {
            Console.WriteLine(Nom + " " + Prenom);
        }

        public virtual void AfficherAvecNew()
        {
            Console.WriteLine("Avec new : " + Nom + " " + Prenom);
        }
    }

// Défini la class Etudiant héritier de la classe Personne
 public sealed class Etudiant : Personne
    {
        private string level;
        public Etudiant()
        {
        }

        // Le constructeur Etudiant hérite du constructeur Personne gràce à base(n, p)
        // Lors de la construction d'un Etudiant, il va passer par la constructeur de Personne pour prendre le Nom et Prenom
        // Puis passera par le constructeur de l'etudiant pour prendr le Level
        public Etudiant(string n, string p, string l) : base(n,p)
        {
            Level = l;
        }

        // La méthode hérite de la méthode Afficher de Personne et ajoute une fonctionnalité en plus
        // C'est le polymorphisme par héritage
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Level : " + Level);    
        }

        // Dans cet exemple override et new sont identiques
        // new permet d'utiliser seulement les méthodes du parents (à confirmer..)
        public new void AfficherAvecNew()
        {
            base.AfficherAvecNew();
            Console.WriteLine("Avec new Level : " + Level);
        }

        // Cette méthode est propre à la classe Etudiant et n'existe pas dans la classe Personne
        public void specialEtudiant()
        {
        }
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------- Interfaces ----------------------------------------------------------------------------------------------

// L'interface permet de creer un "cahier des charges" que les classes doivent respecter
// Liste les méthodes indispensables 
// À noter que les interfaces ne fournissent qu’un contrat, elles ne fournissent pas d’implémentation c'est-à-dire pas de code C#. 
// On peut implementer plusieurs interface à une classe
// Orthographe conventionnel : INomDeLinterface

//IVolant.cs
public interface IVolant
    {
        string Nom { get; set; }
        void Voler();
    }

// Implémenter une interface à une classe
public class Avion : IVolant 
{
	private string nom;

        public string Nom { get => nom; set => nom = value; }

        public void Voler()
        {
            Console.WriteLine("Oiseau qui vole");
        }
}

public class Avion : IVolant
    {
        private string nom;

        public string Nom { get => nom; set => nom = value; }

        public void Voler()
        {
            Console.WriteLine("Avion qui vole");
        }
    }

// On peut mettre au sein d'une liste toutes les classes ayant la même interface
List<IVolant> lVolants = new List<IVolant>();
            IVolant o1 = new Oiseau();
            IVolant a1 = new Avion();
            lVolants.Add(o1);
            lVolants.Add(a1);
            
            foreach(IVolant v in lVolants)
            {
                Console.WriteLine(v.GetType());
                v.Voler();
            }


-----------------------------------------------------------------------------------------------------------------------
----------------------------------------------- StreamWrite et StreamRead -----------------------------------------

// StreamWrite permet d'écrire/de transformer des données choisies en un fichier de type choisi(txt, Json, doc, etc..)
// StreamRead permet de lire des fichiers (txt, Json, doc, etc)

// Pour utiliser ces fonctions, il faut importer la méthode "using System.IO"

---------------- StreamWrite ------------
// Il faut en premier lieu, instancier la classe StreamWrite

StreamWriter writer = new StreamWriter(@"C:\Users\Administrateur\Desktop\fichier.doc");
// @ pour eviter d'echapper le back-slash
// "C:\Users\Administrateur\Desktop\fichier.doc" => chemin de sauvegarde du fichier
writer.WriteLine(text);
// text peut être une variable contenant du texte, ou un chaine de caractére, une liste, une classe, etc
writer.Close();
// Fini la class StreamWrite

-- Tester si un fichier existe : --
if (File.Exists(@"C:\Users\Administrateur\Desktop\fichier.doc"))

---------------- StreamRead -------------
// Il faut en premier lieu, instancier la classe StreamRead

StreamReader reader = new StreamReader(@"C:\Users\Administrateur\Desktop\fichier.doc");
string contenu = reader.ReadToEnd();
// Met le contenu du fichier dans la variable contenu
Console.WriteLine(contenu);
// Affiche le contenu


// Pour pouvoir sauvegarder une classe et pouvoir la réutiliser, il faut la sauvgarder dans un fichier Json
// Pour cela, il faut importer l'extension Newtonsoft.Json
// => Click droit sur le dossier (dans l'explorateur de solution)
// => Gerer les packages nugets pour la solution
// Parcourir et installer l'extension Newtonsoft.Json
Personne perso = new Personne() { Nom = n, Prenom = p };
StreamWriter writer = new StreamWriter("Perso.txt");
// Perso.txt sauvegarde le fichier dans le dossier du projet
string persoEnJson = JsonConvert.SerializeObject(perso);
// Sauvegarde la classe perso dans la variable en Json
writer.WriteLine(persoEnJson);
writer.Close();
// StreamRead
StreamReader reader = new StreamReader("Perso.txt");
string contenuFichier = reader.ReadToEnd();

Personne p2 = JsonConvert.DeserializeObject<Personne>(contenuFichier);
reader.Close();
// Remet le contenu de la variable qui est sous format Json en un objet de type Class
// p2 est maintenant utilisable comme une class
Console.WriteLine(p2.Nom + " " + p2.Prenom);

--------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- Ref / Out / Delegate / Func / Action / Expression Lambda ------------------------------------------------------------------------


------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- Les événements ----------------------------------------------------------------------------

// On appelle évènement une action particulière qui a lieu. Cela peut être un clic de souris, l'appui d'une touche du clavier, ... 
// Il existe une infinité d'évènements puisque vous pouvez même créer les vôtres.

But
// Ce que l'on veut, c'est effectuer une action lorsqu'un certain évènement est déclenché. Pour cela, il faut déjà savoir quand est déclenché l'évènement dont il est question.
// C'est ici qu'entrent en jeu les gestionnaires d'évènements ("event handlers" en anglais). Il servent à indiquer que l'évènement surveillé vient d'être déclenché.

Fonctionnement
// Le principe est simple : on attache un gestionnaire d'évènements à un évènement (on dit que l'on s'abonne à l'évènement) en spécifiant une méthode. 
// Cette méthode est appelée lorsque l'évènement est déclenché. 


------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- Les exceptions ----------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- Sql Server ----------------------------------------------------------------------------

// Sql est un langage de programation standardisé pour les bases de données
- Ouvrir un server Sql :

// Ouvrir le PowerShell (MAJ + Click Droit)
// sqllocaldb c nomDuServer
// sqllocaldb s nomDuServer

// Se rendre dans le dossier dans Visual Studio
// -> Explorateur de server
// -> Microsoft Sql Server
// Connexion à la base de donnée
// Nom du server : (localdb)\nomDuServer

// Sql est un langage basé sur trois principes :

- Le langage de définition

creer une table:
// Click droit sur le server dans l'explorateur 
// -> new requete
// CREATE TABLE xxx (
// variable valeur(nbMax) NOT NULL PRIMARY KEY
// (PRIMARY KEY permet de donner une valeur unique)
// variable2 valeur 
// id INT NOT NULL PRIMARY KEY IDENTITY(10, 1)
// (Identity(10, 1) => auto - incremente l'id de 1 en commençant par le chiffre 10)
// )

supprimer une table:
// DROP TABLE xxx

modifier une table:
// (en ajoutant)
ALTER TABLE xxx ADD variable valeur....
// (en supprimant)
ALTER TABLE xxx DROP COLUMN variable

- Le langage de Manipulation

//insertion de données
INSERT INTO xxx (variable, variable1, variable2) VALUES (donnée, donnée1, donnée2)

//mise à jour des données
UPDATE xxx set variable = donnée3, variable2 = donnée4 WHERE variable1 = donnée1

//supression de données
DELETE FROM xxx WHERE variable1 > donnnée10

- Le langage de Selection

// selectionne toute la table
SELECT * FROM xxx

// selectionne les colonnes nom et prenom de la table xxx et revoie les données avec l'intituler n et p
SELECT nom as n, prenom as p FROM xxx

// selectionne que les id supérieur à 2
SELECT nom FROM xxx WHERE id>2
------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- AdoNet Connecter ----------------------------------------------------------------------------

// Le mode connecter permet de mettre à jour les données en temps réel, c'est à dire que lorsquon réalise une modification d'une données
// Celle ci est modifier dans la base de donnée
-----------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- AdoNet Deconnecter ----------------------------------------------------------------------------

// Le mode déconnecter nvoie une image de la base de donnée à un moment donné et peut être modifier par la suite
// On envoie les données modifiées quand on le souhaite
// Ces données sont donc pas mise à jour en temps réel dans la base de données mais se fait lors de l'UPDATE

// 2 types d'objet en monde déconnecter :

// 1/ Le SqlDataAdapter permet d'importer et d'exporter les données 
// Fill permet d'importer les données de la base de données et les stocks dans un DataSet
// UPDATE() permet d'exporter les données du DataSet dans la base de données ne fonction des modifications:
// - Si on ajoute du contenu dans le DataSet, il faut initier l'INSERTCOMMAND
// - Si on modifie du contenu dans le DataSet, il faut initier l'UPDATECOMMAND
// - Si on supprime du contenu dans le DataSet, il faut initier le DELETECOMMAND

// 2/ Le DataSet permet de stocker en local, les données de la base de donnée
// Ces données modifiés ne sont pas mis à jour dans la  base de donnée tant qu'on a pas effectué la commande


