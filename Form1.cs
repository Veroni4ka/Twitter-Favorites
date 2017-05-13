using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using LinqToTwitter;
using TwitterFavorites.DTO;
using System.Configuration;
using ServiceStack.Text;
using System.Threading;

namespace TwitterFavorites
{
    public partial class Form1 : Form
    {

        TwitterUser _selectedTwitterUser{ get; set; }

        public Form1()
        {
            InitializeComponent();
            var config = RegisterTwitterUsersConfig.GetConfig();

            //Populate the Twitter Auth combobox 
            //This is the list Twitter account that have Authorized Twitter API keys.
            // Set up your credentials here (https://apps.twitter.com)
            foreach (var twitterUser in config.TwitterUsers)
            {
                ddlTwitterAuthAccount.Items.Add(twitterUser);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            _selectedTwitterUser = ddlTwitterAuthAccount.SelectedItem as TwitterUser;
            var tweetDtos = Linq2Twitter();

            if (cboxSaveToFile.Checked)
            {
                Directory.CreateDirectory("Export");
                // Create the CSV file to which grid data will be exported.
                StreamWriter sw = new StreamWriter(@"Export/export" + Convert.ToString(ddlTwitterAuthAccount.SelectedIndex + 1) + ".csv");
                tweetDtos.ForEach(x => x.StatusID = string.Concat("=\"", x.StatusID, "\""));
                sw.WriteCsv(tweetDtos);
                sw.Close();
                tweetDtos.ForEach(x => x.StatusID = x.StatusID.TrimEnd('\"').Replace("=\"", ""));
            }
        }

        private List<TweetDto> Linq2Twitter()
        {
            List<TweetDto> tweetDtos = new List<TweetDto>();

            var auth = new SingleUserAuthorizer
            {
                CredentialStore = new SingleUserInMemoryCredentialStore
                {
                    ConsumerKey = _selectedTwitterUser.ConsumerKey,
                    ConsumerSecret = _selectedTwitterUser.ConsumerSecret,
                    AccessToken = _selectedTwitterUser.AccessToken,
                    AccessTokenSecret = _selectedTwitterUser.AccessTokenSecret
                }
            };

            var twitterCtx = new TwitterContext(auth);

            var accounts = new List<string>(ConfigurationManager.AppSettings[string.Concat("accounts", Convert.ToString(ddlTwitterAuthAccount.SelectedIndex+1))].Split(new char[] { ';' }));
                List<TweetDto> tweetList = new List<TweetDto>();
                int i = 0;
                foreach (var account in accounts)
                {
                    i++;
                    if (i == 16)
                    {
                        Thread.Sleep(900000);
                    
                    }
                    tweetDtos.AddRange(from tweet in twitterCtx.Favorites
                                       where tweet.Type == FavoritesType.Favorites &&
                                             tweet.ScreenName == account &&
                                             tweet.Count == 200
                                       //select tweet)
                                       select new TweetDto
                                       {
                                           Account = account,
                                           FavoriteCount = tweet.FavoriteCount,
                                           StatusID = tweet.StatusID.ToString(),
                                           TweetDate = tweet.CreatedAt.ToString(),
                                           TweetAuthor = tweet.User.ScreenNameResponse,
                                           Text = tweet.Text
                                       });
                    var test = tweetDtos.First().StatusID.ToString();
                }
                tweetDtos = tweetDtos.OrderBy(x => x.StatusID).ToList();
                dataGridView1.DataSource = tweetDtos;
            if (tweetDtos == null || tweetDtos.Count() == 0)
            {
                return null;
            }
            return tweetDtos;
        }

    }
}
