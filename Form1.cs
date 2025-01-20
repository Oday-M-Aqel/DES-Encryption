using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DES_Encryption
{
    public partial class Form1 : Form
    {
        private static string binary = "", str64 = "";
        private string right0 = "", left0 = "";
        private string mainkey = "", text = "";
        private static string binaryPass = "";
        private string SBoxResult = "";
        private char[] ri = new char[32];
        private int[] arr4bits = new int[32];
        private int[,] Expanarray = new int[8, 6];
        private string[] locations;
        private string[] Rows;
        private string[] Columns;
        private int[] LastExpan;
        private int[] Rowarr = new int[8], Colarr = new int[8];
        private int[] resArray = new int[8];
        private string[] bin = new string[32];
        private static List<string> list = new List<string>();
        //SBoxes
        int[,] SBox1 = new int[,]
        {
            {7, 3, 12, 1, 9, 6, 14, 5, 11, 10, 2, 8, 13, 4, 0,5},
            {1, 11, 4, 10, 3, 8, 5, 2, 15, 6, 9, 7, 12, 0, 14,11},
            {13, 2, 5, 10, 1, 3, 9, 0, 11, 14, 6, 8, 4, 7, 12,3},
            {6, 9, 14, 8, 10, 1, 5, 3, 13, 0, 11, 2, 7, 12, 4,9}
        };
        int[,] SBox2 = new int[,]
        {
            {4, 13, 6, 8, 11, 2, 3, 5, 7, 9, 14, 0, 1, 12, 10,2},
            {2, 10, 7, 5, 14, 3, 12, 9, 0, 1, 11, 6, 8, 4, 13,14},
            {9, 4, 6, 1, 14, 2, 0, 12, 3, 8, 11, 7, 5, 10, 13,8},
            {3, 8, 7, 14, 10, 0, 4, 6, 11, 9, 2, 5, 1, 13, 12,1}
        };
        int[,] SBox3 = new int[,]
        {
            {14, 1, 10, 3, 6, 8, 11, 0, 4, 9, 13, 7, 2, 12, 5,12},
            {1, 0, 5, 6, 3, 10, 14, 2, 11, 7, 12, 8, 4, 13, 9,7},
            {7, 4, 2, 13, 11, 10, 0, 6, 14, 5, 9, 1, 8, 12, 3,10},
            {11, 6, 0, 8, 14, 4, 5, 10, 2, 3, 7, 9, 13, 12, 1,4}
        };
        int[,] SBox4 = new int[,]
        {
            {8, 3, 11, 6, 0, 14, 7, 9, 10, 1, 4, 12, 2, 13, 5,0},
            {3, 10, 6, 13, 8, 0, 12, 9, 2, 5, 1, 11, 7, 14, 4,6},
            {9, 5, 13, 6, 10, 0, 2, 4, 7, 3, 11, 1, 14, 12, 8,13},
            {4, 8, 0, 12, 7, 10, 13, 2, 6, 1, 3, 11, 14, 5, 9,15}
        };
        int[,] SBox5 = new int[,]
        {
            {7, 3, 11, 6, 1, 9, 14, 10, 0, 5, 2, 8, 12, 13, 4,4},
            {0, 14, 2, 13, 5, 11, 4, 8, 3, 7, 10, 6, 1, 12, 9,8},
            {8, 2, 10, 12, 3, 9, 7, 0, 13, 4, 5, 1, 14, 11, 6,10},
            {1, 6, 12, 9, 4, 3, 11, 7, 10, 0, 14, 8, 2, 5, 13,6}
        };
        int[,] SBox6 = new int[,]
        {
            {10, 4, 1, 14, 7, 8, 6, 0, 13, 3, 2, 11, 12, 9, 5,3},
            {6, 8, 2, 13, 5, 11, 7, 3, 0, 10, 12, 9, 1, 4, 14,7},
            {12, 2, 5, 9, 0, 14, 8, 1, 3, 6, 10, 11, 13, 7, 4,11},
            {9, 1, 7, 10, 4, 0, 8, 3, 12, 5, 11, 6, 2, 13, 14,9}
        };
        int[,] SBox7 = new int[,]
        {
            {5, 11, 4, 0, 14, 9, 7, 3, 6, 1, 2, 8, 12, 10, 13,2},
            {6, 14, 10, 2, 5, 3, 7, 0, 11, 12, 4, 9, 1, 13, 8,13},
            {1, 8, 5, 12, 0, 14, 7, 11, 10, 2, 4, 6, 9, 13, 3,1},
            {3, 13, 7, 12, 6, 9, 0, 10, 2, 1, 4, 5, 8, 14, 11,5}
        };
        int[,] SBox8 = new int[,]
        {
            {11, 9, 8, 2, 10, 7, 0, 14, 5, 1, 6, 12, 3, 13, 4,12},
            {4, 7, 0, 3, 12, 11, 8, 2, 9, 6, 13, 5, 10, 1, 14,0},
            {5, 12, 8, 7, 1, 3, 10, 0, 6, 14, 2, 9, 11, 4, 13,14},
            {6, 2, 0, 13, 10, 3, 5, 11, 12, 4, 8, 7, 1, 9, 14,15}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void GetEncryptedText(string theBinary)
        {
            string binaryString = theBinary;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < binaryString.Length; i += 8)
            {
                string binaryByte = binaryString.Substring(i, 8);
                int decimalValue = Convert.ToInt32(binaryByte, 2);
                char character = Convert.ToChar(decimalValue);
                sb.Append(character);
            }

            text = sb.ToString();

        }
        private void SWAP()
        {
            string swapItem = left0;
            left0 = right0;
            right0 = swapItem;
        }
        private static void ConvertPasswordToBin(string PlainText)
        {

            if (PlainText == null)
            {
                MessageBox.Show("Please Enter something to Encrypt it");
            }
            else
            {
                string input = PlainText;
                foreach (char c in input)
                {
                    binaryPass += Convert.ToString(c, 2).PadLeft(8, '0');
                }
            }
        }

        private static void ConvertTextToBinary(string PlainText)
        {

            if (PlainText == null)
            {
                MessageBox.Show("Please Enter something to Encrypt it");
            }
            else
            {
                string input = PlainText;
                foreach (char c in input)
                {
                    binary += Convert.ToString(c, 2).PadLeft(8, '0');
                }
            }
        }
        private static void StoreEachInOne(string plaintxt)
        {
            string yourText = plaintxt;
            int chunkSize = 64;
            for (int i = 0; i < yourText.Length; i += chunkSize)
            {
                int length = Math.Min(chunkSize, yourText.Length - i);
                string chunk = yourText.Substring(i, length);
                list.Add(chunk);
            }
            if (list.Last().Length < 64)
            {
                ComplementBinary(list);
            }
        }
        private static void ComplementBinary(List<string> newList)
        {
            const int DesiredLength = 64;

            for (int i = 0; i < newList.Count; i++)
            {
                string binaryString = newList[i];

                if (binaryString.Length < DesiredLength)
                {
                    int diff = DesiredLength - binaryString.Length;
                    binaryString = binaryString.PadLeft(DesiredLength, '0');
                    newList[i] = binaryString;
                }
            }
        }

        private void InitialPermutation(string ConvText)
        {
            int[] InitialPermutation = new int[]
            {
                58,50,42,34,26,18,10,2,60,52,44,36,28,20,12,4,62,54,46,38,30,
                22,14,6,64,56,48,40,32,24,16,8,57,49,41,33,25,17,9,1,59,51,
                43,35,27,19,11,3,61,53,45,37,29,21,13,5,63,55,47,39,31,23,15,7
            };

            str64 = ConvText;
            char[] randomArray = str64.ToCharArray();
            str64 = "";
            for (int i = 0; i < InitialPermutation.Length; i++)
            {
                int index = InitialPermutation[i];
                str64 += randomArray[index - 1];
            }
        }

        private void Split64To32(string bit64)
        {
            string input = bit64;
            char[] plaintxt = input.ToCharArray();

            for (int i = 0; i < plaintxt.Length; i++)
            {
                if (i <= 31)
                {
                    left0 += plaintxt[i];
                }
                else
                {
                    right0 += plaintxt[i];
                }
            }
            ri = right0.ToCharArray();
            ExpansionBox(ri);
        }
        private void rightKeyeGeneration(string pass)
        {
            mainkey = pass;
            string last2 = mainkey.Substring(mainkey.Length - 3);
            mainkey = last2 + mainkey.Substring(0, mainkey.Length - 3);
        }
        private void leftKeyGeneation(string pass)
        {
            mainkey = pass;
            string first2 = mainkey.Substring(0, 2);
            mainkey = mainkey.Substring(2) + first2;

        }


        private void ExpansionBox(char[] rightside)
        {
            arr4bits = Array.ConvertAll(ri, c => (int)Char.GetNumericValue(c));
            Organizer(arr4bits, Expanarray);
            LastExpan = Expanarray.Cast<int>().ToArray();
        }
        static void Organizer(int[] array, int[,] finalArray)
        {
            int startPosition = 1;
            int number = 0;
            int counter = 1;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    finalArray[i, j] = array[startPosition - 1];
                    startPosition++;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                finalArray[i, 0] = finalArray[7 - number, 4];
                if (number == 0)
                {
                    number = 8;
                }
                number--;
                if (i == 7)
                {
                    counter = -7;
                }
                finalArray[i, 5] = finalArray[i + counter, 1];
            }
        }
        static string Xor32(string right, string left)
        {
            char[] result = new char[32];

            for (int i = 0; i < 32; i++)
            {
                int newRight = CharToInt2(right[i]);
                int newLeft = CharToInt2(left[i]);
                int xorResult = newRight ^ newLeft;
                result[i] = (char)('0' + xorResult);
            }
            return new string(result);
        }
        static int CharToInt2(char myChar)
        {
            int myInt = myChar - '0';
            return myInt;
        }

        static string Xor48(string right, string left)
        {
            char[] result = new char[48];

            for (int i = 0; i < 48; i++)
            {
                int newRight = CharToInt2(right[i]);
                int newLeft = CharToInt2(left[i]);
                int xorResult = newRight ^ newLeft;
                result[i] = (char)('0' + xorResult);
            }

            return new string(result);
        }
        private void sBox()
        {
            DivideToSix(XorTextBox.Text, out locations);
            ExtractRows(locations);
            ConvertRowsToInteger();
            ExtractColumns(locations);
            ConvertColsToInteger();
            getResult();
            tobinary();
        }
        private void DivideToSix(string binaryNumber, out string[] locations)
        {
            int groupSize = 6;
            int numGroups = binaryNumber.Length / groupSize;
            locations = new string[numGroups];

            for (int i = 0; i < numGroups; i++)
            {
                locations[i] = binaryNumber.Substring(i * groupSize, groupSize);
            }
        }
        private void ExtractRows(string[] dividedGroups)
        {
            Rows = new string[dividedGroups.Length];
            for (int i = 0; i < dividedGroups.Length; i++)
            {
                string group = dividedGroups[i];
                if (group.Length >= 2)
                {
                    char firstChar = group[0];
                    char lastChar = group[group.Length - 1];

                    int firstDigit = int.Parse(firstChar.ToString());
                    int lastDigit = int.Parse(lastChar.ToString());

                    string rowResult = firstDigit.ToString() + lastDigit.ToString();
                    Rows[i] = rowResult;
                }
                else
                {
                    Rows[i] = "Invalid";
                }
            }
        }
        private void ConvertRowsToInteger()
        {
            Rowarr = Rows.Select(binary => Convert.ToInt32(binary, 2)).ToArray();
        }
        private void ExtractColumns(string[] dividedGroups)
        {
            Columns = new string[dividedGroups.Length];

            for (int i = 0; i < dividedGroups.Length; i++)
            {
                string column = dividedGroups[i];

                string middle = column.Substring(1, column.Length - 2);

                Columns[i] = middle;
            }
        }
        private void ConvertColsToInteger()
        {
            Colarr = Columns.Select(binary => Convert.ToInt32(binary, 2)).ToArray();
        }
        private void getResult()
        {
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    resArray[i] = SBox1[Rowarr[i], Colarr[i]];
                }
                else if (i == 1)
                {
                    resArray[i] = SBox2[Rowarr[i], Colarr[i]];
                }
                else if (i == 2)
                {
                    resArray[i] = SBox3[Rowarr[i], Colarr[i]];
                }
                else if (i == 3)
                {
                    resArray[i] = SBox4[Rowarr[i], Colarr[i]];
                }
                else if (i == 4)
                {
                    resArray[i] = SBox5[Rowarr[i], Colarr[i]];
                }
                else if (i == 5)
                {
                    resArray[i] = SBox6[Rowarr[i], Colarr[i]];
                }
                else if (i == 6)
                {
                    resArray[i] = SBox7[Rowarr[i], Colarr[i]];
                }
                else if (i == 7)
                {
                    resArray[i] = SBox8[Rowarr[i], Colarr[i]];
                }
                else
                {
                    MessageBox.Show("Good bye");
                }
            }
        }
        private void tobinary()
        {
            bin = resArray.Select(num => Convert.ToString(num, 2).PadLeft(4, '0')).ToArray();
            SBoxResult = null;
            for (int i = 0; i < bin.Length; i++)
            {
                SBoxResult += bin[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newPlainText.Text = "";
            Password.Text = "";
            BeforIP.Text = "";
            AfterIP.Text = "";
            newExpansion.Text = "";
            XorTextBox.Text = "";
            SBoxResultText.Text = "";
            LeftXorRightText.Text = "";
            RightText.Text = "";
            LeftText.Text = "";
            DESResult.Text = "";
            EncryptedText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(newPlainText.Text == "" &&  Password.Text == "") {
                MessageBox.Show("Plain Text and Password filed are required");
            } else {
                string TExt = newPlainText.Text;
                ConvertTextToBinary(TExt);
                StoreEachInOne(binary);
                newPlainText.Text = "";
                while (list.Count != 0)
                {
                    for (int i = 0; i <= 17; i++)
                    {
                        if (i == 1)
                        {
                            BeforIP.Text = list.First();
                            InitialPermutation(list.First());
                            AfterIP.Text = str64;
                            Split64To32(str64);
                            foreach (int c in LastExpan)
                            {
                                newExpansion.Text += c.ToString();
                            }
                            binary = null;
                            ConvertPasswordToBin(Password.Text);
                            XorTextBox.Text = Xor48(newExpansion.Text, binaryPass);
                            sBox();
                            SBoxResultText.Text = SBoxResult;
                            LeftXorRightText.Text = Xor32(SBoxResultText.Text, left0);
                            left0 = LeftXorRightText.Text;
                            SWAP();
                            RightText.Text = right0;
                            LeftText.Text = left0;
                        }
                        else if (i == 2)
                        {
                            newExpansion.Text = "";
                            char[] newChar = right0.ToCharArray();
                            ExpansionBox(newChar);
                            leftKeyGeneation(binaryPass);
                            string expan = "";
                            foreach (int c in LastExpan)
                            {
                                expan += c.ToString();
                            }
                            newExpansion.Text = expan;
                            XorTextBox.Text = Xor48(expan, mainkey);
                            sBox();
                            SBoxResultText.Text = SBoxResult;
                            LeftXorRightText.Text = Xor32(SBoxResultText.Text, left0);
                            left0 = LeftXorRightText.Text;
                            SWAP();
                            RightText.Text = right0;
                            LeftText.Text = left0;
                            binaryPass = "";
                        }
                        else if (i > 2 && i <= 8)
                        {
                            newExpansion.Text = "";
                            char[] newChar = right0.ToCharArray();
                            ExpansionBox(newChar);
                            leftKeyGeneation(mainkey);
                            string expan = "";
                            foreach (int c in LastExpan)
                            {
                                expan += c.ToString();
                            }
                            newExpansion.Text = expan;
                            XorTextBox.Text = Xor48(expan, mainkey);
                            sBox();
                            SBoxResultText.Text = SBoxResult;
                            LeftXorRightText.Text = Xor32(SBoxResultText.Text, left0);
                            left0 = LeftXorRightText.Text;
                            SWAP();
                            RightText.Text = right0;
                            LeftText.Text = left0;
                        }
                        else if (i > 9 && i < 17)
                        {
                            newExpansion.Text = "";
                            char[] newChar = right0.ToCharArray();
                            ExpansionBox(newChar);
                            rightKeyeGeneration(mainkey);
                            string expan = "";
                            foreach (int c in LastExpan)
                            {
                                expan += c.ToString();
                            }
                            newExpansion.Text = expan;
                            XorTextBox.Text = Xor48(expan, mainkey);
                            sBox();
                            SBoxResultText.Text = SBoxResult;
                            LeftXorRightText.Text = Xor32(SBoxResultText.Text, left0);
                            left0 = LeftXorRightText.Text;
                            SWAP();
                            RightText.Text = right0;
                            LeftText.Text = left0;
                        }
                        else if (i == 17)
                        {
                            list.RemoveAt(0);
                            DESResult.Text += right0 + left0;
                            newExpansion.Text = "";
                            AfterIP.Text = "";
                            XorTextBox.Text = "";
                            SBoxResultText.Text = "";
                            LeftXorRightText.Text = "";
                            RightText.Text = "";
                            LeftText.Text = "";
                        }
                        MessageBox.Show(i.ToString());
                    }
                    GetEncryptedText(DESResult.Text);
                    EncryptedText.Text = text;
                }
            }
        }
    }
}
