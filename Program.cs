namespace ExerciceLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maListe= new MaListe(10);

            foreach (var item in maListe)
            {
                Console.WriteLine(item);
            }

            List<Personne> personnes = new List<Personne>()
            {
                new() {Nom="Dupond", Prenom="Jean", TailleCm=175, Sexe=Sexe.Homme},
                new() {Nom="Talakaka", Prenom="OnTheFlow", TailleCm=165, Sexe=Sexe.Homme, DateNaissance=new(1959,02,01)},
                new() {Nom="Mic", Prenom="Flammez", TailleCm=160, Sexe=Sexe.Homme, DateNaissance=new(1960,05,10)},
                new() {Nom="Kheteti", Prenom="Yaovi", TailleCm=182, Sexe=Sexe.Homme},
                new() {Nom="Santrinos", Prenom="Raphael", TailleCm=170, Sexe=Sexe.Homme, DateNaissance=new(1999,05,13)},
                new() {Nom="Bazuka", Prenom="Laura", TailleCm=150, Sexe=Sexe.Femme}
            };

            List<string> nomsDeFamille = personnes.Select(x => x.Nom).ToList();

            foreach (var item in nomsDeFamille)
            {
                Console.WriteLine(item);
            }

            List<Personne> personneAvecAge=personnes.Where(p=>p.DateNaissance is not null).ToList();

            foreach (var item in personneAvecAge)
            {
                Console.WriteLine($"{item.Nom} {item.Prenom} {item.Sexe} {item.DateNaissance!.Value:dd/MM/yyyy}");
            }

            var SiFemme=personnes.Any(a=>a.Sexe==Sexe.Femme);
            Console.WriteLine(SiFemme);

            var NmbCarcNom = personnes.All(b => b.Nom.Length > 3);
            Console.WriteLine(NmbCarcNom);

            var listTriee=personnes.OrderBy(v=> v.Nom).ThenBy(p=>p.Prenom);
            foreach (var item in listTriee)
            {
                Console.WriteLine($"{item.Nom} {item.Prenom}");
            }
        }
    }
}
