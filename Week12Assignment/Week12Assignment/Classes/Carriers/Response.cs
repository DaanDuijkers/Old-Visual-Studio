using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public enum Response
    {
        Success,
        NoEmptySlots,
        NoTeacher,
        PastCurrentTime,
        WorkshopLocked,
        AlreadyRegistered,
        Occupied
    }
}
