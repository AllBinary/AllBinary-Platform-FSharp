namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type NoDecimalTrigTable =
    [<DefaultValue(false)>] val mutable mathUtil : MathUtil
    [<DefaultValue(false)>] val mutable noDecimalSin : int64[]
    [<DefaultValue(false)>] val mutable noDecimalCos : int64[]
    [<DefaultValue(false)>] val mutable noDecimalTan : int64[]
    [<DefaultValue(false)>] val mutable SCALE : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoDecimalTrigTable
    static member instance with get() : NoDecimalTrigTable = (NoDecimalTrigTable.jclinit(); NoDecimalTrigTable.jcell_instance) and set (jvalue: NoDecimalTrigTable) = (NoDecimalTrigTable.jclinit(); NoDecimalTrigTable.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoDecimalTrigTable.jclinitDone then
            NoDecimalTrigTable.jclinitDone <- true
            NoDecimalTrigTable.jclinitBody()
    static member private jclinitBody() : unit =
        NoDecimalTrigTable.jcell_instance <- (new NoDecimalTrigTable())
        ()
    member this.jfields_NoDecimalTrigTable() : unit =
        this.mathUtil <- MathUtil.getInstance()
        this.SCALE <- 10000
        ()
    
    static member getInstance() : NoDecimalTrigTable =
        NoDecimalTrigTable.instance
    
    new () as this =
        {  }
        then
            this.jfields_NoDecimalTrigTable()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable TOTAL_ANGLE : int = int (AngleFactory.getInstance().TOTAL_ANGLE)
        let mutable MAX_VALUE : int64 = (int64 (Integer.MAX_VALUE))
        this.noDecimalSin <- (Array.zeroCreate<int64> (TOTAL_ANGLE))
        this.noDecimalCos <- (Array.zeroCreate<int64> (TOTAL_ANGLE))
        this.noDecimalTan <- (Array.zeroCreate<int64> (TOTAL_ANGLE + 1))
        this.noDecimalSin.[0] <- 0L
        this.noDecimalSin.[1] <- 174L
        this.noDecimalSin.[2] <- 348L
        this.noDecimalSin.[3] <- 523L
        this.noDecimalSin.[4] <- 697L
        this.noDecimalSin.[5] <- 871L
        this.noDecimalSin.[6] <- 1045L
        this.noDecimalSin.[7] <- 1218L
        this.noDecimalSin.[8] <- 1391L
        this.noDecimalSin.[9] <- 1564L
        this.noDecimalSin.[10] <- 1736L
        this.noDecimalSin.[11] <- 1908L
        this.noDecimalSin.[12] <- 2079L
        this.noDecimalSin.[13] <- 2249L
        this.noDecimalSin.[14] <- 2419L
        this.noDecimalSin.[15] <- 2588L
        this.noDecimalSin.[16] <- 2756L
        this.noDecimalSin.[17] <- 2923L
        this.noDecimalSin.[18] <- 3090L
        this.noDecimalSin.[19] <- 3255L
        this.noDecimalSin.[20] <- 3420L
        this.noDecimalSin.[21] <- 3583L
        this.noDecimalSin.[22] <- 3746L
        this.noDecimalSin.[23] <- 3907L
        this.noDecimalSin.[24] <- 4067L
        this.noDecimalSin.[25] <- 4226L
        this.noDecimalSin.[26] <- 4383L
        this.noDecimalSin.[27] <- 4539L
        this.noDecimalSin.[28] <- 4694L
        this.noDecimalSin.[29] <- 4848L
        this.noDecimalSin.[30] <- 4999L
        this.noDecimalSin.[31] <- 5150L
        this.noDecimalSin.[32] <- 5299L
        this.noDecimalSin.[33] <- 5446L
        this.noDecimalSin.[34] <- 5591L
        this.noDecimalSin.[35] <- 5735L
        this.noDecimalSin.[36] <- 5877L
        this.noDecimalSin.[37] <- 6018L
        this.noDecimalSin.[38] <- 6156L
        this.noDecimalSin.[39] <- 6293L
        this.noDecimalSin.[40] <- 6427L
        this.noDecimalSin.[41] <- 6560L
        this.noDecimalSin.[42] <- 6691L
        this.noDecimalSin.[43] <- 6819L
        this.noDecimalSin.[44] <- 6946L
        this.noDecimalSin.[45] <- 7071L
        this.noDecimalSin.[46] <- 7193L
        this.noDecimalSin.[47] <- 7313L
        this.noDecimalSin.[48] <- 7431L
        this.noDecimalSin.[49] <- 7547L
        this.noDecimalSin.[50] <- 7660L
        this.noDecimalSin.[51] <- 7771L
        this.noDecimalSin.[52] <- 7880L
        this.noDecimalSin.[53] <- 7986L
        this.noDecimalSin.[54] <- 8090L
        this.noDecimalSin.[55] <- 8191L
        this.noDecimalSin.[56] <- 8290L
        this.noDecimalSin.[57] <- 8386L
        this.noDecimalSin.[58] <- 8480L
        this.noDecimalSin.[59] <- 8571L
        this.noDecimalSin.[60] <- 8660L
        this.noDecimalSin.[61] <- 8746L
        this.noDecimalSin.[62] <- 8829L
        this.noDecimalSin.[63] <- 8910L
        this.noDecimalSin.[64] <- 8987L
        this.noDecimalSin.[65] <- 9063L
        this.noDecimalSin.[66] <- 9135L
        this.noDecimalSin.[67] <- 9205L
        this.noDecimalSin.[68] <- 9271L
        this.noDecimalSin.[69] <- 9335L
        this.noDecimalSin.[70] <- 9396L
        this.noDecimalSin.[71] <- 9455L
        this.noDecimalSin.[72] <- 9510L
        this.noDecimalSin.[73] <- 9563L
        this.noDecimalSin.[74] <- 9612L
        this.noDecimalSin.[75] <- 9659L
        this.noDecimalSin.[76] <- 9702L
        this.noDecimalSin.[77] <- 9743L
        this.noDecimalSin.[78] <- 9781L
        this.noDecimalSin.[79] <- 9816L
        this.noDecimalSin.[80] <- 9848L
        this.noDecimalSin.[81] <- 9876L
        this.noDecimalSin.[82] <- 9902L
        this.noDecimalSin.[83] <- 9925L
        this.noDecimalSin.[84] <- 9945L
        this.noDecimalSin.[85] <- 9961L
        this.noDecimalSin.[86] <- 9975L
        this.noDecimalSin.[87] <- 9986L
        this.noDecimalSin.[88] <- 9993L
        this.noDecimalSin.[89] <- 9998L
        this.noDecimalSin.[90] <- 10000L
        this.noDecimalSin.[91] <- 9998L
        this.noDecimalSin.[92] <- 9993L
        this.noDecimalSin.[93] <- 9986L
        this.noDecimalSin.[94] <- 9975L
        this.noDecimalSin.[95] <- 9961L
        this.noDecimalSin.[96] <- 9945L
        this.noDecimalSin.[97] <- 9925L
        this.noDecimalSin.[98] <- 9902L
        this.noDecimalSin.[99] <- 9876L
        this.noDecimalSin.[100] <- 9848L
        this.noDecimalSin.[101] <- 9816L
        this.noDecimalSin.[102] <- 9781L
        this.noDecimalSin.[103] <- 9743L
        this.noDecimalSin.[104] <- 9702L
        this.noDecimalSin.[105] <- 9659L
        this.noDecimalSin.[106] <- 9612L
        this.noDecimalSin.[107] <- 9563L
        this.noDecimalSin.[108] <- 9510L
        this.noDecimalSin.[109] <- 9455L
        this.noDecimalSin.[110] <- 9396L
        this.noDecimalSin.[111] <- 9335L
        this.noDecimalSin.[112] <- 9271L
        this.noDecimalSin.[113] <- 9205L
        this.noDecimalSin.[114] <- 9135L
        this.noDecimalSin.[115] <- 9063L
        this.noDecimalSin.[116] <- 8987L
        this.noDecimalSin.[117] <- 8910L
        this.noDecimalSin.[118] <- 8829L
        this.noDecimalSin.[119] <- 8746L
        this.noDecimalSin.[120] <- 8660L
        this.noDecimalSin.[121] <- 8571L
        this.noDecimalSin.[122] <- 8480L
        this.noDecimalSin.[123] <- 8386L
        this.noDecimalSin.[124] <- 8290L
        this.noDecimalSin.[125] <- 8191L
        this.noDecimalSin.[126] <- 8090L
        this.noDecimalSin.[127] <- 7986L
        this.noDecimalSin.[128] <- 7880L
        this.noDecimalSin.[129] <- 7771L
        this.noDecimalSin.[130] <- 7660L
        this.noDecimalSin.[131] <- 7547L
        this.noDecimalSin.[132] <- 7431L
        this.noDecimalSin.[133] <- 7313L
        this.noDecimalSin.[134] <- 7193L
        this.noDecimalSin.[135] <- 7071L
        this.noDecimalSin.[136] <- 6946L
        this.noDecimalSin.[137] <- 6819L
        this.noDecimalSin.[138] <- 6691L
        this.noDecimalSin.[139] <- 6560L
        this.noDecimalSin.[140] <- 6427L
        this.noDecimalSin.[141] <- 6293L
        this.noDecimalSin.[142] <- 6156L
        this.noDecimalSin.[143] <- 6018L
        this.noDecimalSin.[144] <- 5877L
        this.noDecimalSin.[145] <- 5735L
        this.noDecimalSin.[146] <- 5591L
        this.noDecimalSin.[147] <- 5446L
        this.noDecimalSin.[148] <- 5299L
        this.noDecimalSin.[149] <- 5150L
        this.noDecimalSin.[150] <- 4999L
        this.noDecimalSin.[151] <- 4848L
        this.noDecimalSin.[152] <- 4694L
        this.noDecimalSin.[153] <- 4539L
        this.noDecimalSin.[154] <- 4383L
        this.noDecimalSin.[155] <- 4226L
        this.noDecimalSin.[156] <- 4067L
        this.noDecimalSin.[157] <- 3907L
        this.noDecimalSin.[158] <- 3746L
        this.noDecimalSin.[159] <- 3583L
        this.noDecimalSin.[160] <- 3420L
        this.noDecimalSin.[161] <- 3255L
        this.noDecimalSin.[162] <- 3090L
        this.noDecimalSin.[163] <- 2923L
        this.noDecimalSin.[164] <- 2756L
        this.noDecimalSin.[165] <- 2588L
        this.noDecimalSin.[166] <- 2419L
        this.noDecimalSin.[167] <- 2249L
        this.noDecimalSin.[168] <- 2079L
        this.noDecimalSin.[169] <- 1908L
        this.noDecimalSin.[170] <- 1736L
        this.noDecimalSin.[171] <- 1564L
        this.noDecimalSin.[172] <- 1391L
        this.noDecimalSin.[173] <- 1218L
        this.noDecimalSin.[174] <- 1045L
        this.noDecimalSin.[175] <- 871L
        this.noDecimalSin.[176] <- 697L
        this.noDecimalSin.[177] <- 523L
        this.noDecimalSin.[178] <- 348L
        this.noDecimalSin.[179] <- 174L
        this.noDecimalSin.[180] <- 0L
        this.noDecimalSin.[181] <- int64 (-174)
        this.noDecimalSin.[182] <- int64 (-348)
        this.noDecimalSin.[183] <- int64 (-523)
        this.noDecimalSin.[184] <- int64 (-697)
        this.noDecimalSin.[185] <- int64 (-871)
        this.noDecimalSin.[186] <- int64 (-1045)
        this.noDecimalSin.[187] <- int64 (-1218)
        this.noDecimalSin.[188] <- int64 (-1391)
        this.noDecimalSin.[189] <- int64 (-1564)
        this.noDecimalSin.[190] <- int64 (-1736)
        this.noDecimalSin.[191] <- int64 (-1908)
        this.noDecimalSin.[192] <- int64 (-2079)
        this.noDecimalSin.[193] <- int64 (-2249)
        this.noDecimalSin.[194] <- int64 (-2419)
        this.noDecimalSin.[195] <- int64 (-2588)
        this.noDecimalSin.[196] <- int64 (-2756)
        this.noDecimalSin.[197] <- int64 (-2923)
        this.noDecimalSin.[198] <- int64 (-3090)
        this.noDecimalSin.[199] <- int64 (-3255)
        this.noDecimalSin.[200] <- int64 (-3420)
        this.noDecimalSin.[201] <- int64 (-3583)
        this.noDecimalSin.[202] <- int64 (-3746)
        this.noDecimalSin.[203] <- int64 (-3907)
        this.noDecimalSin.[204] <- int64 (-4067)
        this.noDecimalSin.[205] <- int64 (-4226)
        this.noDecimalSin.[206] <- int64 (-4383)
        this.noDecimalSin.[207] <- int64 (-4539)
        this.noDecimalSin.[208] <- int64 (-4694)
        this.noDecimalSin.[209] <- int64 (-4848)
        this.noDecimalSin.[210] <- int64 (-5000)
        this.noDecimalSin.[211] <- int64 (-5150)
        this.noDecimalSin.[212] <- int64 (-5299)
        this.noDecimalSin.[213] <- int64 (-5446)
        this.noDecimalSin.[214] <- int64 (-5591)
        this.noDecimalSin.[215] <- int64 (-5735)
        this.noDecimalSin.[216] <- int64 (-5877)
        this.noDecimalSin.[217] <- int64 (-6018)
        this.noDecimalSin.[218] <- int64 (-6156)
        this.noDecimalSin.[219] <- int64 (-6293)
        this.noDecimalSin.[220] <- int64 (-6427)
        this.noDecimalSin.[221] <- int64 (-6560)
        this.noDecimalSin.[222] <- int64 (-6691)
        this.noDecimalSin.[223] <- int64 (-6819)
        this.noDecimalSin.[224] <- int64 (-6946)
        this.noDecimalSin.[225] <- int64 (-7071)
        this.noDecimalSin.[226] <- int64 (-7193)
        this.noDecimalSin.[227] <- int64 (-7313)
        this.noDecimalSin.[228] <- int64 (-7431)
        this.noDecimalSin.[229] <- int64 (-7547)
        this.noDecimalSin.[230] <- int64 (-7660)
        this.noDecimalSin.[231] <- int64 (-7771)
        this.noDecimalSin.[232] <- int64 (-7880)
        this.noDecimalSin.[233] <- int64 (-7986)
        this.noDecimalSin.[234] <- int64 (-8090)
        this.noDecimalSin.[235] <- int64 (-8191)
        this.noDecimalSin.[236] <- int64 (-8290)
        this.noDecimalSin.[237] <- int64 (-8386)
        this.noDecimalSin.[238] <- int64 (-8480)
        this.noDecimalSin.[239] <- int64 (-8571)
        this.noDecimalSin.[240] <- int64 (-8660)
        this.noDecimalSin.[241] <- int64 (-8746)
        this.noDecimalSin.[242] <- int64 (-8829)
        this.noDecimalSin.[243] <- int64 (-8910)
        this.noDecimalSin.[244] <- int64 (-8987)
        this.noDecimalSin.[245] <- int64 (-9063)
        this.noDecimalSin.[246] <- int64 (-9135)
        this.noDecimalSin.[247] <- int64 (-9205)
        this.noDecimalSin.[248] <- int64 (-9271)
        this.noDecimalSin.[249] <- int64 (-9335)
        this.noDecimalSin.[250] <- int64 (-9396)
        this.noDecimalSin.[251] <- int64 (-9455)
        this.noDecimalSin.[252] <- int64 (-9510)
        this.noDecimalSin.[253] <- int64 (-9563)
        this.noDecimalSin.[254] <- int64 (-9612)
        this.noDecimalSin.[255] <- int64 (-9659)
        this.noDecimalSin.[256] <- int64 (-9702)
        this.noDecimalSin.[257] <- int64 (-9743)
        this.noDecimalSin.[258] <- int64 (-9781)
        this.noDecimalSin.[259] <- int64 (-9816)
        this.noDecimalSin.[260] <- int64 (-9848)
        this.noDecimalSin.[261] <- int64 (-9876)
        this.noDecimalSin.[262] <- int64 (-9902)
        this.noDecimalSin.[263] <- int64 (-9925)
        this.noDecimalSin.[264] <- int64 (-9945)
        this.noDecimalSin.[265] <- int64 (-9961)
        this.noDecimalSin.[266] <- int64 (-9975)
        this.noDecimalSin.[267] <- int64 (-9986)
        this.noDecimalSin.[268] <- int64 (-9993)
        this.noDecimalSin.[269] <- int64 (-9998)
        this.noDecimalSin.[270] <- int64 (-10000)
        this.noDecimalSin.[271] <- int64 (-9998)
        this.noDecimalSin.[272] <- int64 (-9993)
        this.noDecimalSin.[273] <- int64 (-9986)
        this.noDecimalSin.[274] <- int64 (-9975)
        this.noDecimalSin.[275] <- int64 (-9961)
        this.noDecimalSin.[276] <- int64 (-9945)
        this.noDecimalSin.[277] <- int64 (-9925)
        this.noDecimalSin.[278] <- int64 (-9902)
        this.noDecimalSin.[279] <- int64 (-9876)
        this.noDecimalSin.[280] <- int64 (-9848)
        this.noDecimalSin.[281] <- int64 (-9816)
        this.noDecimalSin.[282] <- int64 (-9781)
        this.noDecimalSin.[283] <- int64 (-9743)
        this.noDecimalSin.[284] <- int64 (-9702)
        this.noDecimalSin.[285] <- int64 (-9659)
        this.noDecimalSin.[286] <- int64 (-9612)
        this.noDecimalSin.[287] <- int64 (-9563)
        this.noDecimalSin.[288] <- int64 (-9510)
        this.noDecimalSin.[289] <- int64 (-9455)
        this.noDecimalSin.[290] <- int64 (-9396)
        this.noDecimalSin.[291] <- int64 (-9335)
        this.noDecimalSin.[292] <- int64 (-9271)
        this.noDecimalSin.[293] <- int64 (-9205)
        this.noDecimalSin.[294] <- int64 (-9135)
        this.noDecimalSin.[295] <- int64 (-9063)
        this.noDecimalSin.[296] <- int64 (-8987)
        this.noDecimalSin.[297] <- int64 (-8910)
        this.noDecimalSin.[298] <- int64 (-8829)
        this.noDecimalSin.[299] <- int64 (-8746)
        this.noDecimalSin.[300] <- int64 (-8660)
        this.noDecimalSin.[301] <- int64 (-8571)
        this.noDecimalSin.[302] <- int64 (-8480)
        this.noDecimalSin.[303] <- int64 (-8386)
        this.noDecimalSin.[304] <- int64 (-8290)
        this.noDecimalSin.[305] <- int64 (-8191)
        this.noDecimalSin.[306] <- int64 (-8090)
        this.noDecimalSin.[307] <- int64 (-7986)
        this.noDecimalSin.[308] <- int64 (-7880)
        this.noDecimalSin.[309] <- int64 (-7771)
        this.noDecimalSin.[310] <- int64 (-7660)
        this.noDecimalSin.[311] <- int64 (-7547)
        this.noDecimalSin.[312] <- int64 (-7431)
        this.noDecimalSin.[313] <- int64 (-7313)
        this.noDecimalSin.[314] <- int64 (-7193)
        this.noDecimalSin.[315] <- int64 (-7071)
        this.noDecimalSin.[316] <- int64 (-6946)
        this.noDecimalSin.[317] <- int64 (-6819)
        this.noDecimalSin.[318] <- int64 (-6691)
        this.noDecimalSin.[319] <- int64 (-6560)
        this.noDecimalSin.[320] <- int64 (-6427)
        this.noDecimalSin.[321] <- int64 (-6293)
        this.noDecimalSin.[322] <- int64 (-6156)
        this.noDecimalSin.[323] <- int64 (-6018)
        this.noDecimalSin.[324] <- int64 (-5877)
        this.noDecimalSin.[325] <- int64 (-5735)
        this.noDecimalSin.[326] <- int64 (-5591)
        this.noDecimalSin.[327] <- int64 (-5446)
        this.noDecimalSin.[328] <- int64 (-5299)
        this.noDecimalSin.[329] <- int64 (-5150)
        this.noDecimalSin.[330] <- int64 (-5000)
        this.noDecimalSin.[331] <- int64 (-4848)
        this.noDecimalSin.[332] <- int64 (-4694)
        this.noDecimalSin.[333] <- int64 (-4539)
        this.noDecimalSin.[334] <- int64 (-4383)
        this.noDecimalSin.[335] <- int64 (-4226)
        this.noDecimalSin.[336] <- int64 (-4067)
        this.noDecimalSin.[337] <- int64 (-3907)
        this.noDecimalSin.[338] <- int64 (-3746)
        this.noDecimalSin.[339] <- int64 (-3583)
        this.noDecimalSin.[340] <- int64 (-3420)
        this.noDecimalSin.[341] <- int64 (-3255)
        this.noDecimalSin.[342] <- int64 (-3090)
        this.noDecimalSin.[343] <- int64 (-2923)
        this.noDecimalSin.[344] <- int64 (-2756)
        this.noDecimalSin.[345] <- int64 (-2588)
        this.noDecimalSin.[346] <- int64 (-2419)
        this.noDecimalSin.[347] <- int64 (-2249)
        this.noDecimalSin.[348] <- int64 (-2079)
        this.noDecimalSin.[349] <- int64 (-1908)
        this.noDecimalSin.[350] <- int64 (-1736)
        this.noDecimalSin.[351] <- int64 (-1564)
        this.noDecimalSin.[352] <- int64 (-1391)
        this.noDecimalSin.[353] <- int64 (-1218)
        this.noDecimalSin.[354] <- int64 (-1045)
        this.noDecimalSin.[355] <- int64 (-871)
        this.noDecimalSin.[356] <- int64 (-697)
        this.noDecimalSin.[357] <- int64 (-523)
        this.noDecimalSin.[358] <- int64 (-348)
        this.noDecimalSin.[359] <- int64 (-174)
        this.noDecimalCos.[0] <- 10000L
        this.noDecimalCos.[1] <- 9998L
        this.noDecimalCos.[2] <- 9993L
        this.noDecimalCos.[3] <- 9986L
        this.noDecimalCos.[4] <- 9975L
        this.noDecimalCos.[5] <- 9961L
        this.noDecimalCos.[6] <- 9945L
        this.noDecimalCos.[7] <- 9925L
        this.noDecimalCos.[8] <- 9902L
        this.noDecimalCos.[9] <- 9876L
        this.noDecimalCos.[10] <- 9848L
        this.noDecimalCos.[11] <- 9816L
        this.noDecimalCos.[12] <- 9781L
        this.noDecimalCos.[13] <- 9743L
        this.noDecimalCos.[14] <- 9702L
        this.noDecimalCos.[15] <- 9659L
        this.noDecimalCos.[16] <- 9612L
        this.noDecimalCos.[17] <- 9563L
        this.noDecimalCos.[18] <- 9510L
        this.noDecimalCos.[19] <- 9455L
        this.noDecimalCos.[20] <- 9396L
        this.noDecimalCos.[21] <- 9335L
        this.noDecimalCos.[22] <- 9271L
        this.noDecimalCos.[23] <- 9205L
        this.noDecimalCos.[24] <- 9135L
        this.noDecimalCos.[25] <- 9063L
        this.noDecimalCos.[26] <- 8987L
        this.noDecimalCos.[27] <- 8910L
        this.noDecimalCos.[28] <- 8829L
        this.noDecimalCos.[29] <- 8746L
        this.noDecimalCos.[30] <- 8660L
        this.noDecimalCos.[31] <- 8571L
        this.noDecimalCos.[32] <- 8480L
        this.noDecimalCos.[33] <- 8386L
        this.noDecimalCos.[34] <- 8290L
        this.noDecimalCos.[35] <- 8191L
        this.noDecimalCos.[36] <- 8090L
        this.noDecimalCos.[37] <- 7986L
        this.noDecimalCos.[38] <- 7880L
        this.noDecimalCos.[39] <- 7771L
        this.noDecimalCos.[40] <- 7660L
        this.noDecimalCos.[41] <- 7547L
        this.noDecimalCos.[42] <- 7431L
        this.noDecimalCos.[43] <- 7313L
        this.noDecimalCos.[44] <- 7193L
        this.noDecimalCos.[45] <- 7071L
        this.noDecimalCos.[46] <- 6946L
        this.noDecimalCos.[47] <- 6819L
        this.noDecimalCos.[48] <- 6691L
        this.noDecimalCos.[49] <- 6560L
        this.noDecimalCos.[50] <- 6427L
        this.noDecimalCos.[51] <- 6293L
        this.noDecimalCos.[52] <- 6156L
        this.noDecimalCos.[53] <- 6018L
        this.noDecimalCos.[54] <- 5877L
        this.noDecimalCos.[55] <- 5735L
        this.noDecimalCos.[56] <- 5591L
        this.noDecimalCos.[57] <- 5446L
        this.noDecimalCos.[58] <- 5299L
        this.noDecimalCos.[59] <- 5150L
        this.noDecimalCos.[60] <- 5000L
        this.noDecimalCos.[61] <- 4848L
        this.noDecimalCos.[62] <- 4694L
        this.noDecimalCos.[63] <- 4539L
        this.noDecimalCos.[64] <- 4383L
        this.noDecimalCos.[65] <- 4226L
        this.noDecimalCos.[66] <- 4067L
        this.noDecimalCos.[67] <- 3907L
        this.noDecimalCos.[68] <- 3746L
        this.noDecimalCos.[69] <- 3583L
        this.noDecimalCos.[70] <- 3420L
        this.noDecimalCos.[71] <- 3255L
        this.noDecimalCos.[72] <- 3090L
        this.noDecimalCos.[73] <- 2923L
        this.noDecimalCos.[74] <- 2756L
        this.noDecimalCos.[75] <- 2588L
        this.noDecimalCos.[76] <- 2419L
        this.noDecimalCos.[77] <- 2249L
        this.noDecimalCos.[78] <- 2079L
        this.noDecimalCos.[79] <- 1908L
        this.noDecimalCos.[80] <- 1736L
        this.noDecimalCos.[81] <- 1564L
        this.noDecimalCos.[82] <- 1391L
        this.noDecimalCos.[83] <- 1218L
        this.noDecimalCos.[84] <- 1045L
        this.noDecimalCos.[85] <- 871L
        this.noDecimalCos.[86] <- 697L
        this.noDecimalCos.[87] <- 523L
        this.noDecimalCos.[88] <- 348L
        this.noDecimalCos.[89] <- 174L
        this.noDecimalCos.[90] <- 0L
        this.noDecimalCos.[91] <- int64 (-174)
        this.noDecimalCos.[92] <- int64 (-348)
        this.noDecimalCos.[93] <- int64 (-523)
        this.noDecimalCos.[94] <- int64 (-697)
        this.noDecimalCos.[95] <- int64 (-871)
        this.noDecimalCos.[96] <- int64 (-1045)
        this.noDecimalCos.[97] <- int64 (-1218)
        this.noDecimalCos.[98] <- int64 (-1391)
        this.noDecimalCos.[99] <- int64 (-1564)
        this.noDecimalCos.[100] <- int64 (-1736)
        this.noDecimalCos.[101] <- int64 (-1908)
        this.noDecimalCos.[102] <- int64 (-2079)
        this.noDecimalCos.[103] <- int64 (-2249)
        this.noDecimalCos.[104] <- int64 (-2419)
        this.noDecimalCos.[105] <- int64 (-2588)
        this.noDecimalCos.[106] <- int64 (-2756)
        this.noDecimalCos.[107] <- int64 (-2923)
        this.noDecimalCos.[108] <- int64 (-3090)
        this.noDecimalCos.[109] <- int64 (-3255)
        this.noDecimalCos.[110] <- int64 (-3420)
        this.noDecimalCos.[111] <- int64 (-3583)
        this.noDecimalCos.[112] <- int64 (-3746)
        this.noDecimalCos.[113] <- int64 (-3907)
        this.noDecimalCos.[114] <- int64 (-4067)
        this.noDecimalCos.[115] <- int64 (-4226)
        this.noDecimalCos.[116] <- int64 (-4383)
        this.noDecimalCos.[117] <- int64 (-4539)
        this.noDecimalCos.[118] <- int64 (-4694)
        this.noDecimalCos.[119] <- int64 (-4848)
        this.noDecimalCos.[120] <- int64 (-4999)
        this.noDecimalCos.[121] <- int64 (-5150)
        this.noDecimalCos.[122] <- int64 (-5299)
        this.noDecimalCos.[123] <- int64 (-5446)
        this.noDecimalCos.[124] <- int64 (-5591)
        this.noDecimalCos.[125] <- int64 (-5735)
        this.noDecimalCos.[126] <- int64 (-5877)
        this.noDecimalCos.[127] <- int64 (-6018)
        this.noDecimalCos.[128] <- int64 (-6156)
        this.noDecimalCos.[129] <- int64 (-6293)
        this.noDecimalCos.[130] <- int64 (-6427)
        this.noDecimalCos.[131] <- int64 (-6560)
        this.noDecimalCos.[132] <- int64 (-6691)
        this.noDecimalCos.[133] <- int64 (-6819)
        this.noDecimalCos.[134] <- int64 (-6946)
        this.noDecimalCos.[135] <- int64 (-7071)
        this.noDecimalCos.[136] <- int64 (-7193)
        this.noDecimalCos.[137] <- int64 (-7313)
        this.noDecimalCos.[138] <- int64 (-7431)
        this.noDecimalCos.[139] <- int64 (-7547)
        this.noDecimalCos.[140] <- int64 (-7660)
        this.noDecimalCos.[141] <- int64 (-7771)
        this.noDecimalCos.[142] <- int64 (-7880)
        this.noDecimalCos.[143] <- int64 (-7986)
        this.noDecimalCos.[144] <- int64 (-8090)
        this.noDecimalCos.[145] <- int64 (-8191)
        this.noDecimalCos.[146] <- int64 (-8290)
        this.noDecimalCos.[147] <- int64 (-8386)
        this.noDecimalCos.[148] <- int64 (-8480)
        this.noDecimalCos.[149] <- int64 (-8571)
        this.noDecimalCos.[150] <- int64 (-8660)
        this.noDecimalCos.[151] <- int64 (-8746)
        this.noDecimalCos.[152] <- int64 (-8829)
        this.noDecimalCos.[153] <- int64 (-8910)
        this.noDecimalCos.[154] <- int64 (-8987)
        this.noDecimalCos.[155] <- int64 (-9063)
        this.noDecimalCos.[156] <- int64 (-9135)
        this.noDecimalCos.[157] <- int64 (-9205)
        this.noDecimalCos.[158] <- int64 (-9271)
        this.noDecimalCos.[159] <- int64 (-9335)
        this.noDecimalCos.[160] <- int64 (-9396)
        this.noDecimalCos.[161] <- int64 (-9455)
        this.noDecimalCos.[162] <- int64 (-9510)
        this.noDecimalCos.[163] <- int64 (-9563)
        this.noDecimalCos.[164] <- int64 (-9612)
        this.noDecimalCos.[165] <- int64 (-9659)
        this.noDecimalCos.[166] <- int64 (-9702)
        this.noDecimalCos.[167] <- int64 (-9743)
        this.noDecimalCos.[168] <- int64 (-9781)
        this.noDecimalCos.[169] <- int64 (-9816)
        this.noDecimalCos.[170] <- int64 (-9848)
        this.noDecimalCos.[171] <- int64 (-9876)
        this.noDecimalCos.[172] <- int64 (-9902)
        this.noDecimalCos.[173] <- int64 (-9925)
        this.noDecimalCos.[174] <- int64 (-9945)
        this.noDecimalCos.[175] <- int64 (-9961)
        this.noDecimalCos.[176] <- int64 (-9975)
        this.noDecimalCos.[177] <- int64 (-9986)
        this.noDecimalCos.[178] <- int64 (-9993)
        this.noDecimalCos.[179] <- int64 (-9998)
        this.noDecimalCos.[180] <- int64 (-10000)
        this.noDecimalCos.[181] <- int64 (-9998)
        this.noDecimalCos.[182] <- int64 (-9993)
        this.noDecimalCos.[183] <- int64 (-9986)
        this.noDecimalCos.[184] <- int64 (-9975)
        this.noDecimalCos.[185] <- int64 (-9961)
        this.noDecimalCos.[186] <- int64 (-9945)
        this.noDecimalCos.[187] <- int64 (-9925)
        this.noDecimalCos.[188] <- int64 (-9902)
        this.noDecimalCos.[189] <- int64 (-9876)
        this.noDecimalCos.[190] <- int64 (-9848)
        this.noDecimalCos.[191] <- int64 (-9816)
        this.noDecimalCos.[192] <- int64 (-9781)
        this.noDecimalCos.[193] <- int64 (-9743)
        this.noDecimalCos.[194] <- int64 (-9702)
        this.noDecimalCos.[195] <- int64 (-9659)
        this.noDecimalCos.[196] <- int64 (-9612)
        this.noDecimalCos.[197] <- int64 (-9563)
        this.noDecimalCos.[198] <- int64 (-9510)
        this.noDecimalCos.[199] <- int64 (-9455)
        this.noDecimalCos.[200] <- int64 (-9396)
        this.noDecimalCos.[201] <- int64 (-9335)
        this.noDecimalCos.[202] <- int64 (-9271)
        this.noDecimalCos.[203] <- int64 (-9205)
        this.noDecimalCos.[204] <- int64 (-9135)
        this.noDecimalCos.[205] <- int64 (-9063)
        this.noDecimalCos.[206] <- int64 (-8987)
        this.noDecimalCos.[207] <- int64 (-8910)
        this.noDecimalCos.[208] <- int64 (-8829)
        this.noDecimalCos.[209] <- int64 (-8746)
        this.noDecimalCos.[210] <- int64 (-8660)
        this.noDecimalCos.[211] <- int64 (-8571)
        this.noDecimalCos.[212] <- int64 (-8480)
        this.noDecimalCos.[213] <- int64 (-8386)
        this.noDecimalCos.[214] <- int64 (-8290)
        this.noDecimalCos.[215] <- int64 (-8191)
        this.noDecimalCos.[216] <- int64 (-8090)
        this.noDecimalCos.[217] <- int64 (-7986)
        this.noDecimalCos.[218] <- int64 (-7880)
        this.noDecimalCos.[219] <- int64 (-7771)
        this.noDecimalCos.[220] <- int64 (-7660)
        this.noDecimalCos.[221] <- int64 (-7547)
        this.noDecimalCos.[222] <- int64 (-7431)
        this.noDecimalCos.[223] <- int64 (-7313)
        this.noDecimalCos.[224] <- int64 (-7193)
        this.noDecimalCos.[225] <- int64 (-7071)
        this.noDecimalCos.[226] <- int64 (-6946)
        this.noDecimalCos.[227] <- int64 (-6819)
        this.noDecimalCos.[228] <- int64 (-6691)
        this.noDecimalCos.[229] <- int64 (-6560)
        this.noDecimalCos.[230] <- int64 (-6427)
        this.noDecimalCos.[231] <- int64 (-6293)
        this.noDecimalCos.[232] <- int64 (-6156)
        this.noDecimalCos.[233] <- int64 (-6018)
        this.noDecimalCos.[234] <- int64 (-5877)
        this.noDecimalCos.[235] <- int64 (-5735)
        this.noDecimalCos.[236] <- int64 (-5591)
        this.noDecimalCos.[237] <- int64 (-5446)
        this.noDecimalCos.[238] <- int64 (-5299)
        this.noDecimalCos.[239] <- int64 (-5150)
        this.noDecimalCos.[240] <- int64 (-5000)
        this.noDecimalCos.[241] <- int64 (-4848)
        this.noDecimalCos.[242] <- int64 (-4694)
        this.noDecimalCos.[243] <- int64 (-4539)
        this.noDecimalCos.[244] <- int64 (-4383)
        this.noDecimalCos.[245] <- int64 (-4226)
        this.noDecimalCos.[246] <- int64 (-4067)
        this.noDecimalCos.[247] <- int64 (-3907)
        this.noDecimalCos.[248] <- int64 (-3746)
        this.noDecimalCos.[249] <- int64 (-3583)
        this.noDecimalCos.[250] <- int64 (-3420)
        this.noDecimalCos.[251] <- int64 (-3255)
        this.noDecimalCos.[252] <- int64 (-3090)
        this.noDecimalCos.[253] <- int64 (-2923)
        this.noDecimalCos.[254] <- int64 (-2756)
        this.noDecimalCos.[255] <- int64 (-2588)
        this.noDecimalCos.[256] <- int64 (-2419)
        this.noDecimalCos.[257] <- int64 (-2249)
        this.noDecimalCos.[258] <- int64 (-2079)
        this.noDecimalCos.[259] <- int64 (-1908)
        this.noDecimalCos.[260] <- int64 (-1736)
        this.noDecimalCos.[261] <- int64 (-1564)
        this.noDecimalCos.[262] <- int64 (-1391)
        this.noDecimalCos.[263] <- int64 (-1218)
        this.noDecimalCos.[264] <- int64 (-1045)
        this.noDecimalCos.[265] <- int64 (-871)
        this.noDecimalCos.[266] <- int64 (-697)
        this.noDecimalCos.[267] <- int64 (-523)
        this.noDecimalCos.[268] <- int64 (-348)
        this.noDecimalCos.[269] <- int64 (-174)
        this.noDecimalCos.[270] <- 0L
        this.noDecimalCos.[271] <- 174L
        this.noDecimalCos.[272] <- 348L
        this.noDecimalCos.[273] <- 523L
        this.noDecimalCos.[274] <- 697L
        this.noDecimalCos.[275] <- 871L
        this.noDecimalCos.[276] <- 1045L
        this.noDecimalCos.[277] <- 1218L
        this.noDecimalCos.[278] <- 1391L
        this.noDecimalCos.[279] <- 1564L
        this.noDecimalCos.[280] <- 1736L
        this.noDecimalCos.[281] <- 1908L
        this.noDecimalCos.[282] <- 2079L
        this.noDecimalCos.[283] <- 2249L
        this.noDecimalCos.[284] <- 2419L
        this.noDecimalCos.[285] <- 2588L
        this.noDecimalCos.[286] <- 2756L
        this.noDecimalCos.[287] <- 2923L
        this.noDecimalCos.[288] <- 3090L
        this.noDecimalCos.[289] <- 3255L
        this.noDecimalCos.[290] <- 3420L
        this.noDecimalCos.[291] <- 3583L
        this.noDecimalCos.[292] <- 3746L
        this.noDecimalCos.[293] <- 3907L
        this.noDecimalCos.[294] <- 4067L
        this.noDecimalCos.[295] <- 4226L
        this.noDecimalCos.[296] <- 4383L
        this.noDecimalCos.[297] <- 4539L
        this.noDecimalCos.[298] <- 4694L
        this.noDecimalCos.[299] <- 4848L
        this.noDecimalCos.[300] <- 5000L
        this.noDecimalCos.[301] <- 5150L
        this.noDecimalCos.[302] <- 5299L
        this.noDecimalCos.[303] <- 5446L
        this.noDecimalCos.[304] <- 5591L
        this.noDecimalCos.[305] <- 5735L
        this.noDecimalCos.[306] <- 5877L
        this.noDecimalCos.[307] <- 6018L
        this.noDecimalCos.[308] <- 6156L
        this.noDecimalCos.[309] <- 6293L
        this.noDecimalCos.[310] <- 6427L
        this.noDecimalCos.[311] <- 6560L
        this.noDecimalCos.[312] <- 6691L
        this.noDecimalCos.[313] <- 6819L
        this.noDecimalCos.[314] <- 6946L
        this.noDecimalCos.[315] <- 7071L
        this.noDecimalCos.[316] <- 7193L
        this.noDecimalCos.[317] <- 7313L
        this.noDecimalCos.[318] <- 7431L
        this.noDecimalCos.[319] <- 7547L
        this.noDecimalCos.[320] <- 7660L
        this.noDecimalCos.[321] <- 7771L
        this.noDecimalCos.[322] <- 7880L
        this.noDecimalCos.[323] <- 7986L
        this.noDecimalCos.[324] <- 8090L
        this.noDecimalCos.[325] <- 8191L
        this.noDecimalCos.[326] <- 8290L
        this.noDecimalCos.[327] <- 8386L
        this.noDecimalCos.[328] <- 8480L
        this.noDecimalCos.[329] <- 8571L
        this.noDecimalCos.[330] <- 8660L
        this.noDecimalCos.[331] <- 8746L
        this.noDecimalCos.[332] <- 8829L
        this.noDecimalCos.[333] <- 8910L
        this.noDecimalCos.[334] <- 8987L
        this.noDecimalCos.[335] <- 9063L
        this.noDecimalCos.[336] <- 9135L
        this.noDecimalCos.[337] <- 9205L
        this.noDecimalCos.[338] <- 9271L
        this.noDecimalCos.[339] <- 9335L
        this.noDecimalCos.[340] <- 9396L
        this.noDecimalCos.[341] <- 9455L
        this.noDecimalCos.[342] <- 9510L
        this.noDecimalCos.[343] <- 9563L
        this.noDecimalCos.[344] <- 9612L
        this.noDecimalCos.[345] <- 9659L
        this.noDecimalCos.[346] <- 9702L
        this.noDecimalCos.[347] <- 9743L
        this.noDecimalCos.[348] <- 9781L
        this.noDecimalCos.[349] <- 9816L
        this.noDecimalCos.[350] <- 9848L
        this.noDecimalCos.[351] <- 9876L
        this.noDecimalCos.[352] <- 9902L
        this.noDecimalCos.[353] <- 9925L
        this.noDecimalCos.[354] <- 9945L
        this.noDecimalCos.[355] <- 9961L
        this.noDecimalCos.[356] <- 9975L
        this.noDecimalCos.[357] <- 9986L
        this.noDecimalCos.[358] <- 9993L
        this.noDecimalCos.[359] <- 9998L
        this.noDecimalTan.[0] <- 0L
        this.noDecimalTan.[1] <- 174L
        this.noDecimalTan.[2] <- 349L
        this.noDecimalTan.[3] <- 524L
        this.noDecimalTan.[4] <- 699L
        this.noDecimalTan.[5] <- 874L
        this.noDecimalTan.[6] <- 1051L
        this.noDecimalTan.[7] <- 1227L
        this.noDecimalTan.[8] <- 1405L
        this.noDecimalTan.[9] <- 1583L
        this.noDecimalTan.[10] <- 1763L
        this.noDecimalTan.[11] <- 1943L
        this.noDecimalTan.[12] <- 2125L
        this.noDecimalTan.[13] <- 2308L
        this.noDecimalTan.[14] <- 2493L
        this.noDecimalTan.[15] <- 2679L
        this.noDecimalTan.[16] <- 2867L
        this.noDecimalTan.[17] <- 3057L
        this.noDecimalTan.[18] <- 3249L
        this.noDecimalTan.[19] <- 3443L
        this.noDecimalTan.[20] <- 3639L
        this.noDecimalTan.[21] <- 3838L
        this.noDecimalTan.[22] <- 4040L
        this.noDecimalTan.[23] <- 4244L
        this.noDecimalTan.[24] <- 4452L
        this.noDecimalTan.[25] <- 4663L
        this.noDecimalTan.[26] <- 4877L
        this.noDecimalTan.[27] <- 5095L
        this.noDecimalTan.[28] <- 5317L
        this.noDecimalTan.[29] <- 5543L
        this.noDecimalTan.[30] <- 5773L
        this.noDecimalTan.[31] <- 6008L
        this.noDecimalTan.[32] <- 6248L
        this.noDecimalTan.[33] <- 6494L
        this.noDecimalTan.[34] <- 6745L
        this.noDecimalTan.[35] <- 7002L
        this.noDecimalTan.[36] <- 7265L
        this.noDecimalTan.[37] <- 7535L
        this.noDecimalTan.[38] <- 7812L
        this.noDecimalTan.[39] <- 8097L
        this.noDecimalTan.[40] <- 8390L
        this.noDecimalTan.[41] <- 8692L
        this.noDecimalTan.[42] <- 9004L
        this.noDecimalTan.[43] <- 9325L
        this.noDecimalTan.[44] <- 9656L
        this.noDecimalTan.[45] <- 9999L
        this.noDecimalTan.[46] <- 10355L
        this.noDecimalTan.[47] <- 10723L
        this.noDecimalTan.[48] <- 11106L
        this.noDecimalTan.[49] <- 11503L
        this.noDecimalTan.[50] <- 11917L
        this.noDecimalTan.[51] <- 12348L
        this.noDecimalTan.[52] <- 12799L
        this.noDecimalTan.[53] <- 13270L
        this.noDecimalTan.[54] <- 13763L
        this.noDecimalTan.[55] <- 14281L
        this.noDecimalTan.[56] <- 14825L
        this.noDecimalTan.[57] <- 15398L
        this.noDecimalTan.[58] <- 16003L
        this.noDecimalTan.[59] <- 16642L
        this.noDecimalTan.[60] <- 17320L
        this.noDecimalTan.[61] <- 18040L
        this.noDecimalTan.[62] <- 18807L
        this.noDecimalTan.[63] <- 19626L
        this.noDecimalTan.[64] <- 20503L
        this.noDecimalTan.[65] <- 21445L
        this.noDecimalTan.[66] <- 22460L
        this.noDecimalTan.[67] <- 23558L
        this.noDecimalTan.[68] <- 24750L
        this.noDecimalTan.[69] <- 26050L
        this.noDecimalTan.[70] <- 27474L
        this.noDecimalTan.[71] <- 29042L
        this.noDecimalTan.[72] <- 30776L
        this.noDecimalTan.[73] <- 32708L
        this.noDecimalTan.[74] <- 34874L
        this.noDecimalTan.[75] <- 37320L
        this.noDecimalTan.[76] <- 40107L
        this.noDecimalTan.[77] <- 43314L
        this.noDecimalTan.[78] <- 47046L
        this.noDecimalTan.[79] <- 51445L
        this.noDecimalTan.[80] <- 56712L
        this.noDecimalTan.[81] <- 63137L
        this.noDecimalTan.[82] <- 71153L
        this.noDecimalTan.[83] <- 81443L
        this.noDecimalTan.[84] <- 95143L
        this.noDecimalTan.[85] <- 114300L
        this.noDecimalTan.[86] <- 143006L
        this.noDecimalTan.[87] <- 190811L
        this.noDecimalTan.[88] <- 286362L
        this.noDecimalTan.[89] <- 572899L
        this.noDecimalTan.[90] <- MAX_VALUE
        this.noDecimalTan.[91] <- int64 (-572899)
        this.noDecimalTan.[92] <- int64 (-286362)
        this.noDecimalTan.[93] <- int64 (-190811)
        this.noDecimalTan.[94] <- int64 (-143006)
        this.noDecimalTan.[95] <- int64 (-114300)
        this.noDecimalTan.[96] <- int64 (-95143)
        this.noDecimalTan.[97] <- int64 (-81443)
        this.noDecimalTan.[98] <- int64 (-71153)
        this.noDecimalTan.[99] <- int64 (-63137)
        this.noDecimalTan.[100] <- int64 (-56712)
        this.noDecimalTan.[101] <- int64 (-51445)
        this.noDecimalTan.[102] <- int64 (-47046)
        this.noDecimalTan.[103] <- int64 (-43314)
        this.noDecimalTan.[104] <- int64 (-40107)
        this.noDecimalTan.[105] <- int64 (-37320)
        this.noDecimalTan.[106] <- int64 (-34874)
        this.noDecimalTan.[107] <- int64 (-32708)
        this.noDecimalTan.[108] <- int64 (-30776)
        this.noDecimalTan.[109] <- int64 (-29042)
        this.noDecimalTan.[110] <- int64 (-27474)
        this.noDecimalTan.[111] <- int64 (-26050)
        this.noDecimalTan.[112] <- int64 (-24750)
        this.noDecimalTan.[113] <- int64 (-23558)
        this.noDecimalTan.[114] <- int64 (-22460)
        this.noDecimalTan.[115] <- int64 (-21445)
        this.noDecimalTan.[116] <- int64 (-20503)
        this.noDecimalTan.[117] <- int64 (-19626)
        this.noDecimalTan.[118] <- int64 (-18807)
        this.noDecimalTan.[119] <- int64 (-18040)
        this.noDecimalTan.[120] <- int64 (-17320)
        this.noDecimalTan.[121] <- int64 (-16642)
        this.noDecimalTan.[122] <- int64 (-16003)
        this.noDecimalTan.[123] <- int64 (-15398)
        this.noDecimalTan.[124] <- int64 (-14825)
        this.noDecimalTan.[125] <- int64 (-14281)
        this.noDecimalTan.[126] <- int64 (-13763)
        this.noDecimalTan.[127] <- int64 (-13270)
        this.noDecimalTan.[128] <- int64 (-12799)
        this.noDecimalTan.[129] <- int64 (-12348)
        this.noDecimalTan.[130] <- int64 (-11917)
        this.noDecimalTan.[131] <- int64 (-11503)
        this.noDecimalTan.[132] <- int64 (-11106)
        this.noDecimalTan.[133] <- int64 (-10723)
        this.noDecimalTan.[134] <- int64 (-10355)
        this.noDecimalTan.[135] <- int64 (-10000)
        this.noDecimalTan.[136] <- int64 (-9656)
        this.noDecimalTan.[137] <- int64 (-9325)
        this.noDecimalTan.[138] <- int64 (-9004)
        this.noDecimalTan.[139] <- int64 (-8692)
        this.noDecimalTan.[140] <- int64 (-8390)
        this.noDecimalTan.[141] <- int64 (-8097)
        this.noDecimalTan.[142] <- int64 (-7812)
        this.noDecimalTan.[143] <- int64 (-7535)
        this.noDecimalTan.[144] <- int64 (-7265)
        this.noDecimalTan.[145] <- int64 (-7002)
        this.noDecimalTan.[146] <- int64 (-6745)
        this.noDecimalTan.[147] <- int64 (-6494)
        this.noDecimalTan.[148] <- int64 (-6248)
        this.noDecimalTan.[149] <- int64 (-6008)
        this.noDecimalTan.[150] <- int64 (-5773)
        this.noDecimalTan.[151] <- int64 (-5543)
        this.noDecimalTan.[152] <- int64 (-5317)
        this.noDecimalTan.[153] <- int64 (-5095)
        this.noDecimalTan.[154] <- int64 (-4877)
        this.noDecimalTan.[155] <- int64 (-4663)
        this.noDecimalTan.[156] <- int64 (-4452)
        this.noDecimalTan.[157] <- int64 (-4244)
        this.noDecimalTan.[158] <- int64 (-4040)
        this.noDecimalTan.[159] <- int64 (-3838)
        this.noDecimalTan.[160] <- int64 (-3639)
        this.noDecimalTan.[161] <- int64 (-3443)
        this.noDecimalTan.[162] <- int64 (-3249)
        this.noDecimalTan.[163] <- int64 (-3057)
        this.noDecimalTan.[164] <- int64 (-2867)
        this.noDecimalTan.[165] <- int64 (-2679)
        this.noDecimalTan.[166] <- int64 (-2493)
        this.noDecimalTan.[167] <- int64 (-2308)
        this.noDecimalTan.[168] <- int64 (-2125)
        this.noDecimalTan.[169] <- int64 (-1943)
        this.noDecimalTan.[170] <- int64 (-1763)
        this.noDecimalTan.[171] <- int64 (-1583)
        this.noDecimalTan.[172] <- int64 (-1405)
        this.noDecimalTan.[173] <- int64 (-1227)
        this.noDecimalTan.[174] <- int64 (-1051)
        this.noDecimalTan.[175] <- int64 (-874)
        this.noDecimalTan.[176] <- int64 (-699)
        this.noDecimalTan.[177] <- int64 (-524)
        this.noDecimalTan.[178] <- int64 (-349)
        this.noDecimalTan.[179] <- int64 (-174)
        this.noDecimalTan.[180] <- 0L
        this.noDecimalTan.[181] <- 174L
        this.noDecimalTan.[182] <- 349L
        this.noDecimalTan.[183] <- 524L
        this.noDecimalTan.[184] <- 699L
        this.noDecimalTan.[185] <- 874L
        this.noDecimalTan.[186] <- 1051L
        this.noDecimalTan.[187] <- 1227L
        this.noDecimalTan.[188] <- 1405L
        this.noDecimalTan.[189] <- 1583L
        this.noDecimalTan.[190] <- 1763L
        this.noDecimalTan.[191] <- 1943L
        this.noDecimalTan.[192] <- 2125L
        this.noDecimalTan.[193] <- 2308L
        this.noDecimalTan.[194] <- 2493L
        this.noDecimalTan.[195] <- 2679L
        this.noDecimalTan.[196] <- 2867L
        this.noDecimalTan.[197] <- 3057L
        this.noDecimalTan.[198] <- 3249L
        this.noDecimalTan.[199] <- 3443L
        this.noDecimalTan.[200] <- 3639L
        this.noDecimalTan.[201] <- 3838L
        this.noDecimalTan.[202] <- 4040L
        this.noDecimalTan.[203] <- 4244L
        this.noDecimalTan.[204] <- 4452L
        this.noDecimalTan.[205] <- 4663L
        this.noDecimalTan.[206] <- 4877L
        this.noDecimalTan.[207] <- 5095L
        this.noDecimalTan.[208] <- 5317L
        this.noDecimalTan.[209] <- 5543L
        this.noDecimalTan.[210] <- 5773L
        this.noDecimalTan.[211] <- 6008L
        this.noDecimalTan.[212] <- 6248L
        this.noDecimalTan.[213] <- 6494L
        this.noDecimalTan.[214] <- 6745L
        this.noDecimalTan.[215] <- 7002L
        this.noDecimalTan.[216] <- 7265L
        this.noDecimalTan.[217] <- 7535L
        this.noDecimalTan.[218] <- 7812L
        this.noDecimalTan.[219] <- 8097L
        this.noDecimalTan.[220] <- 8390L
        this.noDecimalTan.[221] <- 8692L
        this.noDecimalTan.[222] <- 9004L
        this.noDecimalTan.[223] <- 9325L
        this.noDecimalTan.[224] <- 9656L
        this.noDecimalTan.[225] <- 9999L
        this.noDecimalTan.[226] <- 10355L
        this.noDecimalTan.[227] <- 10723L
        this.noDecimalTan.[228] <- 11106L
        this.noDecimalTan.[229] <- 11503L
        this.noDecimalTan.[230] <- 11917L
        this.noDecimalTan.[231] <- 12348L
        this.noDecimalTan.[232] <- 12799L
        this.noDecimalTan.[233] <- 13270L
        this.noDecimalTan.[234] <- 13763L
        this.noDecimalTan.[235] <- 14281L
        this.noDecimalTan.[236] <- 14825L
        this.noDecimalTan.[237] <- 15398L
        this.noDecimalTan.[238] <- 16003L
        this.noDecimalTan.[239] <- 16642L
        this.noDecimalTan.[240] <- 17320L
        this.noDecimalTan.[241] <- 18040L
        this.noDecimalTan.[242] <- 18807L
        this.noDecimalTan.[243] <- 19626L
        this.noDecimalTan.[244] <- 20503L
        this.noDecimalTan.[245] <- 21445L
        this.noDecimalTan.[246] <- 22460L
        this.noDecimalTan.[247] <- 23558L
        this.noDecimalTan.[248] <- 24750L
        this.noDecimalTan.[249] <- 26050L
        this.noDecimalTan.[250] <- 27474L
        this.noDecimalTan.[251] <- 29042L
        this.noDecimalTan.[252] <- 30776L
        this.noDecimalTan.[253] <- 32708L
        this.noDecimalTan.[254] <- 34874L
        this.noDecimalTan.[255] <- 37320L
        this.noDecimalTan.[256] <- 40107L
        this.noDecimalTan.[257] <- 43314L
        this.noDecimalTan.[258] <- 47046L
        this.noDecimalTan.[259] <- 51445L
        this.noDecimalTan.[260] <- 56712L
        this.noDecimalTan.[261] <- 63137L
        this.noDecimalTan.[262] <- 71153L
        this.noDecimalTan.[263] <- 81443L
        this.noDecimalTan.[264] <- 95143L
        this.noDecimalTan.[265] <- 114300L
        this.noDecimalTan.[266] <- 143006L
        this.noDecimalTan.[267] <- 190811L
        this.noDecimalTan.[268] <- 286362L
        this.noDecimalTan.[269] <- 572899L
        this.noDecimalTan.[270] <- MAX_VALUE
        this.noDecimalTan.[271] <- int64 (-572899)
        this.noDecimalTan.[272] <- int64 (-286362)
        this.noDecimalTan.[273] <- int64 (-190811)
        this.noDecimalTan.[274] <- int64 (-143006)
        this.noDecimalTan.[275] <- int64 (-114300)
        this.noDecimalTan.[276] <- int64 (-95143)
        this.noDecimalTan.[277] <- int64 (-81443)
        this.noDecimalTan.[278] <- int64 (-71153)
        this.noDecimalTan.[279] <- int64 (-63137)
        this.noDecimalTan.[280] <- int64 (-56712)
        this.noDecimalTan.[281] <- int64 (-51445)
        this.noDecimalTan.[282] <- int64 (-47046)
        this.noDecimalTan.[283] <- int64 (-43314)
        this.noDecimalTan.[284] <- int64 (-40107)
        this.noDecimalTan.[285] <- int64 (-37320)
        this.noDecimalTan.[286] <- int64 (-34874)
        this.noDecimalTan.[287] <- int64 (-32708)
        this.noDecimalTan.[288] <- int64 (-30776)
        this.noDecimalTan.[289] <- int64 (-29042)
        this.noDecimalTan.[290] <- int64 (-27474)
        this.noDecimalTan.[291] <- int64 (-26050)
        this.noDecimalTan.[292] <- int64 (-24750)
        this.noDecimalTan.[293] <- int64 (-23558)
        this.noDecimalTan.[294] <- int64 (-22460)
        this.noDecimalTan.[295] <- int64 (-21445)
        this.noDecimalTan.[296] <- int64 (-20503)
        this.noDecimalTan.[297] <- int64 (-19626)
        this.noDecimalTan.[298] <- int64 (-18807)
        this.noDecimalTan.[299] <- int64 (-18040)
        this.noDecimalTan.[300] <- int64 (-17320)
        this.noDecimalTan.[301] <- int64 (-16642)
        this.noDecimalTan.[302] <- int64 (-16003)
        this.noDecimalTan.[303] <- int64 (-15398)
        this.noDecimalTan.[304] <- int64 (-14825)
        this.noDecimalTan.[305] <- int64 (-14281)
        this.noDecimalTan.[306] <- int64 (-13763)
        this.noDecimalTan.[307] <- int64 (-13270)
        this.noDecimalTan.[308] <- int64 (-12799)
        this.noDecimalTan.[309] <- int64 (-12348)
        this.noDecimalTan.[310] <- int64 (-11917)
        this.noDecimalTan.[311] <- int64 (-11503)
        this.noDecimalTan.[312] <- int64 (-11106)
        this.noDecimalTan.[313] <- int64 (-10723)
        this.noDecimalTan.[314] <- int64 (-10355)
        this.noDecimalTan.[315] <- int64 (-10000)
        this.noDecimalTan.[316] <- int64 (-9656)
        this.noDecimalTan.[317] <- int64 (-9325)
        this.noDecimalTan.[318] <- int64 (-9004)
        this.noDecimalTan.[319] <- int64 (-8692)
        this.noDecimalTan.[320] <- int64 (-8390)
        this.noDecimalTan.[321] <- int64 (-8097)
        this.noDecimalTan.[322] <- int64 (-7812)
        this.noDecimalTan.[323] <- int64 (-7535)
        this.noDecimalTan.[324] <- int64 (-7265)
        this.noDecimalTan.[325] <- int64 (-7002)
        this.noDecimalTan.[326] <- int64 (-6745)
        this.noDecimalTan.[327] <- int64 (-6494)
        this.noDecimalTan.[328] <- int64 (-6248)
        this.noDecimalTan.[329] <- int64 (-6008)
        this.noDecimalTan.[330] <- int64 (-5773)
        this.noDecimalTan.[331] <- int64 (-5543)
        this.noDecimalTan.[332] <- int64 (-5317)
        this.noDecimalTan.[333] <- int64 (-5095)
        this.noDecimalTan.[334] <- int64 (-4877)
        this.noDecimalTan.[335] <- int64 (-4663)
        this.noDecimalTan.[336] <- int64 (-4452)
        this.noDecimalTan.[337] <- int64 (-4244)
        this.noDecimalTan.[338] <- int64 (-4040)
        this.noDecimalTan.[339] <- int64 (-3838)
        this.noDecimalTan.[340] <- int64 (-3639)
        this.noDecimalTan.[341] <- int64 (-3443)
        this.noDecimalTan.[342] <- int64 (-3249)
        this.noDecimalTan.[343] <- int64 (-3057)
        this.noDecimalTan.[344] <- int64 (-2867)
        this.noDecimalTan.[345] <- int64 (-2679)
        this.noDecimalTan.[346] <- int64 (-2493)
        this.noDecimalTan.[347] <- int64 (-2308)
        this.noDecimalTan.[348] <- int64 (-2125)
        this.noDecimalTan.[349] <- int64 (-1943)
        this.noDecimalTan.[350] <- int64 (-1763)
        this.noDecimalTan.[351] <- int64 (-1583)
        this.noDecimalTan.[352] <- int64 (-1405)
        this.noDecimalTan.[353] <- int64 (-1227)
        this.noDecimalTan.[354] <- int64 (-1051)
        this.noDecimalTan.[355] <- int64 (-874)
        this.noDecimalTan.[356] <- int64 (-699)
        this.noDecimalTan.[357] <- int64 (-524)
        this.noDecimalTan.[358] <- int64 (-349)
        this.noDecimalTan.[359] <- int64 (-174)
        this.noDecimalTan.[0] <- int64 (-174)
        ()
    
    abstract sin : angle: int -> int64
    default this.sin(angle: int) : int64 =
        this.noDecimalSin.[angle]
    
    abstract cos : angle: int -> int64
    default this.cos(angle: int) : int64 =
        this.noDecimalCos.[angle]
    
    abstract tan : angle: int -> int64
    default this.tan(angle: int) : int64 =
        this.noDecimalTan.[angle]
    
    abstract antiTan : dx: int * dy: int -> int16
    default this.antiTan(dx: int, dy: int) : int16 =
        let mutable jflow = 0
        let mutable jret : int16 = Unchecked.defaultof<int16>
        let mutable MAX_VALUE : int64 = (int64 (Integer.MAX_VALUE))
        let mutable MIN_VALUE : int64 = (int64 (Integer.MIN_VALUE))
        let mutable ratio : int64 = (MAX_VALUE - 1L)
        if dy <> 0 then
            let mutable dxl : int64 = (int64 (dx))
            ratio <- (int64 (this.SCALE) * dxl) / int64 (dy)
            if (dx <= 0) && (dy < 0) then
                ratio <- this.mathUtil.abslong(ratio)
        if ((dx >= 0) && (dy < 0)) then
            let mutable index : int = 180
            while jflow = 0 && (index > 90) do
                if ratio <= this.noDecimalTan.[index] then
                    if ratio > this.noDecimalTan.[index - 1] then
                        jret <- (int16 (index))
                        jflow <- 1
                    elif (this.noDecimalTan.[index - 1] = MAX_VALUE) && (ratio > MIN_VALUE) then
                        jret <- (int16 (index))
                        jflow <- 1
                if jflow = 200004 then jflow <- 0
                if jflow = 0 then index <- index - 1
            if jflow = 100004 then jflow <- 0
        elif ((dx < 0) && (dy <= 0)) then
            let mutable index : int = 270
            while jflow = 0 && (index > 180) do
                if (ratio < this.noDecimalTan.[index]) && (ratio >= this.noDecimalTan.[index - 1]) then
                    jret <- (int16 (index))
                    jflow <- 1
                if jflow = 200003 then jflow <- 0
                if jflow = 0 then index <- index - 1
            if jflow = 100003 then jflow <- 0
        elif ((dx < 0) && (dy > 0)) then
            let mutable index : int = (this.noDecimalTan.Length - 1)
            while jflow = 0 && (index > 270) do
                if ratio < this.noDecimalTan.[index] then
                    if ratio >= this.noDecimalTan.[index - 1] then
                        jret <- (int16 (index))
                        jflow <- 1
                    elif (this.noDecimalTan.[index - 1] = MAX_VALUE) && (ratio >= MIN_VALUE) then
                        jret <- (int16 (index))
                        jflow <- 1
                if jflow = 200002 then jflow <- 0
                if jflow = 0 then index <- index - 1
            if jflow = 100002 then jflow <- 0
        elif ((dx >= 0) && (dy >= 0)) then
            let mutable index : int = 90
            while jflow = 0 && (index > 0) do
                if (ratio < this.noDecimalTan.[index]) && (ratio >= this.noDecimalTan.[index - 1]) then
                    jret <- (int16 (index))
                    jflow <- 1
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index - 1
            if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append("Invalid Ratio: "))
            ignore (stringBuffer.appendlong(ratio))
            ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
            ignore (stringBuffer.append(PositionStrings.getInstance().DX_LABEL))
            ignore (stringBuffer.appendint(dx))
            ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
            ignore (stringBuffer.append(PositionStrings.getInstance().DX_LABEL))
            ignore (stringBuffer.appendint(dy))
            raise ((new JException(stringBuffer.ToString())))
        jret
    
    abstract antiTanDebug : screenX: int * screenY: int * targetX: int * targetY: int -> int16
    default this.antiTanDebug(screenX: int, screenY: int, targetX: int, targetY: int) : int16 =
        let mutable METHOD_NAME : string = "antiTanDebug"
        let mutable TARGET_ANGLE : string = " Targeting angle: "
        let mutable stringMaker : StringMaker = (new StringMaker())
        PreLogUtil.put(stringMaker.append("screenX: ").appendint(screenX).append(" screenY: ").appendint(screenY).append(" targetX: ").appendint(targetX).append(" targetY: ").appendint(targetY).ToString(), this, METHOD_NAME)
        let mutable targetX2 : int = -(targetX)
        let mutable targetY2 : int = -(targetY)
        let mutable screenX2 : int = -(screenX)
        let mutable screenY2 : int = -(screenY)
        let mutable dx : int[] = (Array.zeroCreate<int> (4))
        dx.[0] <- (screenX - targetX)
        dx.[1] <- (screenX - targetX2)
        dx.[2] <- (screenX2 - targetX)
        dx.[3] <- (screenX2 - targetX2)
        let mutable dy : int[] = (Array.zeroCreate<int> (4))
        dy.[0] <- (screenY - targetY)
        dy.[1] <- (screenY - targetY2)
        dy.[2] <- (screenY2 - targetY)
        dy.[3] <- (screenY2 - targetY2)
        let mutable angleOfTarget : int16 = 0s
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        let mutable angle : Angle = null
        let mutable index : int = 0
        while index < dx.Length do
            let mutable index2 : int = 0
            while index2 < dy.Length do
                angleOfTarget <- this.antiTan(dx.[index], dy.[index2])
                angle <- angleFactory.getAt(int (angleOfTarget))
                ignore (stringMaker.delete(0, stringMaker.length()))
                PreLogUtil.put(stringMaker.append(CommonLabels.getInstance().INDEX_LABEL).appendint(index).append(" index2: ").appendint(index2).append(PositionStrings.getInstance().DX_LABEL).appendint(dx.[index]).append(PositionStrings.getInstance().DY_LABEL).appendint(dy.[index2]).append(TARGET_ANGLE).appendshort(angleOfTarget).append(CommonSeps.getInstance().EQUALS).appendshort(angle.getValue()).ToString(), this, METHOD_NAME)
                index2 <- index2 + 1
            index <- index + 1
        angleOfTarget <- this.antiTan(dx.[0], dy.[0])
        angleOfTarget


