using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace FriendOrganizer.UI.Data.Lookups
{
    public interface IMeetingLookupDataService
    {
        Task<List<LookupItem>> GetMeetingLookupAsync();
    }
}