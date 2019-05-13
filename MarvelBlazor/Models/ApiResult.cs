using System;
using System.Linq;
using System.Collections.Generic;
using static Util;
public class Thumbnail
{
    public string path { get; set; }
    public string extension { get; set; }
}

public class Item
{
    public string resourceURI { get; set; }
    public string name { get; set; }

    public HeroComic ToHeroComic(){
        return new HeroComic{
            ResourceURI = resourceURI.ChangeToHttps(),
            Name = name
        };
    }
}

public class Comics
{
    public int available { get; set; }
    public string collectionURI { get; set; }
    public List<Item> items { get; set; }
    public int returned { get; set; }
}





public class Result
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public DateTime modified { get; set; }
    public Thumbnail thumbnail { get; set; }
    public string resourceURI { get; set; }
    public Comics comics { get; set; }
}

public class Data
{
    public int offset { get; set; }
    public int limit { get; set; }
    public int total { get; set; }
    public int count { get; set; }
    public List<Result> results { get; set; }
}

public class ApiResult
{
    public int code { get; set; }
    public string status { get; set; }
    public string copyright { get; set; }
    public string attributionText { get; set; }
    public string attributionHTML { get; set; }
    public string etag { get; set; }
    public Data data { get; set; }

    public Hero ToHero(string imageVariant){

        if(data == null) return null;
        if(data.results.ToArray().Length == 0) return null;

        return new Hero{
            Name = data?.results[0].name,
            Description = data?.results[0].description,
            ImageURL =  $"{data?.results[0].thumbnail.path}/{imageVariant}.{data?.results[0].thumbnail.extension}",
            Comics = data?.results[0].comics.items.Select(c=> c.ToHeroComic())

        };
    }
}