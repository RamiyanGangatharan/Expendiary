namespace Expendiary.Core
{
    internal class Setting
    {
        public int SettingID { get; set; }
        public int UserID { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }

        public Setting()
        {
            SettingID = 0;
            UserID = 0;
            SettingName = "defaultSettingName";
            SettingValue = "defaultSettingValue";
        }

        public Setting(int settingID, int userID, string settingName, string settingValue)
        {
            SettingID = settingID;
            UserID = userID;
            SettingName = settingName;
            SettingValue = settingValue;
        }
    }
}
