using NewRelic.Microsoft.SqlServer.Plugin.Core;

namespace NewRelic.Microsoft.SqlServer.Plugin.QueryTypes
{
	[Query("RecompileDetail.sql", "Custom/RecompileDetail/{DatabaseName}", QueryName = "Recompile Detail", Enabled = false)]
	public class RecompileDetail : IDatabaseMetric
	{
		public string DatabaseName { get; set; }
		public int BucketID { get; set; }
		public int UseCounts { get; set; }
		public int SizeInBytes { get; set; }
		public string ObjectType { get; set; }
		public string Text { get; set; }
	}
}