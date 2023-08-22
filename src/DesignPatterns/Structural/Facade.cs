namespace DesignPatterns.Structural.Facade;

class DVDPlayer
{
    public void TurnOn()
    {
        Console.WriteLine("DVD Player is turned on");
    }

    public void PlayMovie(string movie)
    {
        Console.WriteLine($"Playing '{movie}' on DVD Player");
    }
}

class Projector
{
    public void TurnOn()
    {
        Console.WriteLine("Projector is turned on");
    }

    public void ProjectMovie()
    {
        Console.WriteLine("Projecting movie on the screen");
    }
}

class SoundSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Sound System is turned on");
    }

    public void PlayAudio()
    {
        Console.WriteLine("Playing audio with surround sound");
    }
}

// Facade class
public class HomeTheaterFacade
{
    private DVDPlayer dvdPlayer;
    private Projector projector;
    private SoundSystem soundSystem;

    public HomeTheaterFacade()
    {
        dvdPlayer = new DVDPlayer();
        projector = new Projector();
        soundSystem = new SoundSystem();
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        dvdPlayer.TurnOn();
        projector.TurnOn();
        soundSystem.TurnOn();

        dvdPlayer.PlayMovie(movie);
        projector.ProjectMovie();
        soundSystem.PlayAudio();

        Console.WriteLine($"Enjoy the movie '{movie}'!");
    }
}
