using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TextDocumentSearch.Data
{
    /// <summary>
    /// Implements all functionality involving the import and export of data to and from text files.
    /// </summary>
    public class TextFileHandler
    {
        /// <summary>
        /// Takes a specified <paramref name="filepath"/> and returns the text contained within that file.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns>
        /// The text files contents as a string.
        /// </returns>
        public static string ReadTextFromFile(string filepath)
        {
            StreamReader streamReader = File.OpenText(filepath);
            string txt = null;

            try
            {
                txt = streamReader.ReadToEnd();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                streamReader.Close();
            }
            return txt;
        }
    }
}
