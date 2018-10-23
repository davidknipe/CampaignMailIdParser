namespace CampaignMailIdParser.Interfaces
{
    /// <summary>
    /// Used to look up recipient email addresses
    /// </summary>
    public interface IMailId
    {
        string GetRecipientId(string mailId);
        long GetRecipientListId(string mailId);
    }
}