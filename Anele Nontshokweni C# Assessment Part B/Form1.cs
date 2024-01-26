using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anele_Nontshokweni_C__Assessment_Part_B
{
    public partial class Form1 : Form
    {
        private List<string> wordsList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtInput.Text.Trim();
            if (!string.IsNullOrEmpty(word))
            {
                wordsList.Add(word);
                UpdateDisplay();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string selectedWord = GetSelectedWord();
            if (selectedWord != null)
            {
                string newWord = txtInput.Text.Trim();
                if (!string.IsNullOrEmpty(newWord))
                {
                    int index = wordsList.IndexOf(selectedWord);
                    wordsList[index] = newWord;
                    UpdateDisplay();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedWord = GetSelectedWord();
            if (selectedWord != null)
            {
                wordsList.Remove(selectedWord);
                UpdateDisplay();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            wordsList.Clear();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lstWords.Items.Clear();
            lstWords.Items.AddRange(wordsList.ToArray());
            txtInput.Clear();
        }

        private string GetSelectedWord()
        {
            if (lstWords.SelectedIndex != -1)
            {
                return lstWords.SelectedItem.ToString();
            }
            return null;
        }
    }
}