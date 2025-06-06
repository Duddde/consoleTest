public class Voiture
{
    public string Marque { get; set; }
    public string Modele { get; set; }
    public int Annee { get; set; }
    public string Couleur { get; set; }
    public int Kilometrage { get; set; }
    public double Prix { get; set; }
    public bool EstDisponible { get; set; } = true;
    public string Description { get; set; }

    public Voiture(string marque, string modele, int annee, string couleur)
    {
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Couleur = couleur;
    }

    public override string ToString()
    {
        return $"{Marque} {Modele} ({Annee}) - {Couleur}";
    }
}