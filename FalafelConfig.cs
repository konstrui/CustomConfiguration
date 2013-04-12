using System.Configuration;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;

namespace Falafel.Common.Configuration {

    public class FalafelConfig : ConfigSection {

        #region Constructors
        public FalafelConfig() { }
        #endregion

        #region Properties
        [ObjectInfo(Title = "Twitter page", Description = "Public Twitter page")]
        [ConfigurationProperty("TwitterPage", DefaultValue = "")]
        public string TwitterPage {
            get { return (string)this["TwitterPage"]; }
            set { this["TwitterPage"] = value; }
        }

        [ObjectInfo(Title = "Google+ page", Description = "Public Google+ page")]
        [ConfigurationProperty("GooglePlusPage", DefaultValue = "")]
        public string GooglePlusPage {
            get { return (string)this["GooglePlusPage"]; }
            set { this["GooglePlusPage"] = value; }
        }

        [ConfigurationProperty("Twitter")]
        public TwitterElement Twitter {
            get {
                return (TwitterElement)this["Twitter"];
            }
        }
        #endregion

    }
}
