using HarmonySounds;
Band ironmaiden = new("Iron Maiden");

Album IronMaidenAlbum = new("Fear of the Dark");

Music music1 = new(ironmaiden,"Childhood's End")
{
    Duration = 265,
    Available = true,
};

Music music2 = new(ironmaiden,"Fear Of the Dark")
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




Podcast FlowPodpa = new("FlowPodpa");
Maraton FlowPodpamaraton = new("Canal Aberto");
Episode episode1 = new(FlowPodpa,"Recebendo Igor Gioberto")
{
    Duration = 5400,
    Available=true,
};
Episode episode2 = new(FlowPodpa,"Canoa d'eriva")
{
    Duration = 6000,
    Available= false

};

FlowPodpamaraton.AddEps(episode1);
FlowPodpamaraton.AddEps(episode2);
FlowPodpa.AddMaraton(FlowPodpamaraton);


episode1.ShowEpInfo();
episode2.ShowEpInfo();
FlowPodpamaraton.ShowMaratonEps();
FlowPodpa.ShowMaratonRelation();