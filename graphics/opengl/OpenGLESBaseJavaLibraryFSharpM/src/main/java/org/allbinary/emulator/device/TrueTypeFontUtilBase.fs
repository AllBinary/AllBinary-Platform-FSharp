namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type TrueTypeFontUtilBase =
    [<DefaultValue(false)>] val mutable shortPattern : string
    [<DefaultValue(false)>] val mutable patternAsBytes : sbyte[]
    [<DefaultValue(false)>] val mutable pattern : string
    [<DefaultValue(false)>] val mutable charArray : int16[]
    [<DefaultValue(false)>] val mutable _characterWidth : int[]
    [<DefaultValue(false)>] val mutable characterArray : char[]
    [<DefaultValue(false)>] val mutable size : int
    [<DefaultValue(false)>] val mutable lastCapIndex : int
    [<DefaultValue(false)>] val mutable currentFont : Font
    [<DefaultValue(false)>] val mutable scale : int
    [<DefaultValue(false)>] val mutable CELLS_PER_ROW : int
    [<DefaultValue(false)>] val mutable fontSize : int
    [<DefaultValue(false)>] val mutable baseCharWidth : int
    [<DefaultValue(false)>] val mutable cellSize : int
    [<DefaultValue(false)>] val mutable textureSize : int
    [<DefaultValue(false)>] val mutable actualCellsPerRow : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TrueTypeFontUtilBase.jclinitDone then
            TrueTypeFontUtilBase.jclinitDone <- true
            TrueTypeFontUtilBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TrueTypeFontUtilBase() : unit =
        this.patternAsBytes <- ([| (32y); (48y); (49y); (50y); (51y); (52y); (53y); (54y); (55y); (56y); (57y); (65y); (66y); (32y); (32y); (32y); (67y); (68y); (69y); (70y); (71y); (72y); (73y); (74y); (75y); (76y); (77y); (78y); (79y); (32y); (32y); (32y); (80y); (81y); (82y); (83y); (84y); (85y); (86y); (87y); (88y); (89y); (90y); (97y); (98y); (32y); (32y); (32y); (99y); (100y); (101y); (102y); (103y); (104y); (105y); (106y); (107y); (108y); (109y); (110y); (111y); (32y); (32y); (32y); (112y); (113y); (114y); (115y); (116y); (117y); (118y); (119y); (120y); (121y); (122y); (46y); (63y); (32y); (32y); (32y); (33y); (36y); (37y); (96y); (-62y); (-84y); (-62y); (-84y); (34y); (-62y); (-93y); (-62y); (-93y); (94y); (38y); (42y); (40y); (32y); (32y); (32y); (41y); (95y); (43y); (45y); (61y); (91y); (93y); (123y); (125y); (59y); (39y); (35y); (58y); (32y); (32y); (32y); (64y); (126y); (44y); (47y); (60y); (62y); (92y); (124y); (-62y); (-82y); (-62y); (-82y); (-62y); (-87y); (-62y); (-87y) |] : sbyte[])
        this.pattern <- JString.newString(this.patternAsBytes)
        this.charArray <- ([| (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x6fs); (0x50s); (0x56s); (0x6bs); (0x51s); (0x52s); (0x5as); (0x6as); (0x5cs); (0x60s); (0x5bs); (0x62s); (0x72s); (0x63s); (0x4bs); (0x73s); (0x1s); (0x2s); (0x3s); (0x4s); (0x5s); (0x6s); (0x7s); (0x8s); (0x9s); (0xas); (0x6cs); (0x69s); (0x74s); (0x64s); (0x75s); (0x4cs); (0x70s); (0xbs); (0xcs); (0x10s); (0x11s); (0x12s); (0x13s); (0x14s); (0x15s); (0x16s); (0x17s); (0x18s); (0x19s); (0x1as); (0x1bs); (0x1cs); (0x20s); (0x21s); (0x22s); (0x23s); (0x24s); (0x25s); (0x26s); (0x27s); (0x28s); (0x29s); (0x2as); (0x65s); (0x76s); (0x66s); (0x59s); (0x61s); (0x53s); (0x2bs); (0x2cs); (0x30s); (0x31s); (0x32s); (0x33s); (0x34s); (0x35s); (0x36s); (0x37s); (0x38s); (0x39s); (0x3as); (0x3bs); (0x3cs); (0x40s); (0x41s); (0x42s); (0x43s); (0x44s); (0x45s); (0x46s); (0x47s); (0x48s); (0x49s); (0x4as); (0x67s); (0x77s); (0x68s); (0x71s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x58s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x7bs); (0x0s); (0x0s); (0x55s); (0x0s); (0x79s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s); (0x0s) |] : int16[])
        this._characterWidth <- (Array.zeroCreate<int> (JString.length(this.pattern)))
        this.characterArray <- (Array.zeroCreate<char> (1))
        this.size <- JString.length(this.pattern)
        this.lastCapIndex <- JString.indexOf(this.pattern, 'Z')
        this.currentFont <- Font.getDefaultFont()
        ()
    
    new (scale: int) as this =
        {  }
        then
            this.jfields_TrueTypeFontUtilBase()
            this.jctor1(scale)
    member this.jctor1(scale: int) : unit =
        let mutable shortPattern : string = StringUtil.getInstance().EMPTY_STRING
        if AvianUtil.isAvian() then
            let mutable shortPatterAsByteArray : sbyte[] = ([| (32y); (48y); (49y); (50y); (51y); (52y); (53y); (54y); (55y); (56y); (57y); (65y); (66y); (67y); (68y); (69y); (70y); (71y); (72y); (73y); (74y); (75y); (76y); (77y); (78y); (79y); (80y); (81y); (82y); (83y); (84y); (85y); (86y); (87y); (88y); (89y); (90y); (97y); (98y); (99y); (100y); (101y); (102y); (103y); (104y); (105y); (106y); (107y); (108y); (109y); (110y); (111y); (112y); (113y); (114y); (115y); (116y); (117y); (118y); (119y); (120y); (121y); (122y); (46y); (63y); (33y); (36y); (37y); (96y); (-62y); (-84y); (-62y); (-84y); (34y); (-62y); (-93y); (-62y); (-93y); (94y); (38y); (42y); (40y); (41y); (95y); (43y); (45y); (61y); (91y); (93y); (123y); (125y); (59y); (39y); (35y); (58y); (64y); (126y); (44y); (47y); (60y); (62y); (92y); (124y); (-62y); (-82y); (-62y); (-82y); (-62y); (-87y); (-62y); (-87y) |] : sbyte[])
            shortPattern <- JString.newString(shortPatterAsByteArray)
        else
            let mutable shortPatterAsByteArray : sbyte[] = ([| (32y); (48y); (49y); (50y); (51y); (52y); (53y); (54y); (55y); (56y); (57y); (65y); (66y); (67y); (68y); (69y); (70y); (71y); (72y); (73y); (74y); (75y); (76y); (77y); (78y); (79y); (80y); (81y); (82y); (83y); (84y); (85y); (86y); (87y); (88y); (89y); (90y); (97y); (98y); (99y); (100y); (101y); (102y); (103y); (104y); (105y); (106y); (107y); (108y); (109y); (110y); (111y); (112y); (113y); (114y); (115y); (116y); (117y); (118y); (119y); (120y); (121y); (122y); (46y); (63y); (33y); (36y); (37y); (96y); (-62y); (-84y); (34y); (-62y); (-93y); (94y); (38y); (42y); (40y); (41y); (95y); (43y); (45y); (61y); (91y); (93y); (123y); (125y); (59y); (39y); (35y); (58y); (64y); (126y); (44y); (47y); (60y); (62y); (92y); (124y); (-62y); (-82y); (-62y); (-87y) |] : sbyte[])
            shortPattern <- JString.newString(shortPatterAsByteArray)
        this.shortPattern <- shortPattern
        this.scale <- scale
        this.CELLS_PER_ROW <- 16
        this.fontSize <- (20 + 6) * this.scale
        this.baseCharWidth <- this.fontSize + (6 * this.scale)
        this.cellSize <- this.fontSize + (6 * this.scale)
        this.textureSize <- this.getAsTextureSize((this.CELLS_PER_ROW * this.cellSize))
        this.actualCellsPerRow <- this.textureSize / this.cellSize
        ()
    
    abstract getAsTextureSize : textureSize: int -> int
    default this.getAsTextureSize(textureSize: int) : int =
        let mutable textureSize = textureSize
        if textureSize <= 64 then
            textureSize <- 64
        elif textureSize <= 128 then
            textureSize <- 128
        elif textureSize <= 256 then
            textureSize <- 256
        elif textureSize <= 512 then
            textureSize <- 512
        elif textureSize <= 1024 then
            textureSize <- 1024
        textureSize
    
    abstract getCellSize : cellSize: int -> int
    default this.getCellSize(cellSize: int) : int =
        let mutable cellSize = cellSize
        if cellSize <= 16 then
            cellSize <- 16
        elif cellSize <= 32 then
            cellSize <- 32
        elif cellSize <= 64 then
            cellSize <- 64
        elif cellSize <= 128 then
            cellSize <- 128
        elif cellSize <= 256 then
            cellSize <- 256
        cellSize
    
    abstract getYOffset : unit -> int
    default this.getYOffset() : int =
        ((this.scale - 1) * this.cellSize)


