using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ReadMe
{
    public partial class TextReader : Form
    {
        public TextReader()
        {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialogBox = new OpenFileDialog();
                dialogBox.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialogBox.Title = "Select the file";
                if (dialogBox.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = dialogBox.FileName;
                }
                processTextFile();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        //Read the file and store it in the Dictionary datastructure
        private void processTextFile()
        {
            try
            {
                // Read each line of the file into a string array. Each element of the array is one line of the file.
                IEnumerable<string> inputText = File.ReadAllLines(txtFilePath.Text.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToList();

                // Sort the words by decendending order by its length
                var sortedWords = inputText.OrderByDescending(word => word.Length);

                //First longest word
                lblFirst.Text = FindLongestWords(sortedWords);

                //Second longest word
                lblSecond.Text = FindLongestWords(sortedWords.Where(words => words != lblFirst.Text.Trim()));

                // Find the total number of longest words
                lblThird.Text = Convert.ToString(FindTotalLongestWords(sortedWords));
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        //Find the longest word from the list
        private string FindLongestWords(IEnumerable<string> sortedWords)
        {
            var dict = new HashSet<String>(sortedWords);
            return sortedWords.FirstOrDefault(word => hasWords(word, dict));
        }
        //Find total longest words from the list
        private int FindTotalLongestWords(IEnumerable<string> sortedWords)
        {
            int counter = 0;
            var dict = new HashSet<String>(sortedWords);
            foreach (string word in sortedWords)
            {
                if (hasWords(word, dict))
                {
                    counter++;
                }
            }
            return counter;
        }
        //Split the word and then check if the word exists in the list
        private bool hasWords(string word, HashSet<string> repository)
        {
            if (String.IsNullOrEmpty(word)) return false;
            if (word.Length == 1)
            {
                return repository.Contains(word);
            }
            foreach (var pair in generateTuple(word).Where(pair => repository.Contains(pair.Item1)))
            {
                return repository.Contains(pair.Item2) || hasWords(pair.Item2, repository);
            }
            return false;
        }

        private IEnumerable<Tuple<string, string>> generateTuple(string word)
        {
            string output = string.Empty;
            for (int i = 1; i < word.Length; i++)
            {
                yield return Tuple.Create(word.Substring(0, i), word.Substring(i));
            }
        }
    }
}