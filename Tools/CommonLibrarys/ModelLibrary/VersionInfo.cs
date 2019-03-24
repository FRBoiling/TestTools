namespace ModelLibrary
{
    public class VersionInfo
    {
        public int versionId { get; set; }
        public string versionName { get; set; }
      
        public VersionInfo()
        {
            versionId = Constant.inst.version;
            versionName = Constant.inst.versionName;
        }

        public VersionInfo GetVersion()
        {
            return this;
        }

    }
}
