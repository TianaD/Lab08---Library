﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08___Library
{
    public interface iLibrary: IReadOnlyCollection<Book>
    {
          /// Add a Book to the library. ///
            void Add(string title, string author);
            /// <summary>
            /// Remove a Book from the library with the given title.
            /// </summary>
            /// <returns>The Book, or null if not found.</returns>
            Book Borrow(string title);

            /// <summary>
            /// Return a Book to the library.
            /// </summary>
            void Return(Book book);

            /// <summary>
            /// Search for book by title
            /// </summary>
            /// <returns>The Book, or null if not found.</returns>
            Book Search(string title);
        
    }
}
