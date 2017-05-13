using System.Configuration;

namespace TwitterFavorites
{

    public class RegisterTwitterUsersConfig
        : ConfigurationSection
    {

        public static RegisterTwitterUsersConfig GetConfig()
        {
            var config = ConfigurationManager.GetSection("RegisterTwitterUsers") as RegisterTwitterUsersConfig;
            if (config == null)
            {
                config = new RegisterTwitterUsersConfig();
            }
            return config;
        }

        [System.Configuration.ConfigurationProperty("TwitterUsers")]
        [ConfigurationCollection(typeof(TwitterUsers), AddItemName = "TwitterUser")]
        public TwitterUsers TwitterUsers
        {
            get
            {
                object o = this["TwitterUsers"];
                return o as TwitterUsers;
            }
        }

    }

    public class TwitterUsers : ConfigurationElementCollection
    {
        public TwitterUser this[int index]
        {
            get
            {
                return BaseGet(index) as TwitterUser;
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public new TwitterUser this[string responseString]
        {
            get { return (TwitterUser)BaseGet(responseString); }
            set
            {
                if (BaseGet(responseString) != null)
                {
                    BaseRemoveAt(BaseIndexOf(BaseGet(responseString)));
                }
                BaseAdd(value);
            }
        }

        protected override System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new TwitterUser();
        }

        protected override object GetElementKey(System.Configuration.ConfigurationElement element)
        {
            return ((TwitterUser)element).ScreenName;
        }
    }

    public class TwitterUser : ConfigurationElement
    {
        [ConfigurationProperty("ScreenName", IsRequired = true)]
        public string ScreenName
        {
            get
            {
                return (string)this["ScreenName"];
            }
            set
            {
                this["ScreenName"] = value;
            }
        }

        [ConfigurationProperty("ConsumerKey", IsRequired = true)]
        public string ConsumerKey
        {
            get
            {
                return (string)this["ConsumerKey"];
            }
            set
            {
                this["ConsumerKey"] = value;
            }
        }

        [ConfigurationProperty("ConsumerSecret", IsRequired = true)]
        public string ConsumerSecret
        {
            get
            {
                return (string)this["ConsumerSecret"];
            }
            set
            {
                this["ConsumerSecret"] = value;
            }
        }


        [ConfigurationProperty("AccessToken", IsRequired = true)]
        public string AccessToken
        {
            get
            {
                return (string)this["AccessToken"];
            }
            set
            {
                this["AccessToken"] = value;
            }
        }


        [ConfigurationProperty("AccessTokenSecret", IsRequired = true)]
        public string AccessTokenSecret
        {
            get
            {
                return (string)this["AccessTokenSecret"];
            }
            set
            {
                this["AccessTokenSecret"] = value;
            }
        }

        

        public override string ToString()
        {
            return string.Format("@{0}", this.ScreenName);
        }
    }


   


}

