using System.Collections.Generic;
using static Util;
public class ResultComics
{
    public Thumbnail thumbnail { get; set; }
}

public class DataComics
{
    public List<ResultComics> results { get; set; }
}

public class ApiComicsResult
{
    public DataComics data { get; set; }

    public string GetCover(string imageVariant){
        var uri =  $"{data?.results[0].thumbnail.path}/{imageVariant}.{data?.results[0].thumbnail.extension}";
        return uri.ChangeToHttps();
    }
}