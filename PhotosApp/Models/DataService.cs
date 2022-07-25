using PhotosApp.Views.Photos;

namespace PhotosApp.Models
{
    public class DataService
    {

        List<string> photos = new List<string>()
        {
            new string(1, 0, "Mona Lisa", @"https://via.placeholder.com/600/92c952", @"https://via.placeholder.com/150/92c952")
            //new string(2, 1, "reprehenderit", @"https://via.placeholder.com/600/771796", @"https://via.placeholder.com/150/771796"),
            //new string(3, 2, "gafasfdas", @"https://via.placeholder.com/600/24f355", @"https://via.placeholder.com/150/24f355"),
            //new string(4, 3, "avavs", @"https://via.placeholder.com/600/d32776", @"https://via.placeholder.com/150/d32776"),
            //new string(5, 4, "Mfwga", @"https://via.placeholder.com/600/f66b97", @"https://via.placeholder.com/150/f66b97"),
            //new string(6, 5, "56a8c2", @"https://via.placeholder.com/600/56a8c2", @"https://via.placeholder.com/150/56a8c2"),
            //new string(7, 6, "b0f7cc", @"https://via.placeholder.com/600/b0f7cc", @"https://via.placeholder.com/150/b0f7cc"),
            //new string(8, 7, "54176f", @"https://via.placeholder.com/600/54176f", @"https://via.placeholder.com/150/54176f"),
            //new string(9, 8, "51aa97", @"https://via.placeholder.com/600/51aa97", @"https://via.placeholder.com/150/51aa97"),
            //new string(10, 9, "810b14", @"https://via.placeholder.com/600/810b14", @"https://via.placeholder.com/150/810b14")
        };

       public IndexVM GetAll()
        {
            return photos.ToArray();
        }
    }
}
