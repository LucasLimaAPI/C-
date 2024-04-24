Music music1 = new Music();// create an specific object for music.

music1.Name = "The Unforgiven";
music1.Artist= "Metallica";
music1.Duration = 250;
music1.Available = true;
System.Console.WriteLine(music1.ResumDescription);


music1.ShowDataSheet();

Console.WriteLine($"Name of music: {music1.Name}");
Console.WriteLine($"Artist name: {music1.Artist}");


Music music2 = new Music();
music2.Name = "Otherside";
music2.Artist = "RHCP";
music2.Duration = 156;
music2.Available = false;



Console.WriteLine($"Name of music: {music2.Name}");
Console.WriteLine($"Artist name: {music2.Artist}");

music1.ShowDataSheet();
music2.ShowDataSheet();