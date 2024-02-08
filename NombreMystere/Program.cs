
string utilisateur; 
int nombre; 

int nm = 18; 

// const int 100 

Console.WriteLine("Quelle est votre nom d'utilisateut ? ");
utilisateur = Console.ReadLine(); 

Console.WriteLine("Entrer un nombre aléatoire : "); 
nombre =  int.Parse(Console.ReadLine()); 

// int.Parse pour convertir le type de la variable 

if (nombre == nm)
{
    Console.WriteLine("Bingo !"); 
}
else {
    Console.WriteLine("Vous n'avez pas trouvé le nombre mystère...");
}

Console.WriteLine($"Bonjour, {utilisateur} ! Voici le nombre que vous avez choisi : {nombre}");



