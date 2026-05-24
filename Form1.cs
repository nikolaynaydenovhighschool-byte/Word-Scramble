namespace World_Scramble
{
    public partial class Form1 : Form
    {
        private List<string> words = new List<string>();
        private string currentWord = "";
        private string scrambleWord = "";

        private int successCount = 0;
        private int failedCount = 0;
        private int totalWordCount = 0;
        private int failedAttempts = 0;
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("words.txt"))
            {
                string[] allLines = File.ReadAllLines("words.txt");

                foreach (string line in allLines)
                {
                    if (line.Trim() != "")
                    {
                        words.Add(line.Trim());
                    }
                }

                if (words.Count > 0)
                {
                    GetNextWord();
                }
                else
                {
                    MessageBox.Show("Файлът words.txt е празен!");
                }
            }
            else
            {
                MessageBox.Show("Файлът words.txt не беше намерен!");
            }
        }
        private void GetNextWord()
        {
            if (words.Count == 0)
            {
                MessageBox.Show("Поздравления! Вие познахте всички думи!");
                return;
            }

            Random random = new Random();
            int input = random.Next(words.Count);
            currentWord = words[input];
            words.RemoveAt(input);

            char[] letters = currentWord.ToCharArray();
            for (int i = letters.Length - 1; i > 0; i--)
            {
                int n = random.Next(i + 1);
                char temp = letters[i];
                letters[i] = letters[n];
                letters[n] = temp;
            }

            scrambleWord = new string(letters);

            if (scrambleWord == currentWord && currentWord.Length > 1)
            {
                GetNextWord();
                return;
            }
            label1.Text = scrambleWord;
            failedAttempts = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guesser = textBox1.Text.Trim();

            if (guesser.ToLower() == currentWord.ToLower())
            {
                MessageBox.Show("Правилно! Познахте думата.");
                successCount++;
                Success.Text = "Познати: " + successCount;

                textBox1.Clear();
                GetNextWord();
            }
            else
            {
                MessageBox.Show("Грешно! Опитайте пак.");
                failedCount++;
                Failed.Text = "Сгрешени: " + failedCount;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
