using ChopChopGames.UGM.GoogleSheetTable;

[GoogleSheetRow("sample")]
public class SampleCSV
{
    public int id { get; private set; }
    public string name { get; private set; }
    public int[] assetTypes { get; private set; }
    public int[] assetIds { get; private set; }
    public float value { get; private set; }
}
