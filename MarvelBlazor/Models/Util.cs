public static class Util{
    public static string ChangeToHttps(this string uri){
        return uri.Replace("http","https");
    }
}
