// See https://aka.ms/new-console-template for more information
string[] songs = ["brr, fiu, cric-cric, brrah","pep, birip, trri-trri, croac","bri-bri, plop, cric-cric, brrah"];

string[] sounds = ["brr", "birip", "brrah", "croac","fiu", "plop", "pep","cric-cric", "trri-trri", "bri-bri"];
string song = "";
string[] arraySound = [];
string sound = "";
string rest = "";
int indexSound = 0;

Console.WriteLine("Ingresa un sonido de animal cancion para ver el resto de la canción! \nLos sonidos validos son: \nRana: brr, birip, brrah, croac\nLibélula: fiu, plop, pep\nGrillo: cric-cric, trri-trri, bri-bri");

while (true)
{
    sound = Console.ReadLine();
    if(sounds.Any(p => p == sound))
    {
        break;
    }else
    {
        Console.WriteLine("Ingresa un sonido valido!");
        
    }
}

foreach(string s in songs){
    if(s.Contains(sound)){
        song = s;
        break;
    }
}

arraySound = song.Split(", ");
indexSound = Array.IndexOf(arraySound, sound);
//Si nos devuelve -1 por ser el ultimo elemento le indicamos que debe tomar el valor del tamaño arraySound
indexSound = (indexSound == -1 )? arraySound.Count():indexSound;

for (int i = 0; i < arraySound.Count(); i++)
{
    if((i == arraySound.Count() -1) && (arraySound[i] != sound))
    {
        rest = rest + arraySound[i];
    }
    else if(i > indexSound){
        rest = rest + arraySound[i]+",";
    }
}
Console.WriteLine(rest);