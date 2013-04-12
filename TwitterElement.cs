using System.Configuration;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;

namespace Falafel.Common.Configuration {

    public class TwitterElement : ConfigElement {

        public TwitterElement(ConfigElement parent) : base(parent) { }

        [ObjectInfo(Title = "Access token", Description = "Twitter Access token")]
        [ConfigurationProperty("AccessToken", DefaultValue = "")]
        public string AccessToken {
            get { return (string)this["AccessToken"]; }
            set { this["AccessToken"] = value; }
        }

        [ObjectInfo(Title = "Access token secret", Description = "Twitter Access token secret key")]
        [ConfigurationProperty("AccessTokenSecret", DefaultValue = "")]
        public string AccessTokenSecret {
            get { return (string)this["AccessTokenSecret"]; }
            set { this["AccessTokenSecret"] = value; }
        }

        [ObjectInfo(Title = "Consumer key", Description = "Twitter Consumer key")]
        [ConfigurationProperty("ConsumerKey", DefaultValue = "")]
        public string ConsumerKey {
            get { return (string)this["ConsumerKey"]; }
            set { this["ConsumerKey"] = value; }
        }

        [ObjectInfo(Title = "Consumer key secret", Description = "Twitter Consumer key secret")]
        [ConfigurationProperty("ConsumerKeySecret", DefaultValue = "")]
        public string ConsumerKeySecret {
            get { return (string)this["ConsumerKeySecret"]; }
            set { this["ConsumerKeySecret"] = value; }
        }
    }
}
