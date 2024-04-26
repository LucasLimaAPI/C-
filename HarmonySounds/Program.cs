Band ironmaiden = new Band("Iron Maiden");

Album IronMaidenAlbum = new Album("Fear of the Dark");

Music music1 = new Music(ironmaiden,"Childhood's End")
{
    Duration = 265,
    Available = true,
};

Music music2 = new Music(ironmaiden,"Fear Of the Dark")
{
    Duration = 421,
    Available = false,
};


IronMaidenAlbum.AddMusic(music1);
IronMaidenAlbum.AddMusic(music2);
ironmaiden.AddAlbum(IronMaidenAlbum);

music1.ShowDataSheet();
music2.ShowDataSheet();
IronMaidenAlbum.ShowAlbumMusics();    
ironmaiden.ShowDiscografy();