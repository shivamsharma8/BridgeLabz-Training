using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Reviews
{
    internal class Book
    {
        private string author;
        private string title;
        private Boolean isAvailable;

        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
            this.isAvailable = true;
        }

        public string getTitle()
        {
            return title;
        }

        public string getAuthor()
        {
            return author;
        }

        public Boolean getIsAvailable()
        {
            return isAvailable;
        }

        public void setIsAvailable(Boolean status) {
            this.isAvailable = status;    
        }
    }
}
