using System.Collections.Generic;

public class Hero{
    public string Name { get; set; }
    public string Description { get; set; }

    public string ImageURL { get; set; }

    public IEnumerable<HeroComic> Comics { get; set; }
}

public class HeroComic
{
    public string ResourceURI { get; set; }
    public string Name { get; set; }
}