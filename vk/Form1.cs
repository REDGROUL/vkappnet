using System.Windows.Forms;
using VkNet;
using VkNet.Abstractions;
using VkNet.Enums.Filters;
using VkNet.Infrastructure.Authorization.ImplicitFlow;
using VkNet.Model;
using VkNet.Model.RequestParams;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using VkNet.AudioBypassService.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace vk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            services.AddAudioBypass();

            var api = new VkApi(services);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                ApplicationId = 51434680,
                Login = Login.Text,
                Password = Password.Text,
                Settings = Settings.All,
                TwoFactorAuthorization = () =>
                {
                    Form3 f3 = new Form3();
                    string d = " ";
                    if (f3.ShowDialog() == DialogResult.OK)
                    {
                        d= f3.textBox1.Text;
                    }
                    return d;
                }
            });
            var p = api.Users.Get(new string[] { Convert.ToString(api.UserId) }, ProfileFields.All).FirstOrDefault();
            
            Form2 f = new Form2();
            if (Convert.ToString(p.Sex) == "Male")
            {
                var s = "�������";
                f.Sex.Text = s;

            }
            else if (Convert.ToString(p.Sex) == "Female")
            {
                var s = "�������";
                f.Sex.Text = s;
            }
            else
            {
                var s = "�� ������";
                f.Sex.Text = s;
            }
            f.Show();
            f.Firstname.Text = p.FirstName;
            f.Lastname.Text = p.LastName;
            f.Birthday.Text = p.BirthDate;
            f.Hometown.Text = p.HomeTown;
            f.Status.Text = p.Status;
            f.pictureBox1.ImageLocation = Convert.ToString(p.Photo200);
            f.Photo.Text = Convert.ToString(p.Counters.Photos);
            f.Friends.Text = Convert.ToString(p.Counters.Friends);
            f.Video.Text = Convert.ToString(p.Counters.Videos);
            f.ID.Text = Convert.ToString("ID " + p.ScreenName);

            if (Convert.ToString(p.OnlineMobile) == "True")
            {
                var onof = "online";
                f.OnOf.Text = onof;
            }
            else if (Convert.ToString(p.OnlineMobile) == "False")
            {
                var onof = "offline";
                f.OnOf.Text = onof;
            }


            if (Convert.ToString(p.Online) == "True")
            {
                var onof = "D.online";
                f.OnOf2.Text = onof;
            }
            else if (Convert.ToString(p.Online) == "False")
            {
                var onof = "D.offline";
                f.OnOf2.Text = onof;
            }

            ProfileFields pf = ProfileFields.FirstName | ProfileFields.LastName;
            var users = api.Friends.Get(new FriendsGetParams { UserId = api.UserId, Fields = pf });
            foreach (var friends in users)
            {
                f.listBox1.Items.Add(friends.Id + " " + friends.FirstName + " " + friends.LastName);
               
            }
          

















        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}