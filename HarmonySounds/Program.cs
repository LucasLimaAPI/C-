Music music1 = new Music();// create an specific object for music.

music1.name = "The Unforgiven";
music1.artist= "Metallica";
music1.duration = 250;
music1.available = true;

music1.ShowDataSheet();

Console.WriteLine($"Name of music: {music1.name}");
Console.WriteLine($"Artist name: {music1.artist}");


Music music2 = new Music();
music2.name = "Otherside";
music2.artist = "RHCP";
music2.duration = 156;
music2.available = false;

Console.WriteLine($"Name of music: {music2.name}");
Console.WriteLine($"Artist name: {music2.artist}");

music1.ShowDataSheet();
music2.ShowDataSheet();