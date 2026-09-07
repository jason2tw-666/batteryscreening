using Supabase;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Supabase.Gotrue.Constants;

namespace 電池篩選器
{
    public partial class LoginForm : Form
    {
        private Supabase.Client supabase;
        public bool isPaidMember { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            supabase = new Supabase.Client(
                                $"https://pxlkpfwwoxvekjhlcetv.supabase.co",
                                "sb_publishable_5d3UoJwE_viKe6jcYd5e7Q_piQVS5oV");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            try
            {
                var session = await supabase.Auth.SignUp(
                    email,
                    password);

                MessageBox.Show("註冊成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"註冊失敗：{ex.Message}");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            supabase = new Supabase.Client(
                                            $"https://pxlkpfwwoxvekjhlcetv.supabase.co",
                                            "sb_publishable_5d3UoJwE_viKe6jcYd5e7Q_piQVS5oV");

            await supabase.InitializeAsync();

            MessageBox.Show("Supabase 連線成功");

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            try
            {

                if (!email.Any() || !password.Any())
                {
                    MessageBox.Show($"登入失敗：\r\n請輸入帳號或是密碼");
                    return;
                }

                await supabase.Auth.SignIn(email, password);

                var session = supabase.Auth.CurrentSession;

                var result = await supabase
                        .From<PaidMember>()
                        .Where(x => x.email == email  && x.UID == session.User.Id)
                        .Get();

                if (result != null && result.Models.FirstOrDefault()?.Paid == true)
                {
                    MessageBox.Show("您是付費會員\r\n(You are a paid member.)");
                    isPaidMember = true;
                }
                else
                {
                    MessageBox.Show("您是一般會員\r\n(You are a regular member)");
                    isPaidMember = false;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"登入失敗(Login failed)：\r\n{ex.Message}");
            }
        }
    }
}
