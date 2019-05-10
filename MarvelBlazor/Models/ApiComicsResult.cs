using System.Collections.Generic;
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
        return  $"{data?.results[0].thumbnail.path}/{imageVariant}.{data?.results[0].thumbnail.extension}";
    }
}