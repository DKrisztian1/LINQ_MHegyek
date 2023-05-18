using HegyCsucsClass;
using System.IO;

List<HegyCsucs> lista = new List<HegyCsucs>();

string fajlnev = "hegyekMo.txt";
StreamReader sr = new StreamReader(fajlnev);
sr.ReadLine();

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    HegyCsucs elem = new HegyCsucs(sor.Split(";")[0], sor.Split(";")[1], Convert.ToInt32(sor.Split(";")[2]));
    lista.Add(elem);
}
sr.Close();

//3.
Console.WriteLine($"Hegycsúcsok száma: {lista.Count()} db");


//4. 
double osszeg = 0;
for (int i = 0; i < lista.Count(); i++)
    osszeg += lista[i].Magassag;

Console.WriteLine($"Hegycsúcsok átlagos magassága: {osszeg / lista.Count()} m");


//5.
int legmagasabbIndex = 0;
for (int i = 1; i < lista.Count(); i++)
{
    if (lista[i].Magassag > lista[legmagasabbIndex].Magassag)
        legmagasabbIndex = i;
}
Console.WriteLine("Legmagasabb hegycsúcs adatai: ");
Console.WriteLine($"\t Név: {lista[legmagasabbIndex].Hegycsucs}");
Console.WriteLine($"\t Hegység: {lista[legmagasabbIndex].Hegyseg}");
Console.WriteLine($"\t Magasság: {lista[legmagasabbIndex].Magassag}");



//6.
Console.WriteLine("Kérek egy magasságot: ");
int kapottMagassag = Convert.ToInt32(Console.ReadLine());
bool vanMagasabb = false;

for (int i = 1; i < lista.Count(); i++)
{
    if (lista[i].Hegyseg == "Börzsöny" && lista[i].Magassag > kapottMagassag)
    {
        Console.WriteLine($"Van {kapottMagassag} m-nél magasabb hegycsúcs a Börzsönyben!");
        vanMagasabb = true;
        break;   
    }
}
if (vanMagasabb == false)
    Console.WriteLine($"Nincs {kapottMagassag} m-nél magassabb hegycsúcs a Börzsönyben!");



//7.
int magasabbHEgycsucsokSzama = 0;
for (int i = 1; i < lista.Count(); i++)
{
    if (lista[i].Magassag * 3.280839895 > 3000)
        magasabbHEgycsucsokSzama++;
}
Console.WriteLine($"3000 lábnál magasabb hegycsúcsok száma: {magasabbHEgycsucsokSzama}");

//8.




//9.
string irasosFajl = "bukk-videk.txt";
StreamWriter sw = new StreamWriter(irasosFajl, true);
sw.WriteLine("Hegycsúcs neve;Magasság láb");

for (int i = 0; i < lista.Count(); i++)
{
    if (lista[i].Hegyseg == "Bükk-vidék")
    {
        sw.WriteLine($"{lista[i].Hegycsucs};{lista[i].Magassag * 3.280839895}");
    }
}