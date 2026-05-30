using System.Media;

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
        private int hintsLeft = 3;
        private int timeLeft = 60;
      
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
                    timeLeft = 60;
                    Timer.Text = "Време: " + timeLeft;
                    timer1.Start();
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
            timeLeft = 60;
            Timer.Text = "Време: " + timeLeft;
            timer1.Start();
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
                SoundPlayer player = new SoundPlayer("correct.wav");
                player.Play();

                MessageBox.Show("Правилно! Познахте думата.");
                successCount++;
                Success.Text = "Познати: " + successCount;

                textBox1.Clear();
                GetNextWord();

                timeLeft = 60;
                Timer.Text = "Време: " + timeLeft;
                timer1.Start();
            }
            else
            {
                SoundPlayer player = new SoundPlayer("wrong.wav");
                player.Play();

                MessageBox.Show("Грешно! Опитайте пак.");
                failedCount++;
                Failed.Text = "Сгрешени: " + failedCount;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Skip_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("skip.wav");
            player.Play();

            MessageBox.Show("Пропуснахте думата! Вярната дума беше: " + currentWord);

            failedCount++;
            Failed.Text = "Сгрешени: " + failedCount;
            textBox1.Clear();
            GetNextWord();
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            if (hintsLeft <= 0)
            {
                MessageBox.Show("Нямате повече останали жокери!");
                return;
            }

            if (!string.IsNullOrEmpty(currentWord))
            {
                hintsLeft--;
                char firstLetter = currentWord[0];
                MessageBox.Show("Първата буква е: " + firstLetter + "\n Оставащи жокери: " + hintsLeft);

                if (hintsLeft == 0)
                {
                    Hint.Enabled = false;
                }
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            successCount = 0;
            failedCount = 0;
            failedAttempts = 0;
            hintsLeft = 3;

            Success.Text = "Познати: " + successCount;
            Failed.Text = "Сгрешени: " + failedCount;
            textBox1.Clear();

            Hint.Enabled = true;

            if (File.Exists("words.txt"))
            {
                words.Clear();
                string[] Lines = File.ReadAllLines("words.txt");

                foreach (string lines in Lines)
                {
                    if (lines.Trim() != "")
                    {
                        words.Add(lines.Trim());
                    }
                }

                if (words.Count > 0)
                {
                    GetNextWord();
                    timeLeft = 60;
                    Timer.Text = "Време: " + timeLeft;
                    timer1.Start();

                    MessageBox.Show("Играта беше рестартирана успешно!");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                
                timeLeft--;

                
                Timer.Text = "Време: " + timeLeft;
            }
            else
            {
                
                timer1.Stop();
                SoundPlayer player = new SoundPlayer("wrong.wav");
                player.Play();

                MessageBox.Show("Времето изтече! Вярната дума беше: " + currentWord);

                failedCount++;
                Failed.Text = "Сгрешени: " + failedCount;

                textBox1.Clear();
                GetNextWord();

            }
        }
    }
}
