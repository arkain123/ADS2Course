using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] MatchInSubstring(string s2, char ch) 
        {
            int comp = 0;
            for (int i = s2.Length - 1; i > -1; i--) 
            {
                comp++;
                if (ch == s2[i]) 
                { 
                    return new int[2] { i, comp };
                } 
            } 
            return new int[2] { -1, comp }; 
        }
        
        private int[] MismatchInText(string s1, string s2, int currentPos) 
        {
            int comp = 0;
            for (int i = s2.Length - 1; i > -1; i--) 
            {
                comp++;
                if (s2[i] != s1[currentPos + i]) 
                {
                    return new int[2] { currentPos + i , comp };
                }    
            }
            return new int[2] { -1, comp };
        }

        // O(N * M)
        private int[] StraightSearch(string s1, string s2)
        {
            int m = 0;
            int comp = 0;
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                int j;
                for (j = 0; j < s2.Length; j++)
                {
                    comp++;
                    if (s1[i] == s2[j])
                    { i++; continue; }
                    else break;
                }
                if (j == s2.Length)
                { m = i - s2.Length + 1; break; }
                else m = 0;
            }
            return new int[2] { m - 1, comp };
        }

        // O(N + M)
        private int[] BMHMethod(string s1, string s2)
        {    
            List<int> positions = new List<int>();    
            int i = 0;
            int comp = 0;
            while (i <= s1.Length - s2.Length) 
            {        
                int[] result = MismatchInText(s1, s2, i);
                comp += result[1];
                int mismatchIndex = result[0];

                if (mismatchIndex == -1) 
                {            
                    positions.Add(i);            
                    i++;        
                } else
                {
                    int[] substrres = MatchInSubstring(s2, s1[mismatchIndex]);
                    int mismatchIndexSubstr = substrres[0];
                    i = mismatchIndex - mismatchIndexSubstr;
                    comp += substrres[1];
                }    
            }
            return new int[2] { positions[0], comp};
        }

        // O(N + M)
        //https://www.youtube.com/watch?v=S2I0covkyMc
        private int[] KMPMethod(string s1, string s2) 
        {
            int comp = 0;
            //forming pi array
            //O(M)
            if (s1.Length == 0 || s2.Length == 0 || s1.Length < s2.Length) return new int[] { 1, comp };
            int i = 1;
            int j = 0;
            int[] pi = new int[s2.Length];

            while (i < s2.Length)
            {
                comp++;
                if (s2[j] == s2[i])
                {
                    pi[i] = j + 1;  i++;
                    j++;
                } 
                else
                {
                    if (j == 0)
                    {
                        pi[i] = 0;
                        i++;
                    }
                    else { j = pi[j - 1]; }
                }
            }
            //O(N)
            //searching substring
            i = 0;
            j = 0;
            while (i < s1.Length)
            {
                comp++;
                if (s1[i] == s2[j]) {
                    i++;
                    j++;
                    if (j == s2.Length) return new int[] { i - s2.Length, comp };
                } else
                {
                    if (j > 0)
                    {
                        j = pi[j - 1];
                    } else
                    {
                        i++;
                    }
                }
            }
            return new int[] { 0, comp };
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string s1 = stringTextBox.Text;
            string s2 = substringTextBox.Text;
            int[] res = StraightSearch(s1, s2);

            if (straightMethodButton.Checked)
                res = StraightSearch(s1, s2);
            if (BMHButton.Checked)
                res = BMHMethod(s1, s2);
            if (KMPButton.Checked)
                res = KMPMethod(s1, s2);

            compTextBox.Text = res[1].ToString();

            if (res[0] > 0)
                resultTextBox.Text = "i = " + (res[0] + 1);
            else
                resultTextBox.Text = "Не найдено";
        }
    }
}
