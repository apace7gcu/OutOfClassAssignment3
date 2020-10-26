// Amanda Pace
//Bill Hughes, CST-117
//October 25, 2020
//Out of Class Assignment 3
//This is a program that reads a file, and writes certain statistics to a new file.

//This pogram includes sourcecode/inspiration from: 
/*https://stackoverflow.com/questions/6177219/convert-string-array-to-lowercase

https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-24.php

https://stackoverflow.com/questions/53484674/how-to-print-out-the-word-with-the-most-vowels

https://stackoverflow.com/questions/4603911/extract-the-last-word-from-a-string-using-c-sharp

https://social.msdn.microsoft.com/Forums/en-US/8e73cea7-c63e-4387-885f-538d33658fac/sorting-arrays-alphabetically?forum=csharpgeneral */

//References from the code we used in class on 10/19 were also utilized.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutOfClassAssignment3
{
    public partial class FileReader : Form
    {
        public FileReader()
        {
            InitializeComponent();

        }

        /// <summary>
        /// When user presses button, they will be able to select file, 
        /// and code will read and interact with it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnReadFile_Click(object sender, EventArgs e)
        {
            //Declares the file selected as a variable
            string yourTxtFile = this.opnFileDialogue.FileName;

            //Where the file dialogue starts
            if (this.opnFileDialogue.ShowDialog() == DialogResult.OK)
            {

                //Checking that file exists and can be run
                if (File.Exists(yourTxtFile))
                {

                    //Converts selected file into an array
                    string[] text = File.ReadAllLines(yourTxtFile);

                    //================================================
                    //Lowercasing text

                    //Statement looks at each line/word in new array
                    foreach (string line in text)
                    {
                        string indLine = line;
                    }

                    //Convets each word in array to lowercase, makes a new array from that.
                    string[] lowerCaseText = text.Select(s => s.ToLowerInvariant()).ToArray();

                    //Displays all of the new lowercase words in a richTextBox
                    this.txtDisplayText.Lines = lowerCaseText;

                    //=================================================
                    //Finding Longest Word

                    //Declaring some variables we will need later
                    string longestWord = " ";
                    int length = 0;

                    /*Statement that looks at the amount of letters in each word,
                     * assigns longest word to a variable.*/
                    foreach (string letters in text)
                    {
                        if (letters.Length > length)
                        {
                            longestWord = letters;
                            length = letters.Length;
                        }
                    }

                    //Displays longest word in a text box
                    txtLongestWord.Text = longestWord;

                   // =======================================================
                   //Finding word with most vowels

                    //Declaring starting variables for later
                    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                    var wordMostVow = 0;
                    string mostVowelDisplay = " ";

                    /*Statement compares the vowels array with the amount of vowels in each word 
                     * from the text, assigns word with most vowels to a variable */
                    for (int v = 0; v < text.Length; v++)
                    {
                        var textInput = text[v];
                        var vowelCount = 0;
                        foreach (var vowel in vowels)
                        {
                            if (textInput.Contains(vowel)) vowelCount++;

                        }
                        if (wordMostVow < vowelCount)
                        {
                            wordMostVow = v;
                            mostVowelDisplay = textInput;
                        }
                    }

                    //Displays word with most vowels to text box.
                    txtMostVowels.Text = mostVowelDisplay;

                    //=============================================================
                    //Sorting Alphabetically

                    //Converts the text array into an array sorted alphabetically
                    string[] alphabeticalSort = text.OrderBy(n => n).ToArray();

                    //Finds the first word in the array, assigns it to a variable, displays in txtbox
                    string firstWord = alphabeticalSort.First();
                    txtFirstWord.Text = firstWord;

                    //Finds the last word in the array, assigns to variable, displays in txtbox
                    string lastWord = alphabeticalSort.Last();
                    txtLastWord.Text = lastWord;

                    //===================================================================
                    //File Location/ Writing to a File

                    //Declares file current location as a variable
                    string firstFileLocal = Path.GetFullPath(opnFileDialogue.FileName);

                    //Gets index
                    int indx = firstFileLocal.LastIndexOf("\\");

                    //Removes index, changes file location to desired one
                    string finalFileLocal = firstFileLocal.Remove(indx, firstFileLocal.Length - indx);

                    //A string of all the "stats" found from reading the file
                    string fileStats = "Sorted alphabetically, the first word is: " + firstWord +
                      " \r\n The last word is: " + lastWord + " \r\n The longest word is: "
                      + longestWord + "\r\n The word with the most vowels is: " + mostVowelDisplay;

                    //Writes the above string to a new text file.
                     File.WriteAllText(finalFileLocal + "\\WriteStats.txt", fileStats);
                }

            }

        }

        
    }
}

