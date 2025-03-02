using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tessenger.Client.Custom.Enums
{
    public enum User_Status_LocalEnums
    {
        Online,
        Offline,
        Busy,
        Away,
        DoNotDisturb
    }
    public enum Message_LocalEnums
    {
        Text,
        Image,
        Video,
        Audio,
        File,
        Voice
    }
    public enum Message_Status_LocalEnums
    {
        Sent,
        Delivered,
        Read
    }
    public enum Account_Status_LocalEnums
    {
        Active,
        Inactive,
        Suspended,
        Deleted,
        Blocked,
        Banned,
        Pending,
        Verified,
        Unverified,
        Rejected,
        Approved,
        Declined,
        PendingApproval,
        PendingVerification,
        PendingRejection,
        PendingDecline
    }
    public enum User_Role_LocalEnums
    {
        Admin,
        User,
        Moderator,
        SuperAdmin
    }
    public enum User_Type_LocalEnums
    {
        Individual,
        Group,
        Channel
    }

}
