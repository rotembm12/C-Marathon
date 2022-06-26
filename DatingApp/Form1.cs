namespace DatingApp
{
    public partial class Form1 : Form
    {
        public User activeUser;
        public User suggestedUser;

        public List<User> users = new List<User>();
        public List<User> approvedUsers = new List<User>();
        public List<User> declinedUsers = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            users = new List<User>();
            approvedUsers = new List<User>();
            declinedUsers = new List<User>();

            SetUsersFromFile();


            WriteUsersToFile();
        }

        void WriteUsersToFile()
        {

            for (int i = 0; i < 100; i++)
            {

            }
        }
        void SetUsersFromFile()
        {
            string[] users = File.ReadAllLines("./users.txt");
            foreach (string userLine in users)
            {
                string[] parameters = userLine.Split("|");
                string[] userParams = parameters[0].Split(",");
                string[] userLoginParams = parameters[1].Split(",");
                this.users.Add(
                    new User(
                        userParams[0],
                        GetRandomNumber(),
                        int.Parse(userParams[1]),
                        userParams[2],
                        userLoginParams[0],
                        userLoginParams[1]
                    )
                );
            }
        }

        void TryLogin()
        {
            string username = tbxUserName.Text;
            string password = tbxPassword.Text;
            try
            {
                int userIndex = this.users.IndexOf(new User(username, password));
                if(userIndex != -1)
                {
                    this.activeUser = this.users[userIndex];

                    ShowPrefPanel();
                } else
                {
                    throw new Exception("couldnt find this user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ShowPrefPanel()
        {
            pnlLogin.Hide();
            pnlSuggestions.Hide();
            lblWelcomeUser.Text = this.activeUser.UserName;
            pnlPref.Show();
        }

        void SetUserPref()
        {
            int[] ageRange = new int[] { Decimal.ToInt32(numMinAge.Value), Decimal.ToInt32(numMaxAge.Value) };
            string gender = cbxGender.SelectedItem.ToString();
            this.activeUser.Prefs = new Preferences(ageRange, gender);
            ShowSuggestionsPanel();
        }

        void ShowSuggestionsPanel()
        {
            pnlLogin.Hide();
            pnlPref.Hide();
            pnlSuggestions.Show();
            SetSuggestion();
        }

        void SetSuggestion()
        {
            suggestedUser = null;

            foreach (User user in users)
            {
                if(approvedUsers.Contains(user) || declinedUsers.Contains(user))
                {
                    continue;
                }

                // the user is valid for suggestion
                if(Preferences.IsValidSuggestion(user, activeUser.Prefs))
                {
                    suggestedUser = user;
                    break;
                }
            }

            RenderSuggestion();
        }

        void RenderSuggestion()
        {
            if (suggestedUser != null)
            {
                lblSuggestionAge.Text = suggestedUser.Age.ToString();
                lblSuggestionName.Text = suggestedUser.Name;
            }
            else
            {
                lblSuggestionName.Text = "no more suggestions";
                lblSuggestionAge.Visible = false;
                btnApproveSuggestion.Visible = false;
                BtnDeclineSuggestion.Visible = false;
            }
        }
      
        int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 9999999);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void btnSetPref_Click(object sender, EventArgs e)
        {
            SetUserPref();
        }

        private void btnApproveSuggestion_Click(object sender, EventArgs e)
        {
            approvedUsers.Add(suggestedUser);
            lbxApprovedSuggestions.Items.Add(suggestedUser);
            SetSuggestion();
        }

        private void BtnDeclineSuggestion_Click(object sender, EventArgs e)
        {
            declinedUsers.Add(suggestedUser);
            SetSuggestion();
        }
    }
}