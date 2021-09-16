using System;

namespace PhotoBookTest
{
    public class PhotoBook
    {
        protected int NumPages;

        public PhotoBook()
        {
            NumPages = 16;
        }

        public PhotoBook(int numPages)
        {
            NumPages = numPages;
        }

        public int GetNumberPages()
        {
            return NumPages;
        }
    }
}