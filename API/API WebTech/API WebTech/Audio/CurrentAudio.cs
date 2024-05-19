using API_WebTech.Interfaces.Audio;

namespace API_WebTech.Audio
{
    public class CurrentAudio
    {
        Random random = new Random();

        public List<SoArAl> Current()
        {
            SongArtistAlbum songArtistAlbum = new SongArtistAlbum();

            List<SoArAl> list = new List<SoArAl>();

            string song;
            string artist;
            string album;
            int r;

            r = random.Next(0,10);

            song = songArtistAlbum.song[r];
            artist = songArtistAlbum.artist[r];
            album = songArtistAlbum.album[r];

            list.Add(new SoArAl
            {
                song = song,
                artist = artist,
                album = album,
            });

            return list;
        }
    }
}
