using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallAudioQuality : uint
    {
        Unknown = 0,
        Low = 1,
        Standard = 2,
        High = 3,
        AMR_NB = 5,
        AMR_WB = 6,
        EVRC = 7,
        EVRC_B = 8,
        EVRC_NW = 9,
        EVRC_WB = 10,
        EVS_FB = 11,
        EVS_NB = 12,
        EVS_SWB = 13,
        EVS_WB = 14,
        GSM_EFR = 15,
        GSM_FR = 16,
        GSM_HR = 17,
        QCELP13K = 18,
        G711U = 19,
        G711A = 20,
        G722 = 21,
        G723 = 22,
        G729 = 23
    }
}
