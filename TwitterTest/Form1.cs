using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace TwitterTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static OAuthTokens GetTwitterAuthTokens(string accessToken, string secretToken)
        {
            OAuthTokens authorizationToken = new OAuthTokens();
            authorizationToken.ConsumerKey = "YhCC4XvUipgqBhEWc5DQ";
            authorizationToken.ConsumerSecret = "j8unuRNhwZdGaQ4Y0mRWZUzqf9BeZZ3aYgGyLsAURAk";
            authorizationToken.AccessToken = accessToken;
            authorizationToken.AccessTokenSecret = secretToken;
            return authorizationToken;
        }

        public static void Twittear(string token, string secretToken, string tweet)
        {
            OAuthTokens oAuthToken = GetTwitterAuthTokens(token, secretToken);
            Twitterizer.TwitterResponse<TwitterStatus> tweetResponse = TwitterStatus.Update(oAuthToken, tweet);
            if (tweetResponse.Result != RequestResult.Success)
            {
                if (tweetResponse.Result == RequestResult.Unauthorized)
                {

                }
                else
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxToken.Text = "145189930-CzJEX2nYihjL3AqeXiRhT86Oy9SyYoSUCzrBG8xT";
            textBoxSToken.Text = "i7WX3EcgrRwskszSk3xw5Z7uTp22jUfsKYB2gi91U0";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            labelCharCount.Text = "Chars: " + richTextBox1.Text.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Twittear(textBoxToken.Text, textBoxSToken.Text, richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
