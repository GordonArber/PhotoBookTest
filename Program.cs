using System;

namespace PhotoBookTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultPhotoBook = new PhotoBook();
            Console.WriteLine(defaultPhotoBook.GetNumberPages());

            var photoBook = new PhotoBook(24);
            Console.WriteLine(photoBook.GetNumberPages());

            var largePhotoBook = new BigPhotoBook();
            Console.WriteLine(largePhotoBook.GetNumberPages());
        }
    }
}