using System;
using System.Collections.Generic;
using System.Text;

namespace TextDocumentSearch.Logic
{
    /// <summary>
    /// Implements all functionality converting the contents found within a text file.
    /// </summary>
    public class TextFileConverter
    {
        /// <summary>
        /// Splits a supplied multiline string into an array of strings utilizing the current environment's newline character.
        /// </summary>
        /// <param name="multilineString"></param>
        /// <returns>
        /// Returns the input string as an array of strings split on new line characters.
        /// </returns>
        public static string[] GetLines(string filepath)
        {
            var contents = TextDocumentSearch.Data.TextFileHandler.ReadTextFromFile(filepath);
            var lineSeparator = new[] { Environment.NewLine };
            var lines = contents.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }
    }
}
