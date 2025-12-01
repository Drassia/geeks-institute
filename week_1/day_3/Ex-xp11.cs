using System;
using System.Collections.Generic;

class Song
{
    private List<string> lyrics;

    public Song(List<string> lyrics)
    {
        this.lyrics = lyrics;
    }

    public void SingMeASong()
    {
        foreach (string line in lyrics)
        {
            Console.WriteLine(line);
        }
    }
}

class Program
{
    static void Main()
    {
        var stairway = new Song(new List<string>
        {
            "There’s a lady who's sure",
            "all that glitters is gold",
            "and she’s buying a stairway to heaven"
        });

        stairway.SingMeASong();
    }
}