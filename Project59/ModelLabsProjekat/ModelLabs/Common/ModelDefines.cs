using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{
	
	public enum DMSType : short
	{		
		MASK_TYPE							    = unchecked((short)0xFFFF),

        SEASON                                  = 0x0001,
        DAYTYPE                                 = 0x0002,
        BREAKER                                 = 0x0003,
        LOADBREAKSWITCH                         = 0x0004,
        RECLOSESEQUENCE                         = 0x0005,
        SWITCHSCHEDULE                          = 0x0006,
        REGULARTIMEPOINT                        = 0x0007,
	}

    [Flags]
	public enum ModelCode : long
	{
		IDOBJ								    = 0x1000000000000000,
		IDOBJ_GID							    = 0x1000000000000104,
		IDOBJ_ALIASNAME 					    = 0x1000000000000207,
		IDOBJ_MRID							    = 0x1000000000000307,
		IDOBJ_NAME							    = 0x1000000000000407,

        RECLOSESEQUENCE                         = 0x1100000000050000,        
        RECLOSESEQUENCE_RECLOSESTEP             = 0x1100000000050103,
        RECLOSESEQUENCE_PROTECTEDSWITCH         = 0x1100000000050109,

        SEASON                                  = 0x1200000000010000,
        SEASON_ENDDATE                          = 0x1200000000010108,
        SEASON_STARTDATE                        = 0x1200000000010208,
        SEASON_SEASONDAYTYPESCHEDULES           = 0x1200000000010319,

        DAYTYPE                                 = 0x1300000000020000,
        DAYTYPE_SEASONDAYTYPESCHEDULES          = 0x1300000000020119,

        REGULARTIMEPOINT                        = 0x1400000000070000,
        REGULARTIMEPOINT_SEQUENCENUMBER         = 0x1400000000070103,
        REGULARTIMEPOINT_VALUE1                 = 0x1400000000070205,
        REGULARTIMEPOINT_VALUE2                 = 0x1400000000070305,
        REGULARTIMEPOINT_INTERVALSCHEDULE       = 0x1400000000070409,

        BASICINTERVALSCHEDULE                   = 0x1500000000000000,
        BASICINTERVALSCHEDULE_STARTTIME         = 0x1500000000000108,
        BASICINTERVALSCHEDULE_VALUE1UNIT        = 0x150000000000020a,

        REGULARINTERVALSCHEDULE                 = 0x1510000000000000,
        REGULARINTERVALSCHEDULE_TIMEPOINTS      = 0x1510000000000119,

        SEASONDAYTYPESCHEDULE                   = 0x1511000000000000,
        SEASONDAYTYPESCHEDULE_DAYTYPE           = 0x1511000000000109,
        SEASONDAYTYPESCHEDULE_SEASON            = 0x1511000000000209,

        SWITCHSCHEDULE                          = 0x1511100000060000,
        SWITCHSCHEDULE_SWITCH                   = 0x1511100000060109,

        POWERSYSTEMRESOURCE                     = 0x1600000000000000,

        EQUIPMENT                               = 0x1610000000000000,
        EQUIPMENT_AGGREGATE                     = 0x1610000000000101,
        EQUIPMENT_NORMALLYLNSERVICE             = 0x1610000000000201,

        CONDUCTINGEQUIPMENT                     = 0x1611000000000000,

        SWITCH                                  = 0x1611100000000000,
        SWITCH_NORMALOPEN                       = 0x1611100000000101,
        SWITCH_RETAINED                         = 0x1611100000000301,
        SWITCH_SWITCHONCOUNT                    = 0x1611100000000403,
        SWITCH_SWITCHONDATE                     = 0x1611100000000508,
        SWITCH_SWITCHSCHEDULES                  = 0x1611100000000619,

        PROTECTEDSWITCH                         = 0x1611110000000000,
        PROTECTEDSWITCH_RECLOSESEQUENCE         = 0x1611110000000000,

        BREAKER                                 = 0x1611111000030000,

        LOADBREAKSWITCH                         = 0x1611111000040000,      
    }

    [Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE			 = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE	 = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL		  = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8	  = unchecked((long)0xfffffff000000000),		
	}																		
}


