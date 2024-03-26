using System;

public class PodatkovniKontekst
{
    private List<Korisnik> korisnici;
    private List<Poruka> poruke;
    private List<Razgovor> razgovori;

    public List<Korisnik> Korisnici { get { return this.korisnici; } }
    public List<Poruka> Poruke { get { return this.poruke; } }
    public List<Razgovor> Razgovori { get { return this.razgovori; } }

    private string datKorisnici = "korisnici.dat";
    private string datPoruke = "poruke.dat";
    private string datRazgovori = "razgovori.dat";

    public PodatkovniKontekst()
    {
        this.korisnici = UcitajKorisnike();
        this.poruke = UcitajPoruke();
        this.razgovori = UcitajRazgovore();
    }

    private List<Korisnik> UcitajKorisnike()
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        if (File.Exists(datKorisnici))
        {
            using (StreamReader sr = new StreamReader(datKorisnici))
            {
                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();
                    string[] polja = linija.Split('|');
                    Korisnik k = new Korisnik();
                    k.OIB = polja[0];
                    k.Ime = polja[1];
                    k.Prezime = polja[2];
                    k.Telefon = polja[3];
                    korisnici.Add(k);
                }
            }
        }
        return korisnici;
    }

    private List<Poruka> UcitajPoruke()
    {
        List<Poruka> poruke = new List<Poruka>();
        if (File.Exists(datPoruke))
        {
            using (StreamReader sr = new StreamReader(datPoruke))
            {
                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();
                    string[] polja = linija.Split('|');
                    Poruka p = new Poruka();
                    p.OIB = polja[0];
                    p.Naslov = polja[1];
                    p.Sadrzaj = polja[2];
                    poruke.Add(p);
                }
            }
        }
        return poruke;
    }

    private List<Razgovor> UcitajRazgovore()
    {
        List<Razgovor> razgovori = new List<Razgovor>();
        if (File.Exists(datRazgovori))
        {
            using (StreamReader sr = new StreamReader(datRazgovori))
            {
                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();
                    string[] polja = linija.Split('|');
                    Razgovor r = new Razgovor();
                    r.Id = Convert.ToInt32(polja[0]);
                    r.Datum = polja[1];
                    r.Vrijeme = polja[2];
                    razgovori.Add(r);
                }
            }
        }
        return razgovori;
    }

    public void SpremiKorisnike()
    {
        using (StreamWriter sw = new StreamWriter(datKorisnici))
        {
            foreach (Korisnik k in this.Korisnici)
            {
                sw.WriteLine("{0}|{1}|{2}|{3}",
                    k.OIB, k.Ime, k.Prezime, k.Telefon);
            }
        }
    }

    public void SpremiPoruke()
    {
        using (StreamWriter sw = new StreamWriter(datPoruke))
        {
            foreach (Poruka p in this.Poruke)
            {
                sw.WriteLine("{0}|{1}|{2}",
                    p.OIB, p.Naslov, p.Sadrzaj);
            }
        }
    }

    public void SpremiRazgovore()
    {
        using (StreamWriter sw = new StreamWriter(datRazgovori))
        {
            foreach (Razgovor r in this.Razgovori)
            {
                sw.WriteLine("{0}|{1}|{2}",
                    r.Id, r.Datum, r.Vrijeme);
            }
        }
    }
}

public class Korisnik
{
    public string OIB { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string Telefon { get; set; }
}

public class Poruka
{
    public string OIB { get; set; }
    public string Naslov { get; set; }
    public string Sadrzaj { get; set; }
}

public class Razgovor
{
    public int Id { get; set; }
    public string Datum { get; set; }
    public string Vrijeme { get; set; }
}