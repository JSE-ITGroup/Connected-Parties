using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectedParties
{
    public class MemberPosition
    {
        public int KeyMemberAccountID { get; set; }
        public string KeyMemberTRN { get; set; }
        public string KeyMemberName { get; set; }
        public string KeyMemberIssuer { get; set; }
        public string KeyMemberPosition { get; set; }
        public DateTime KeyMemberJoinDate { get; set; }
        public DateTime KeyMemberResignDate { get; set; }
        public string EnteredBy { get; set; }
        public DateTime EnteredAt { get; set; }
    }
}
